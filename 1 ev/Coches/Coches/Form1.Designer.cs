namespace Coches
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPacks = new System.Windows.Forms.GroupBox();
            this.rbSport = new System.Windows.Forms.RadioButton();
            this.rbTitanium = new System.Windows.Forms.RadioButton();
            this.rbCity = new System.Windows.Forms.RadioButton();
            this.rbSinPack = new System.Windows.Forms.RadioButton();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.cbFaros = new System.Windows.Forms.CheckBox();
            this.cbAsientos = new System.Windows.Forms.CheckBox();
            this.cbLlantas = new System.Windows.Forms.CheckBox();
            this.cbClimatizador = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbPrecioSalida = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbPacks.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(35, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(225, 129);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio salida:";
            // 
            // gbPacks
            // 
            this.gbPacks.Controls.Add(this.rbSport);
            this.gbPacks.Controls.Add(this.rbTitanium);
            this.gbPacks.Controls.Add(this.rbCity);
            this.gbPacks.Controls.Add(this.rbSinPack);
            this.gbPacks.Location = new System.Drawing.Point(63, 255);
            this.gbPacks.Name = "gbPacks";
            this.gbPacks.Size = new System.Drawing.Size(205, 153);
            this.gbPacks.TabIndex = 6;
            this.gbPacks.TabStop = false;
            this.gbPacks.Text = "Packs";
            // 
            // rbSport
            // 
            this.rbSport.AutoSize = true;
            this.rbSport.Location = new System.Drawing.Point(8, 113);
            this.rbSport.Name = "rbSport";
            this.rbSport.Size = new System.Drawing.Size(89, 17);
            this.rbSport.TabIndex = 3;
            this.rbSport.TabStop = true;
            this.rbSport.Text = "Sport (5000€)";
            this.rbSport.UseVisualStyleBackColor = true;
            this.rbSport.CheckedChanged += new System.EventHandler(this.rbSport_CheckedChanged);
            // 
            // rbTitanium
            // 
            this.rbTitanium.AutoSize = true;
            this.rbTitanium.Location = new System.Drawing.Point(8, 85);
            this.rbTitanium.Name = "rbTitanium";
            this.rbTitanium.Size = new System.Drawing.Size(104, 17);
            this.rbTitanium.TabIndex = 2;
            this.rbTitanium.TabStop = true;
            this.rbTitanium.Text = "Titanium (2500€)";
            this.rbTitanium.UseVisualStyleBackColor = true;
            this.rbTitanium.CheckedChanged += new System.EventHandler(this.rbTitanium_CheckedChanged);
            // 
            // rbCity
            // 
            this.rbCity.AutoSize = true;
            this.rbCity.Location = new System.Drawing.Point(8, 53);
            this.rbCity.Name = "rbCity";
            this.rbCity.Size = new System.Drawing.Size(81, 17);
            this.rbCity.TabIndex = 1;
            this.rbCity.TabStop = true;
            this.rbCity.Text = "City (1000€)";
            this.rbCity.UseVisualStyleBackColor = true;
            this.rbCity.CheckedChanged += new System.EventHandler(this.rbCity_CheckedChanged);
            // 
            // rbSinPack
            // 
            this.rbSinPack.AutoSize = true;
            this.rbSinPack.Location = new System.Drawing.Point(8, 19);
            this.rbSinPack.Name = "rbSinPack";
            this.rbSinPack.Size = new System.Drawing.Size(68, 17);
            this.rbSinPack.TabIndex = 15;
            this.rbSinPack.TabStop = true;
            this.rbSinPack.Text = "Sin Pack";
            this.rbSinPack.UseVisualStyleBackColor = true;
            this.rbSinPack.CheckedChanged += new System.EventHandler(this.rbSinPack_CheckedChanged);
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.cbGPS);
            this.gbExtras.Controls.Add(this.cbFaros);
            this.gbExtras.Controls.Add(this.cbAsientos);
            this.gbExtras.Controls.Add(this.cbLlantas);
            this.gbExtras.Controls.Add(this.cbClimatizador);
            this.gbExtras.Location = new System.Drawing.Point(302, 255);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(200, 153);
            this.gbExtras.TabIndex = 7;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // cbGPS
            // 
            this.cbGPS.AutoSize = true;
            this.cbGPS.Location = new System.Drawing.Point(7, 113);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(135, 17);
            this.cbGPS.TabIndex = 4;
            this.cbGPS.Text = "GPS Integrado (1200€)";
            this.cbGPS.UseVisualStyleBackColor = true;
            this.cbGPS.CheckedChanged += new System.EventHandler(this.cbGPS_CheckedChanged);
            // 
            // cbFaros
            // 
            this.cbFaros.AutoSize = true;
            this.cbFaros.Location = new System.Drawing.Point(7, 91);
            this.cbFaros.Name = "cbFaros";
            this.cbFaros.Size = new System.Drawing.Size(134, 17);
            this.cbFaros.TabIndex = 3;
            this.cbFaros.Text = "Faros de Xenón (750€)";
            this.cbFaros.UseVisualStyleBackColor = true;
            this.cbFaros.CheckedChanged += new System.EventHandler(this.cbFaros_CheckedChanged);
            // 
            // cbAsientos
            // 
            this.cbAsientos.AutoSize = true;
            this.cbAsientos.Location = new System.Drawing.Point(7, 67);
            this.cbAsientos.Name = "cbAsientos";
            this.cbAsientos.Size = new System.Drawing.Size(145, 17);
            this.cbAsientos.TabIndex = 2;
            this.cbAsientos.Text = "Asientos de Cuero (750€)";
            this.cbAsientos.UseVisualStyleBackColor = true;
            this.cbAsientos.CheckedChanged += new System.EventHandler(this.cbAsientos_CheckedChanged);
            // 
            // cbLlantas
            // 
            this.cbLlantas.AutoSize = true;
            this.cbLlantas.Location = new System.Drawing.Point(7, 43);
            this.cbLlantas.Name = "cbLlantas";
            this.cbLlantas.Size = new System.Drawing.Size(137, 17);
            this.cbLlantas.TabIndex = 1;
            this.cbLlantas.Text = "Llantas Aleación (450€)";
            this.cbLlantas.UseVisualStyleBackColor = true;
            this.cbLlantas.CheckedChanged += new System.EventHandler(this.cbLlantas_CheckedChanged);
            // 
            // cbClimatizador
            // 
            this.cbClimatizador.AutoSize = true;
            this.cbClimatizador.Location = new System.Drawing.Point(7, 19);
            this.cbClimatizador.Name = "cbClimatizador";
            this.cbClimatizador.Size = new System.Drawing.Size(150, 17);
            this.cbClimatizador.TabIndex = 0;
            this.cbClimatizador.Text = "Climatizador Bizona (400€)";
            this.cbClimatizador.UseVisualStyleBackColor = true;
            this.cbClimatizador.CheckedChanged += new System.EventHandler(this.cbClimatizador_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio Final:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(621, 326);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(70, 26);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "label7";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(513, 128);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.Value = new System.DateTime(2022, 11, 11, 13, 22, 20, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lbPrecioSalida
            // 
            this.lbPrecioSalida.AutoSize = true;
            this.lbPrecioSalida.Location = new System.Drawing.Point(137, 216);
            this.lbPrecioSalida.Name = "lbPrecioSalida";
            this.lbPrecioSalida.Size = new System.Drawing.Size(35, 13);
            this.lbPrecioSalida.TabIndex = 11;
            this.lbPrecioSalida.Text = "label7";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "KA",
            "FIESTA",
            "C-MAX",
            "KUGA",
            "MUSTANG"});
            this.cbModelo.Location = new System.Drawing.Point(112, 172);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(156, 21);
            this.cbModelo.TabIndex = 14;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Location = new System.Drawing.Point(516, 34);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(156, 20);
            this.txtBoxCliente.TabIndex = 0;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(513, 71);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(159, 20);
            this.txtBoxDNI.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBoxCliente);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.lbPrecioSalida);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.gbPacks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagen);
            this.Name = "Form1";
            this.Text = "coches";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbPacks.ResumeLayout(false);
            this.gbPacks.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPacks;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbPrecioSalida;
        private System.Windows.Forms.RadioButton rbSport;
        private System.Windows.Forms.RadioButton rbTitanium;
        private System.Windows.Forms.RadioButton rbCity;
        private System.Windows.Forms.RadioButton rbSinPack;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.CheckBox cbFaros;
        private System.Windows.Forms.CheckBox cbAsientos;
        private System.Windows.Forms.CheckBox cbLlantas;
        private System.Windows.Forms.CheckBox cbClimatizador;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.TextBox txtBoxDNI;
    }
}

