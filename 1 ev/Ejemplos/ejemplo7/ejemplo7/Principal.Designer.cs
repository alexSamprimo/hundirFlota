namespace ejemplo7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eJEMPLOSANTERIORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUADROSDEDIALOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJEMPLOSANTERIORESToolStripMenuItem,
            this.cUADROSDEDIALOGOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eJEMPLOSANTERIORESToolStripMenuItem
            // 
            this.eJEMPLOSANTERIORESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo1ToolStripMenuItem,
            this.ejemplo2ToolStripMenuItem});
            this.eJEMPLOSANTERIORESToolStripMenuItem.Name = "eJEMPLOSANTERIORESToolStripMenuItem";
            this.eJEMPLOSANTERIORESToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.eJEMPLOSANTERIORESToolStripMenuItem.Text = "EJEMPLOS ANTERIORES";
            this.eJEMPLOSANTERIORESToolStripMenuItem.Click += new System.EventHandler(this.eJEMPLOSANTERIORESToolStripMenuItem_Click);
            // 
            // ejemplo1ToolStripMenuItem
            // 
            this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
            this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo1ToolStripMenuItem.Text = "Ejemplo1";
            this.ejemplo1ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo1ToolStripMenuItem_Click);
            // 
            // ejemplo2ToolStripMenuItem
            // 
            this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
            this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo2ToolStripMenuItem.Text = "Ejemplo2";
            this.ejemplo2ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo2ToolStripMenuItem_Click);
            // 
            // cUADROSDEDIALOGOToolStripMenuItem
            // 
            this.cUADROSDEDIALOGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo7ToolStripMenuItem});
            this.cUADROSDEDIALOGOToolStripMenuItem.Name = "cUADROSDEDIALOGOToolStripMenuItem";
            this.cUADROSDEDIALOGOToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.cUADROSDEDIALOGOToolStripMenuItem.Text = "CUADROS DE DIALOGO";
            this.cUADROSDEDIALOGOToolStripMenuItem.Click += new System.EventHandler(this.cUADROSDEDIALOGOToolStripMenuItem_Click);
            // 
            // ejemplo7ToolStripMenuItem
            // 
            this.ejemplo7ToolStripMenuItem.Name = "ejemplo7ToolStripMenuItem";
            this.ejemplo7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo7ToolStripMenuItem.Text = "Ejemplo8";
            this.ejemplo7ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo7ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Ejemplo7: Menus y cuadros de dialogo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eJEMPLOSANTERIORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUADROSDEDIALOGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo7ToolStripMenuItem;
    }
}

