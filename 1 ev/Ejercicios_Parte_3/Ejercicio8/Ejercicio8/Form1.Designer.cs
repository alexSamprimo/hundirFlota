namespace Ejercicio8
{
    partial class Ejercicio8
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
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijeras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPiedra
            // 
            this.btnPiedra.Location = new System.Drawing.Point(261, 226);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(75, 23);
            this.btnPiedra.TabIndex = 0;
            this.btnPiedra.Text = "PIEDRA";
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(373, 226);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(75, 23);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.Text = "PAPEL";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTijeras
            // 
            this.btnTijeras.Location = new System.Drawing.Point(486, 226);
            this.btnTijeras.Name = "btnTijeras";
            this.btnTijeras.Size = new System.Drawing.Size(75, 23);
            this.btnTijeras.TabIndex = 2;
            this.btnTijeras.Text = "TIJERAS";
            this.btnTijeras.UseVisualStyleBackColor = true;
            this.btnTijeras.Click += new System.EventHandler(this.btnTijeras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIGE PIEDRA PAPEL O TIJERAS";
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTijeras);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Name = "Ejercicio8";
            this.Text = "Ejercicio8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijeras;
        private System.Windows.Forms.Label label1;
    }
}

