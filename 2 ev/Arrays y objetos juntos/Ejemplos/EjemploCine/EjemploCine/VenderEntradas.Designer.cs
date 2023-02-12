namespace EjemploCine
{
    partial class VenderEntradas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lbButacasLibres = new System.Windows.Forms.Label();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.lbingresosSala = new System.Windows.Forms.Label();
            this.lbIngresosTotales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Butacas Libres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje de ocupacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresos Sala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresos Totales:";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(154, 30);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(319, 21);
            this.cbSala.TabIndex = 5;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(39, 89);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(162, 58);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "VENDER ENTRADA";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(338, 89);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(153, 58);
            this.btnVaciar.TabIndex = 7;
            this.btnVaciar.Text = "VACIAR SALA";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // lbButacasLibres
            // 
            this.lbButacasLibres.AutoSize = true;
            this.lbButacasLibres.Location = new System.Drawing.Point(154, 178);
            this.lbButacasLibres.Name = "lbButacasLibres";
            this.lbButacasLibres.Size = new System.Drawing.Size(0, 13);
            this.lbButacasLibres.TabIndex = 8;
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Location = new System.Drawing.Point(174, 235);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lbPorcentaje.TabIndex = 9;
            // 
            // lbingresosSala
            // 
            this.lbingresosSala.AutoSize = true;
            this.lbingresosSala.Location = new System.Drawing.Point(532, 177);
            this.lbingresosSala.Name = "lbingresosSala";
            this.lbingresosSala.Size = new System.Drawing.Size(0, 13);
            this.lbingresosSala.TabIndex = 10;
            // 
            // lbIngresosTotales
            // 
            this.lbIngresosTotales.AutoSize = true;
            this.lbIngresosTotales.Location = new System.Drawing.Point(535, 220);
            this.lbIngresosTotales.Name = "lbIngresosTotales";
            this.lbIngresosTotales.Size = new System.Drawing.Size(0, 13);
            this.lbIngresosTotales.TabIndex = 11;
            // 
            // VenderEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIngresosTotales);
            this.Controls.Add(this.lbingresosSala);
            this.Controls.Add(this.lbPorcentaje);
            this.Controls.Add(this.lbButacasLibres);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VenderEntradas";
            this.Text = "VenderEntradas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lbButacasLibres;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.Label lbingresosSala;
        private System.Windows.Forms.Label lbIngresosTotales;
    }
}