namespace Desocultator
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloqueosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBloqueaNoExtraibles = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalInformativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLimite25 = new System.Windows.Forms.ToolStripMenuItem();
            this.mLimite50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mLimite100 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAccion = new System.Windows.Forms.GroupBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnMostrarArchivos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.gbArchivos = new System.Windows.Forms.GroupBox();
            this.listFiles = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAtributos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTerminal = new System.Windows.Forms.GroupBox();
            this.txtConsola = new System.Windows.Forms.TextBox();
            this.menuPrincipal.SuspendLayout();
            this.gbAccion.SuspendLayout();
            this.gbArchivos.SuspendLayout();
            this.gbTerminal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(542, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menu";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloqueosToolStripMenuItem,
            this.configuracionToolStripMenuItem1});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.configuracionToolStripMenuItem.Text = "Opciones";
            // 
            // bloqueosToolStripMenuItem
            // 
            this.bloqueosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBloqueaNoExtraibles});
            this.bloqueosToolStripMenuItem.Name = "bloqueosToolStripMenuItem";
            this.bloqueosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bloqueosToolStripMenuItem.Text = "Bloqueos";
            // 
            // mBloqueaNoExtraibles
            // 
            this.mBloqueaNoExtraibles.Checked = true;
            this.mBloqueaNoExtraibles.CheckOnClick = true;
            this.mBloqueaNoExtraibles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mBloqueaNoExtraibles.Name = "mBloqueaNoExtraibles";
            this.mBloqueaNoExtraibles.Size = new System.Drawing.Size(241, 22);
            this.mBloqueaNoExtraibles.Text = "Bloquear unidades no extraibles";
            this.mBloqueaNoExtraibles.Click += new System.EventHandler(this.mBloqueaNoExtraibles_Click);
            // 
            // configuracionToolStripMenuItem1
            // 
            this.configuracionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalInformativaToolStripMenuItem});
            this.configuracionToolStripMenuItem1.Name = "configuracionToolStripMenuItem1";
            this.configuracionToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem1.Text = "Configuracion";
            // 
            // terminalInformativaToolStripMenuItem
            // 
            this.terminalInformativaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLimite25,
            this.mLimite50,
            this.mLimite100});
            this.terminalInformativaToolStripMenuItem.Name = "terminalInformativaToolStripMenuItem";
            this.terminalInformativaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.terminalInformativaToolStripMenuItem.Text = "Terminal informativa";
            // 
            // mLimite25
            // 
            this.mLimite25.Name = "mLimite25";
            this.mLimite25.Size = new System.Drawing.Size(125, 22);
            this.mLimite25.Text = "25 lineas";
            this.mLimite25.Click += new System.EventHandler(this.aumentarLimiteLineasTerminal);
            // 
            // mLimite50
            // 
            this.mLimite50.Name = "mLimite50";
            this.mLimite50.Size = new System.Drawing.Size(125, 22);
            this.mLimite50.Text = "50 lineas";
            this.mLimite50.Click += new System.EventHandler(this.aumentarLimiteLineasTerminal);
            // 
            // mLimite100
            // 
            this.mLimite100.Name = "mLimite100";
            this.mLimite100.Size = new System.Drawing.Size(125, 22);
            this.mLimite100.Text = "100 lineas";
            this.mLimite100.Click += new System.EventHandler(this.aumentarLimiteLineasTerminal);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gbAccion
            // 
            this.gbAccion.Controls.Add(this.btnRecuperar);
            this.gbAccion.Controls.Add(this.btnMostrarArchivos);
            this.gbAccion.Controls.Add(this.btnActualizar);
            this.gbAccion.Controls.Add(this.cmbDrives);
            this.gbAccion.Location = new System.Drawing.Point(12, 27);
            this.gbAccion.Name = "gbAccion";
            this.gbAccion.Size = new System.Drawing.Size(172, 79);
            this.gbAccion.TabIndex = 1;
            this.gbAccion.TabStop = false;
            this.gbAccion.Text = "Accion";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(88, 47);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 3;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnMostrarArchivos
            // 
            this.btnMostrarArchivos.Location = new System.Drawing.Point(7, 47);
            this.btnMostrarArchivos.Name = "btnMostrarArchivos";
            this.btnMostrarArchivos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarArchivos.TabIndex = 2;
            this.btnMostrarArchivos.Text = "Mostrar unidad";
            this.btnMostrarArchivos.UseVisualStyleBackColor = true;
            this.btnMostrarArchivos.Click += new System.EventHandler(this.btnMostrarArchivos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::Desocultator.Properties.Resources.refresh_small;
            this.btnActualizar.Location = new System.Drawing.Point(127, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(36, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbDrives
            // 
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(7, 20);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(114, 21);
            this.cmbDrives.TabIndex = 0;
            // 
            // gbArchivos
            // 
            this.gbArchivos.Controls.Add(this.listFiles);
            this.gbArchivos.Location = new System.Drawing.Point(190, 27);
            this.gbArchivos.Name = "gbArchivos";
            this.gbArchivos.Size = new System.Drawing.Size(341, 206);
            this.gbArchivos.TabIndex = 2;
            this.gbArchivos.TabStop = false;
            this.gbArchivos.Text = "Contenido de la unidad";
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chAtributos});
            this.listFiles.Location = new System.Drawing.Point(7, 20);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(328, 180);
            this.listFiles.TabIndex = 0;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 187;
            // 
            // chAtributos
            // 
            this.chAtributos.Text = "Atributos";
            this.chAtributos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAtributos.Width = 137;
            // 
            // gbTerminal
            // 
            this.gbTerminal.Controls.Add(this.txtConsola);
            this.gbTerminal.Location = new System.Drawing.Point(12, 242);
            this.gbTerminal.Name = "gbTerminal";
            this.gbTerminal.Size = new System.Drawing.Size(519, 100);
            this.gbTerminal.TabIndex = 3;
            this.gbTerminal.TabStop = false;
            this.gbTerminal.Text = "Terminal informativa";
            // 
            // txtConsola
            // 
            this.txtConsola.BackColor = System.Drawing.Color.Black;
            this.txtConsola.ForeColor = System.Drawing.Color.Lime;
            this.txtConsola.Location = new System.Drawing.Point(7, 20);
            this.txtConsola.Multiline = true;
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.Size = new System.Drawing.Size(511, 74);
            this.txtConsola.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 354);
            this.Controls.Add(this.gbTerminal);
            this.Controls.Add(this.gbArchivos);
            this.Controls.Add(this.gbAccion);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.Text = "Desocultator";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.gbAccion.ResumeLayout(false);
            this.gbArchivos.ResumeLayout(false);
            this.gbTerminal.ResumeLayout(false);
            this.gbTerminal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloqueosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBloqueaNoExtraibles;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAccion;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnMostrarArchivos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.GroupBox gbArchivos;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chAtributos;
        private System.Windows.Forms.GroupBox gbTerminal;
        private System.Windows.Forms.TextBox txtConsola;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem terminalInformativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLimite25;
        private System.Windows.Forms.ToolStripMenuItem mLimite50;
        private System.Windows.Forms.ToolStripMenuItem mLimite100;
    }
}

