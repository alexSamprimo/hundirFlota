namespace Ejercicio5
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btn1c = new System.Windows.Forms.Button();
            this.btn1f = new System.Windows.Forms.Button();
            this.lbtext1 = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.txtBoxF = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(78, 12);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(98, 47);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Convertir C a F";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click_1);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(525, 12);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(102, 46);
            this.btnF.TabIndex = 1;
            this.btnF.Text = "Convertir F a C";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(345, 283);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 33);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btn1c
            // 
            this.btn1c.Location = new System.Drawing.Point(525, 123);
            this.btn1c.Name = "btn1c";
            this.btn1c.Size = new System.Drawing.Size(75, 23);
            this.btn1c.TabIndex = 3;
            this.btn1c.Text = "+1";
            this.btn1c.UseVisualStyleBackColor = true;
            this.btn1c.Click += new System.EventHandler(this.btn1c_Click);
            // 
            // btn1f
            // 
            this.btn1f.Location = new System.Drawing.Point(525, 195);
            this.btn1f.Name = "btn1f";
            this.btn1f.Size = new System.Drawing.Size(75, 23);
            this.btn1f.TabIndex = 4;
            this.btn1f.Text = "+1";
            this.btn1f.UseVisualStyleBackColor = true;
            this.btn1f.Click += new System.EventHandler(this.btn1f_Click);
            // 
            // lbtext1
            // 
            this.lbtext1.AutoSize = true;
            this.lbtext1.Location = new System.Drawing.Point(110, 132);
            this.lbtext1.Name = "lbtext1";
            this.lbtext1.Size = new System.Drawing.Size(100, 13);
            this.lbtext1.TabIndex = 5;
            this.lbtext1.Text = "Grados Centigrados";
            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Location = new System.Drawing.Point(113, 204);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(88, 13);
            this.lbText2.TabIndex = 6;
            this.lbText2.Text = "Grados Farenheit";
            this.lbText2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxF
            // 
            this.txtBoxF.Location = new System.Drawing.Point(345, 204);
            this.txtBoxF.Name = "txtBoxF";
            this.txtBoxF.Size = new System.Drawing.Size(100, 20);
            this.txtBoxF.TabIndex = 7;
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(345, 132);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.txtBoxF);
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.lbtext1);
            this.Controls.Add(this.btn1f);
            this.Controls.Add(this.btn1c);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btn1c;
        private System.Windows.Forms.Button btn1f;
        private System.Windows.Forms.Label lbtext1;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.TextBox txtBoxF;
        private System.Windows.Forms.TextBox txtBoxC;
    }
}

