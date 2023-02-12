namespace ejercicio
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
            this.eJEMPLO1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJEMPLO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUADROSDEDIALOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJEMPLO7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eJEMPLOSANTERIORESToolStripMenuItem
            // 
            this.eJEMPLOSANTERIORESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJEMPLO1ToolStripMenuItem,
            this.eJEMPLO2ToolStripMenuItem});
            this.eJEMPLOSANTERIORESToolStripMenuItem.Name = "eJEMPLOSANTERIORESToolStripMenuItem";
            this.eJEMPLOSANTERIORESToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.eJEMPLOSANTERIORESToolStripMenuItem.Text = "EJEMPLOS ANTERIORES";
            // 
            // eJEMPLO1ToolStripMenuItem
            // 
            this.eJEMPLO1ToolStripMenuItem.Name = "eJEMPLO1ToolStripMenuItem";
            this.eJEMPLO1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.eJEMPLO1ToolStripMenuItem.Text = "EJEMPLO1";
            this.eJEMPLO1ToolStripMenuItem.Click += new System.EventHandler(this.eJEMPLO1ToolStripMenuItem_Click);
            // 
            // eJEMPLO2ToolStripMenuItem
            // 
            this.eJEMPLO2ToolStripMenuItem.Name = "eJEMPLO2ToolStripMenuItem";
            this.eJEMPLO2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.eJEMPLO2ToolStripMenuItem.Text = "EJEMPLO2";
            this.eJEMPLO2ToolStripMenuItem.Click += new System.EventHandler(this.eJEMPLO2ToolStripMenuItem_Click);
            // 
            // cUADROSDEDIALOGOToolStripMenuItem
            // 
            this.cUADROSDEDIALOGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJEMPLO7ToolStripMenuItem});
            this.cUADROSDEDIALOGOToolStripMenuItem.Name = "cUADROSDEDIALOGOToolStripMenuItem";
            this.cUADROSDEDIALOGOToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.cUADROSDEDIALOGOToolStripMenuItem.Text = "CUADROS DE DIALOGO";
            // 
            // eJEMPLO7ToolStripMenuItem
            // 
            this.eJEMPLO7ToolStripMenuItem.Name = "eJEMPLO7ToolStripMenuItem";
            this.eJEMPLO7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eJEMPLO7ToolStripMenuItem.Text = "EJEMPLO7";
            this.eJEMPLO7ToolStripMenuItem.Click += new System.EventHandler(this.eJEMPLO7ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eJEMPLOSANTERIORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJEMPLO1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJEMPLO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUADROSDEDIALOGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJEMPLO7ToolStripMenuItem;
    }
}

