namespace ejercicio
{
    partial class Ejemplo3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.ofdCargarFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.btnPerso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOTO";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(306, 55);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(191, 226);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(113, 318);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(191, 68);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR IMAGEN";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ofdCargarFoto
            // 
            this.ofdCargarFoto.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(344, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 68);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR IMAGEN";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(546, 318);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(154, 68);
            this.btnPerso.TabIndex = 4;
            this.btnPerso.Text = "PERSONALIZADO";
            this.btnPerso.UseVisualStyleBackColor = true;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // Ejemplo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label1);
            this.Name = "Ejemplo3";
            this.Text = "Ejemplo3";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog ofdCargarFoto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.Button btnPerso;
    }
}