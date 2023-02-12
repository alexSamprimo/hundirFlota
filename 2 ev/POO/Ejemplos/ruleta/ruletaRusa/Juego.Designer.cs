namespace ruletaRusa
{
    partial class Juego
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
            this.btnCargarBala = new System.Windows.Forms.Button();
            this.btnGirarTambor = new System.Windows.Forms.Button();
            this.gbOrdenador = new System.Windows.Forms.GroupBox();
            this.lbOrEstado = new System.Windows.Forms.Label();
            this.lbOrTurno = new System.Windows.Forms.Label();
            this.btnOrDisparar = new System.Windows.Forms.Button();
            this.lbOrDerrotas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbJrDerrotas = new System.Windows.Forms.Label();
            this.btnJrDisparar = new System.Windows.Forms.Button();
            this.lbJrTurno = new System.Windows.Forms.Label();
            this.lbJrEstado = new System.Windows.Forms.Label();
            this.gbOrdenador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarBala
            // 
            this.btnCargarBala.Location = new System.Drawing.Point(99, 33);
            this.btnCargarBala.Name = "btnCargarBala";
            this.btnCargarBala.Size = new System.Drawing.Size(111, 54);
            this.btnCargarBala.TabIndex = 0;
            this.btnCargarBala.Text = "CARGAR BALA";
            this.btnCargarBala.UseVisualStyleBackColor = true;
            this.btnCargarBala.Click += new System.EventHandler(this.btnCargarBala_Click);
            // 
            // btnGirarTambor
            // 
            this.btnGirarTambor.Enabled = false;
            this.btnGirarTambor.Location = new System.Drawing.Point(457, 33);
            this.btnGirarTambor.Name = "btnGirarTambor";
            this.btnGirarTambor.Size = new System.Drawing.Size(108, 54);
            this.btnGirarTambor.TabIndex = 1;
            this.btnGirarTambor.Text = "GIRAR TAMBOR";
            this.btnGirarTambor.UseVisualStyleBackColor = true;
            this.btnGirarTambor.Click += new System.EventHandler(this.btnGirarTambor_Click);
            // 
            // gbOrdenador
            // 
            this.gbOrdenador.Controls.Add(this.lbOrDerrotas);
            this.gbOrdenador.Controls.Add(this.btnOrDisparar);
            this.gbOrdenador.Controls.Add(this.lbOrTurno);
            this.gbOrdenador.Controls.Add(this.lbOrEstado);
            this.gbOrdenador.Location = new System.Drawing.Point(46, 122);
            this.gbOrdenador.Name = "gbOrdenador";
            this.gbOrdenador.Size = new System.Drawing.Size(164, 191);
            this.gbOrdenador.TabIndex = 2;
            this.gbOrdenador.TabStop = false;
            this.gbOrdenador.Text = "ORDENADOR";
            // 
            // lbOrEstado
            // 
            this.lbOrEstado.AutoSize = true;
            this.lbOrEstado.Location = new System.Drawing.Point(7, 20);
            this.lbOrEstado.Name = "lbOrEstado";
            this.lbOrEstado.Size = new System.Drawing.Size(71, 13);
            this.lbOrEstado.TabIndex = 0;
            this.lbOrEstado.Text = "Estado: VIVO";
            // 
            // lbOrTurno
            // 
            this.lbOrTurno.AutoSize = true;
            this.lbOrTurno.Location = new System.Drawing.Point(7, 37);
            this.lbOrTurno.Name = "lbOrTurno";
            this.lbOrTurno.Size = new System.Drawing.Size(108, 13);
            this.lbOrTurno.TabIndex = 1;
            this.lbOrTurno.Text = "Turno: ESPERANDO";
            // 
            // btnOrDisparar
            // 
            this.btnOrDisparar.Enabled = false;
            this.btnOrDisparar.Location = new System.Drawing.Point(6, 95);
            this.btnOrDisparar.Name = "btnOrDisparar";
            this.btnOrDisparar.Size = new System.Drawing.Size(105, 27);
            this.btnOrDisparar.TabIndex = 2;
            this.btnOrDisparar.Text = "DISPARAR";
            this.btnOrDisparar.UseVisualStyleBackColor = true;
            this.btnOrDisparar.Click += new System.EventHandler(this.btnOrDisparar_Click);
            // 
            // lbOrDerrotas
            // 
            this.lbOrDerrotas.AutoSize = true;
            this.lbOrDerrotas.Location = new System.Drawing.Point(6, 148);
            this.lbOrDerrotas.Name = "lbOrDerrotas";
            this.lbOrDerrotas.Size = new System.Drawing.Size(79, 13);
            this.lbOrDerrotas.TabIndex = 3;
            this.lbOrDerrotas.Text = "DERROTAS: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbJrDerrotas);
            this.groupBox2.Controls.Add(this.btnJrDisparar);
            this.groupBox2.Controls.Add(this.lbJrTurno);
            this.groupBox2.Controls.Add(this.lbJrEstado);
            this.groupBox2.Location = new System.Drawing.Point(457, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JUGADOR";
            // 
            // lbJrDerrotas
            // 
            this.lbJrDerrotas.AutoSize = true;
            this.lbJrDerrotas.Location = new System.Drawing.Point(7, 148);
            this.lbJrDerrotas.Name = "lbJrDerrotas";
            this.lbJrDerrotas.Size = new System.Drawing.Size(79, 13);
            this.lbJrDerrotas.TabIndex = 3;
            this.lbJrDerrotas.Text = "DERROTAS: 0";
            // 
            // btnJrDisparar
            // 
            this.btnJrDisparar.Enabled = false;
            this.btnJrDisparar.Location = new System.Drawing.Point(10, 95);
            this.btnJrDisparar.Name = "btnJrDisparar";
            this.btnJrDisparar.Size = new System.Drawing.Size(105, 27);
            this.btnJrDisparar.TabIndex = 2;
            this.btnJrDisparar.Text = "DISPARAR";
            this.btnJrDisparar.UseVisualStyleBackColor = true;
            this.btnJrDisparar.Click += new System.EventHandler(this.btnJrDisparar_Click);
            // 
            // lbJrTurno
            // 
            this.lbJrTurno.AutoSize = true;
            this.lbJrTurno.Location = new System.Drawing.Point(7, 37);
            this.lbJrTurno.Name = "lbJrTurno";
            this.lbJrTurno.Size = new System.Drawing.Size(108, 13);
            this.lbJrTurno.TabIndex = 1;
            this.lbJrTurno.Text = "Turno: ESPERANDO";
            // 
            // lbJrEstado
            // 
            this.lbJrEstado.AutoSize = true;
            this.lbJrEstado.Location = new System.Drawing.Point(7, 20);
            this.lbJrEstado.Name = "lbJrEstado";
            this.lbJrEstado.Size = new System.Drawing.Size(71, 13);
            this.lbJrEstado.TabIndex = 0;
            this.lbJrEstado.Text = "Estado: VIVO";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOrdenador);
            this.Controls.Add(this.btnGirarTambor);
            this.Controls.Add(this.btnCargarBala);
            this.Name = "Juego";
            this.Text = "RuletaRusa";
            this.gbOrdenador.ResumeLayout(false);
            this.gbOrdenador.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarBala;
        private System.Windows.Forms.Button btnGirarTambor;
        private System.Windows.Forms.GroupBox gbOrdenador;
        private System.Windows.Forms.Label lbOrDerrotas;
        private System.Windows.Forms.Button btnOrDisparar;
        private System.Windows.Forms.Label lbOrTurno;
        private System.Windows.Forms.Label lbOrEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbJrDerrotas;
        private System.Windows.Forms.Button btnJrDisparar;
        private System.Windows.Forms.Label lbJrTurno;
        private System.Windows.Forms.Label lbJrEstado;
    }
}

