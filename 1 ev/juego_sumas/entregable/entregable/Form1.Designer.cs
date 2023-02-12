namespace entregable
{
    partial class juego
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
            this.lbRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPuntuacion = new System.Windows.Forms.Label();
            this.lbrandom1 = new System.Windows.Forms.Label();
            this.lbrandom2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnresp1 = new System.Windows.Forms.Button();
            this.btnresp2 = new System.Windows.Forms.Button();
            this.btnresp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record:";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(110, 57);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(41, 13);
            this.lbRecord.TabIndex = 1;
            this.lbRecord.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puntuación:";
            // 
            // lbPuntuacion
            // 
            this.lbPuntuacion.AutoSize = true;
            this.lbPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntuacion.Location = new System.Drawing.Point(322, 57);
            this.lbPuntuacion.Name = "lbPuntuacion";
            this.lbPuntuacion.Size = new System.Drawing.Size(41, 13);
            this.lbPuntuacion.TabIndex = 3;
            this.lbPuntuacion.Text = "label4";
            // 
            // lbrandom1
            // 
            this.lbrandom1.AutoSize = true;
            this.lbrandom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrandom1.Location = new System.Drawing.Point(70, 113);
            this.lbrandom1.Name = "lbrandom1";
            this.lbrandom1.Size = new System.Drawing.Size(41, 13);
            this.lbrandom1.TabIndex = 4;
            this.lbrandom1.Text = "label5";
            // 
            // lbrandom2
            // 
            this.lbrandom2.AutoSize = true;
            this.lbrandom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrandom2.Location = new System.Drawing.Point(161, 113);
            this.lbrandom2.Name = "lbrandom2";
            this.lbrandom2.Size = new System.Drawing.Size(41, 13);
            this.lbrandom2.TabIndex = 5;
            this.lbrandom2.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "=";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.Location = new System.Drawing.Point(286, 113);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(41, 13);
            this.lbresult.TabIndex = 7;
            this.lbresult.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "+";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(98, 319);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(96, 23);
            this.btnJugar.TabIndex = 9;
            this.btnJugar.Text = "JUGAR MÁS";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 319);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnresp1
            // 
            this.btnresp1.BackColor = System.Drawing.Color.PaleGreen;
            this.btnresp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresp1.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnresp1.Location = new System.Drawing.Point(163, 140);
            this.btnresp1.Name = "btnresp1";
            this.btnresp1.Size = new System.Drawing.Size(99, 47);
            this.btnresp1.TabIndex = 11;
            this.btnresp1.Text = "button1";
            this.btnresp1.UseVisualStyleBackColor = false;
            this.btnresp1.Click += new System.EventHandler(this.btnresp1_Click);
            // 
            // btnresp2
            // 
            this.btnresp2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnresp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresp2.ForeColor = System.Drawing.Color.Teal;
            this.btnresp2.Location = new System.Drawing.Point(163, 193);
            this.btnresp2.Name = "btnresp2";
            this.btnresp2.Size = new System.Drawing.Size(99, 47);
            this.btnresp2.TabIndex = 12;
            this.btnresp2.Text = "button2";
            this.btnresp2.UseVisualStyleBackColor = false;
            this.btnresp2.Click += new System.EventHandler(this.btnresp2_Click);
            // 
            // btnresp3
            // 
            this.btnresp3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnresp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresp3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnresp3.Location = new System.Drawing.Point(164, 248);
            this.btnresp3.Name = "btnresp3";
            this.btnresp3.Size = new System.Drawing.Size(99, 47);
            this.btnresp3.TabIndex = 13;
            this.btnresp3.Text = "button3";
            this.btnresp3.UseVisualStyleBackColor = false;
            this.btnresp3.Click += new System.EventHandler(this.btnresp3_Click);
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 370);
            this.Controls.Add(this.btnresp3);
            this.Controls.Add(this.btnresp2);
            this.Controls.Add(this.btnresp1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbrandom2);
            this.Controls.Add(this.lbrandom1);
            this.Controls.Add(this.lbPuntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Name = "juego";
            this.Text = "JUEGO MATEMATICO SUMAS";
            this.Load += new System.EventHandler(this.juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPuntuacion;
        private System.Windows.Forms.Label lbrandom1;
        private System.Windows.Forms.Label lbrandom2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnresp1;
        private System.Windows.Forms.Button btnresp2;
        private System.Windows.Forms.Button btnresp3;
    }
}

