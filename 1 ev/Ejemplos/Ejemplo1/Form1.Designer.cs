namespace Ejemplo1
{
    partial class Form1
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
            this.btnApretar = new System.Windows.Forms.Button();
            this.lbSaludo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApretar
            // 
            this.btnApretar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApretar.Location = new System.Drawing.Point(147, 53);
            this.btnApretar.Name = "btnApretar";
            this.btnApretar.Size = new System.Drawing.Size(113, 41);
            this.btnApretar.TabIndex = 0;
            this.btnApretar.Text = "Aprieta aquí";
            this.btnApretar.UseVisualStyleBackColor = true;
            this.btnApretar.Click += new System.EventHandler(this.btnApretar_Click);
            // 
            // lbSaludo
            // 
            this.lbSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaludo.Location = new System.Drawing.Point(142, 129);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(129, 38);
            this.lbSaludo.TabIndex = 1;
            this.lbSaludo.Text = "Hola Mundo";
            this.lbSaludo.Visible = false;
            
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(147, 184);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(113, 39);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lbSaludo);
            this.Controls.Add(this.btnApretar);
            this.Name = "Form1";
            this.Text = "Ejemplo1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApretar;
        private System.Windows.Forms.Label lbSaludo;
        private System.Windows.Forms.Button btnBorrar;
    }
}

