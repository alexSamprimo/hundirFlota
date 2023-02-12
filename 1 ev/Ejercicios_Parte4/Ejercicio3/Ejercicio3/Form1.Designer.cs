namespace Ejercicio3
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
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(288, 123);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(26, 20);
            this.nudA.TabIndex = 0;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(329, 123);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(32, 20);
            this.nudB.TabIndex = 1;
            // 
            // nudC
            // 
            this.nudC.Location = new System.Drawing.Point(392, 123);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(32, 20);
            this.nudC.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(315, 168);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Enabled = false;
            this.txtBoxResultado.Location = new System.Drawing.Point(288, 215);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(140, 20);
            this.txtBoxResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtBoxResultado;
    }
}

