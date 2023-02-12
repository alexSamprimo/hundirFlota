namespace Ejemplo6
{
    partial class Ejemplo6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaOrigen = new System.Windows.Forms.DateTimePicker();
            this.mcFechaDestino = new System.Windows.Forms.MonthCalendar();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnFechaActual = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Destino";
            // 
            // dtpFechaOrigen
            // 
            this.dtpFechaOrigen.Location = new System.Drawing.Point(50, 64);
            this.dtpFechaOrigen.Name = "dtpFechaOrigen";
            this.dtpFechaOrigen.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaOrigen.TabIndex = 2;
            // 
            // mcFechaDestino
            // 
            this.mcFechaDestino.Location = new System.Drawing.Point(403, 64);
            this.mcFechaDestino.Name = "mcFechaDestino";
            this.mcFechaDestino.TabIndex = 3;
            this.mcFechaDestino.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFechaDestino_DateChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(42, 125);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(208, 37);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnFechaActual
            // 
            this.btnFechaActual.Location = new System.Drawing.Point(42, 178);
            this.btnFechaActual.Name = "btnFechaActual";
            this.btnFechaActual.Size = new System.Drawing.Size(208, 48);
            this.btnFechaActual.TabIndex = 5;
            this.btnFechaActual.Text = "FECHA ACTUAL";
            this.btnFechaActual.UseVisualStyleBackColor = true;
            this.btnFechaActual.Click += new System.EventHandler(this.btnFechaActual_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::Ejemplo6.Properties.Resources.virgo;
            this.pbImagen.Location = new System.Drawing.Point(403, 238);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(192, 127);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ejemplo6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnFechaActual);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.mcFechaDestino);
            this.Controls.Add(this.dtpFechaOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejemplo6";
            this.Text = "Ejemplo6";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaOrigen;
        private System.Windows.Forms.MonthCalendar mcFechaDestino;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnFechaActual;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Timer timer1;
    }
}

