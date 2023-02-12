namespace Ejemplo5
{
    partial class Ejemplo5
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rdMujer = new System.Windows.Forms.RadioButton();
            this.Grupo_Sanguineo = new System.Windows.Forms.GroupBox();
            this.rdApositivo = new System.Windows.Forms.RadioButton();
            this.rdAnegativo = new System.Windows.Forms.RadioButton();
            this.rd0negativo = new System.Windows.Forms.RadioButton();
            this.groupAficiones = new System.Windows.Forms.GroupBox();
            this.chBricolaje = new System.Windows.Forms.CheckBox();
            this.chBotanica = new System.Windows.Forms.CheckBox();
            this.chSenderismo = new System.Windows.Forms.CheckBox();
            this.chElectronica = new System.Windows.Forms.CheckBox();
            this.lsEstudios = new System.Windows.Forms.ListBox();
            this.lbEstudios = new System.Windows.Forms.Label();
            this.cbSalario = new System.Windows.Forms.ComboBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.groupSexo.SuspendLayout();
            this.Grupo_Sanguineo.SuspendLayout();
            this.groupAficiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(70, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(70, 76);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 1;
            this.lbEdad.Text = "Edad";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(138, 31);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(295, 20);
            this.txtBoxNombre.TabIndex = 2;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(109, 76);
            this.nudEdad.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 3;
            this.nudEdad.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.rdMujer);
            this.groupSexo.Controls.Add(this.rbHombre);
            this.groupSexo.Location = new System.Drawing.Point(73, 122);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(161, 55);
            this.groupSexo.TabIndex = 4;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(3, 16);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rdMujer
            // 
            this.rdMujer.AutoSize = true;
            this.rdMujer.Location = new System.Drawing.Point(94, 16);
            this.rdMujer.Name = "rdMujer";
            this.rdMujer.Size = new System.Drawing.Size(51, 17);
            this.rdMujer.TabIndex = 1;
            this.rdMujer.TabStop = true;
            this.rdMujer.Text = "Mujer";
            this.rdMujer.UseVisualStyleBackColor = true;
            this.rdMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
            // 
            // Grupo_Sanguineo
            // 
            this.Grupo_Sanguineo.Controls.Add(this.rd0negativo);
            this.Grupo_Sanguineo.Controls.Add(this.rdAnegativo);
            this.Grupo_Sanguineo.Controls.Add(this.rdApositivo);
            this.Grupo_Sanguineo.Location = new System.Drawing.Point(306, 122);
            this.Grupo_Sanguineo.Name = "Grupo_Sanguineo";
            this.Grupo_Sanguineo.Size = new System.Drawing.Size(233, 55);
            this.Grupo_Sanguineo.TabIndex = 5;
            this.Grupo_Sanguineo.TabStop = false;
            this.Grupo_Sanguineo.Text = "groupSang";
            // 
            // rdApositivo
            // 
            this.rdApositivo.AutoSize = true;
            this.rdApositivo.Location = new System.Drawing.Point(6, 19);
            this.rdApositivo.Name = "rdApositivo";
            this.rdApositivo.Size = new System.Drawing.Size(38, 17);
            this.rdApositivo.TabIndex = 0;
            this.rdApositivo.TabStop = true;
            this.rdApositivo.Text = "A+";
            this.rdApositivo.UseVisualStyleBackColor = true;
            // 
            // rdAnegativo
            // 
            this.rdAnegativo.AutoSize = true;
            this.rdAnegativo.Location = new System.Drawing.Point(97, 19);
            this.rdAnegativo.Name = "rdAnegativo";
            this.rdAnegativo.Size = new System.Drawing.Size(35, 17);
            this.rdAnegativo.TabIndex = 1;
            this.rdAnegativo.TabStop = true;
            this.rdAnegativo.Text = "A-";
            this.rdAnegativo.UseVisualStyleBackColor = true;
            // 
            // rd0negativo
            // 
            this.rd0negativo.AutoSize = true;
            this.rd0negativo.Location = new System.Drawing.Point(189, 20);
            this.rd0negativo.Name = "rd0negativo";
            this.rd0negativo.Size = new System.Drawing.Size(34, 17);
            this.rd0negativo.TabIndex = 2;
            this.rd0negativo.TabStop = true;
            this.rd0negativo.Text = "0-";
            this.rd0negativo.UseVisualStyleBackColor = true;
            // 
            // groupAficiones
            // 
            this.groupAficiones.Controls.Add(this.chElectronica);
            this.groupAficiones.Controls.Add(this.chSenderismo);
            this.groupAficiones.Controls.Add(this.chBotanica);
            this.groupAficiones.Controls.Add(this.chBricolaje);
            this.groupAficiones.Location = new System.Drawing.Point(73, 192);
            this.groupAficiones.Name = "groupAficiones";
            this.groupAficiones.Size = new System.Drawing.Size(466, 57);
            this.groupAficiones.TabIndex = 6;
            this.groupAficiones.TabStop = false;
            this.groupAficiones.Text = "Aficiones";
            // 
            // chBricolaje
            // 
            this.chBricolaje.AutoSize = true;
            this.chBricolaje.Location = new System.Drawing.Point(7, 20);
            this.chBricolaje.Name = "chBricolaje";
            this.chBricolaje.Size = new System.Drawing.Size(66, 17);
            this.chBricolaje.TabIndex = 0;
            this.chBricolaje.Text = "Bricolaje";
            this.chBricolaje.UseVisualStyleBackColor = true;
            // 
            // chBotanica
            // 
            this.chBotanica.AutoSize = true;
            this.chBotanica.Location = new System.Drawing.Point(124, 20);
            this.chBotanica.Name = "chBotanica";
            this.chBotanica.Size = new System.Drawing.Size(68, 17);
            this.chBotanica.TabIndex = 1;
            this.chBotanica.Text = "Botanica";
            this.chBotanica.UseVisualStyleBackColor = true;
            // 
            // chSenderismo
            // 
            this.chSenderismo.AutoSize = true;
            this.chSenderismo.Location = new System.Drawing.Point(252, 20);
            this.chSenderismo.Name = "chSenderismo";
            this.chSenderismo.Size = new System.Drawing.Size(81, 17);
            this.chSenderismo.TabIndex = 2;
            this.chSenderismo.Text = "Senderismo";
            this.chSenderismo.UseVisualStyleBackColor = true;
            this.chSenderismo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chElectronica
            // 
            this.chElectronica.AutoSize = true;
            this.chElectronica.Location = new System.Drawing.Point(387, 20);
            this.chElectronica.Name = "chElectronica";
            this.chElectronica.Size = new System.Drawing.Size(79, 17);
            this.chElectronica.TabIndex = 3;
            this.chElectronica.Text = "Electronica";
            this.chElectronica.UseVisualStyleBackColor = true;
            // 
            // lsEstudios
            // 
            this.lsEstudios.FormattingEnabled = true;
            this.lsEstudios.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Bachiller",
            "Grado básico",
            "Grado Medio",
            "Grado superior",
            "Grado Universitario"});
            this.lsEstudios.Location = new System.Drawing.Point(76, 266);
            this.lsEstudios.Name = "lsEstudios";
            this.lsEstudios.Size = new System.Drawing.Size(168, 95);
            this.lsEstudios.TabIndex = 7;
            // 
            // lbEstudios
            // 
            this.lbEstudios.AutoSize = true;
            this.lbEstudios.Location = new System.Drawing.Point(76, 247);
            this.lbEstudios.Name = "lbEstudios";
            this.lbEstudios.Size = new System.Drawing.Size(47, 13);
            this.lbEstudios.TabIndex = 8;
            this.lbEstudios.Text = "Estudios";
            this.lbEstudios.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSalario
            // 
            this.cbSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalario.FormattingEnabled = true;
            this.cbSalario.Items.AddRange(new object[] {
            "0-60.000",
            "60.000-120.000",
            "120.000-125.000",
            "125.000-200.000"});
            this.cbSalario.Location = new System.Drawing.Point(372, 290);
            this.cbSalario.Name = "cbSalario";
            this.cbSalario.Size = new System.Drawing.Size(121, 21);
            this.cbSalario.TabIndex = 9;
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(372, 256);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(83, 13);
            this.lbSalario.TabIndex = 10;
            this.lbSalario.Text = "Salario deseado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(372, 332);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 29);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Ejemplo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.cbSalario);
            this.Controls.Add(this.lbEstudios);
            this.Controls.Add(this.lsEstudios);
            this.Controls.Add(this.groupAficiones);
            this.Controls.Add(this.Grupo_Sanguineo);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Ejemplo5";
            this.Text = "Ejemplo5";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            this.Grupo_Sanguineo.ResumeLayout(false);
            this.Grupo_Sanguineo.PerformLayout();
            this.groupAficiones.ResumeLayout(false);
            this.groupAficiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.RadioButton rdMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.GroupBox Grupo_Sanguineo;
        private System.Windows.Forms.RadioButton rd0negativo;
        private System.Windows.Forms.RadioButton rdAnegativo;
        private System.Windows.Forms.RadioButton rdApositivo;
        private System.Windows.Forms.GroupBox groupAficiones;
        private System.Windows.Forms.CheckBox chSenderismo;
        private System.Windows.Forms.CheckBox chBotanica;
        private System.Windows.Forms.CheckBox chBricolaje;
        private System.Windows.Forms.CheckBox chElectronica;
        private System.Windows.Forms.ListBox lsEstudios;
        private System.Windows.Forms.Label lbEstudios;
        private System.Windows.Forms.ComboBox cbSalario;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Button btnEnviar;
    }
}

