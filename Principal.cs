using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desocultator
{
    public partial class Principal : Form
    {
        public bool bloqueaHD = true;
        public int limiteLineasConsola = 25;

        public Principal()
        {
            InitializeComponent();
            buscaUnidadesDrive();
            Consola("Bienvenido");
        }

        private void Consola(string msj)
        {
            if (txtConsola.Lines.Count() > limiteLineasConsola)
                txtConsola.Clear();

            string simbolo = (bloqueaHD) ? "$" : "#";
            txtConsola.AppendText(simbolo + " " + msj + "\r\n");
            gbTerminal.Text = "Terminal Informativa: mostrando " + (txtConsola.Lines.Count() - 1) + " lineas" +
                " de " + limiteLineasConsola;
        }

        public String ejecutarComando(string comando)
        {
            Consola("ejecutando: " + comando);
            listFiles.Items.Clear();
            DriveInfo unidad = new DriveInfo(cmbDrives.Text);

            if (unidad.DriveType == DriveType.Fixed && bloqueaHD == true)
            {
                string msj = "Por seguridad, esta opcion ha sido bloqueada\nen unidades no extraibles.";
                MessageBox.Show(msj);
                return msj;
            }

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + comando);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            string result = proc.StandardOutput.ReadToEnd();
            return (result.Length > 1) ? result : "comando ejecutado";
        }

        /**
         * Busca unidades drive conectadas al equipo y actualiza la lista
         */
        private void buscaUnidadesDrive()
        {
            cmbDrives.Items.Clear();
            IEnumerable<DriveInfo> unidadesDrive = DriveInfo.GetDrives().Where(c => c.DriveType == DriveType.Fixed || c.DriveType == DriveType.Removable);
            foreach (DriveInfo d in unidadesDrive)
                if (d.IsReady == true)
                    cmbDrives.Items.Add(d.Name);
            cmbDrives.SelectedIndex = 0;
            Consola("Unidades de almacenamiento cargadas");
        }

        private void buscaArchivos(string ruta)
        {
            listFiles.Items.Clear();
            DriveInfo unidad = new DriveInfo(ruta);

            if (unidad.DriveType == DriveType.Fixed && bloqueaHD == true)
            {
                string msj = "La unidad que elegiste no parece ser una memoria USB, ¿deseas continuar?";
                DialogResult op = MessageBox.Show(msj, "Unidad NO extraible", MessageBoxButtons.YesNo);
                Consola(msj);
                if (op == DialogResult.No)
                    return;
            }

            /*
            DriveInfo drive= new DriveInfo(ruta);
            string msj = "";
            msj += "Espacio disponible: "+ drive.AvailableFreeSpace + "\n";
            msj += "Formato: "+ drive.DriveFormat + "\n";
            msj += "Tipo: "+ drive.DriveType + "\n";
            msj += "Nombre: "+ drive.Name + "\n";
            msj += "Raíz: "+ drive.RootDirectory + "\n";
            msj += "Espacio total disponible: "+ drive.TotalFreeSpace + "\n";
            msj += "Tamaño total:"+ drive.TotalSize + "\n";
            msj += "Etiqueta: "+ drive.VolumeLabel + "\n";
            MessageBox.Show(msj);
            */

            ListViewItem item;
            Color color;
            foreach (DirectoryInfo f in unidad.RootDirectory.GetDirectories())
            {
                color = Color.Black;
                item = new ListViewItem(f.Name);
                item.SubItems.Add(f.Attributes.ToString());
                if ((f.Attributes & FileAttributes.System) == FileAttributes.System)
                {
                    color = Color.LightGray;
                    item.BackColor = Color.Black;
                }
                else if ((f.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    color = Color.Green;

                item.ForeColor = color;

                listFiles.Items.Add(item);
            }

            FileInfo[] fileNames = unidad.RootDirectory.GetFiles("*.*");
            foreach (FileInfo f in fileNames)
            {
                color = Color.Black;
                item = new ListViewItem(f.Name);
                item.SubItems.Add(f.Attributes.ToString());
                if ((f.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    color = Color.Green;
                item.ForeColor = color;
                listFiles.Items.Add(item);
                //listFiles.Items.Add(f.Name + " " + f.LastAccessTime + " " + f.Length);
            }

            gbArchivos.Text = "Contendio de la unidad " + unidad.ToString();
        }



        private void mBloqueaNoExtraibles_Click(object sender, EventArgs e)
        {
            if (bloqueaHD)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Estas a punto de desbloquear unidades NO EXTRAIBLES\n" +
                    "como el disco duro de tu equipo, debes comprender\n" +
                    "completamente los riesgos que se pueden provocar\n\n¿Deseas continuar?",
                    "ADVERTENCIA",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                    return;
            }

            string msj = "Las unidades no extraibles fueron ";
            bloqueaHD = !bloqueaHD;
            mBloqueaNoExtraibles.Checked = bloqueaHD;

            msj += (bloqueaHD) ? "bloqueadas" : "desbloqueadas";
            Consola(msj);
        }

        private void aumentarLimiteLineasTerminal(object sender, EventArgs e)
        {

            switch (sender.ToString())
            {
                case "25 lineas":
                    limiteLineasConsola = 25;
                    mLimite50.Checked = mLimite100.Checked = false;
                    break;
                case "50 lineas":
                    limiteLineasConsola = 50;
                    mLimite25.Checked = mLimite100.Checked = false;
                    break;
                case "100 lineas":
                    limiteLineasConsola = 100;
                    mLimite25.Checked = mLimite50.Checked = false;
                    break;
            }
            Consola("cambiando a " + sender.ToString());
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            String res = ejecutarComando("attrib  -r -a -s -h " + cmbDrives.Text + "/*.* /s /d");
            Consola(res);
        }

        private void btnMostrarArchivos_Click(object sender, EventArgs e)
        {
            if (cmbDrives.Text != string.Empty)
            {
                buscaArchivos(cmbDrives.Text);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una unidad");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gbAccion.Enabled = false;
            Consola("Actualizando lista de dispositivos");
            buscaUnidadesDrive();
            gbAccion.Enabled = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".:|:. Darth Leonard .:|:.\nleolinuxmx@gmail.com\n@copyleft", "Acerca de este software");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
