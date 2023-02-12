namespace Ejercicio4
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
            this.lbText1 = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbText3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.Location = new System.Drawing.Point(114, 102);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(111, 13);
            this.lbText1.TabIndex = 0;
            this.lbText1.Text = "Nota del alumno 1: 44";
            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Location = new System.Drawing.Point(117, 152);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(111, 13);
            this.lbText2.TabIndex = 1;
            this.lbText2.Text = "Nota del alumno 2: 51";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(120, 203);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbText3
            // 
            this.lbText3.AutoSize = true;
            this.lbText3.Location = new System.Drawing.Point(327, 125);
            this.lbText3.Name = "lbText3";
            this.lbText3.Size = new System.Drawing.Size(35, 13);
            this.lbText3.TabIndex = 3;
            this.lbText3.Text = "label1";
            this.lbText3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbText3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.lbText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbText3;
    }
}

