namespace EjemploCine
{
    partial class Configurador
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudOcupadas = new System.Windows.Forms.NumericUpDown();
            this.nudAforo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(128, 22);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(514, 21);
            this.cbSala.TabIndex = 1;
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(244, 295);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(241, 29);
            this.btnTerminado.TabIndex = 2;
            this.btnTerminado.Text = "TERMINADO";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudOcupadas);
            this.groupBox1.Controls.Add(this.nudAforo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPelicula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // nudOcupadas
            // 
            this.nudOcupadas.Location = new System.Drawing.Point(98, 113);
            this.nudOcupadas.Name = "nudOcupadas";
            this.nudOcupadas.Size = new System.Drawing.Size(120, 20);
            this.nudOcupadas.TabIndex = 9;
            // 
            // nudAforo
            // 
            this.nudAforo.Location = new System.Drawing.Point(98, 78);
            this.nudAforo.Name = "nudAforo";
            this.nudAforo.Size = new System.Drawing.Size(120, 20);
            this.nudAforo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(363, 117);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(37, 17);
            this.rb8.TabIndex = 6;
            this.rb8.TabStop = true;
            this.rb8.Text = "8€";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(363, 97);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(46, 17);
            this.rb6.TabIndex = 5;
            this.rb6.TabStop = true;
            this.rb6.Text = "6,5€";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(363, 74);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(37, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "5€";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocupadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aforo";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(98, 34);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(269, 20);
            this.txtPelicula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pelicula";
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.label1);
            this.Name = "Configurador";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudOcupadas;
        private System.Windows.Forms.NumericUpDown nudAforo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label label2;
    }
}

