namespace EjemploArrays
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.nudPosicion = new System.Windows.Forms.NumericUpDown();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listPalabras = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(32, 52);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra.TabIndex = 2;
            // 
            // nudPosicion
            // 
            this.nudPosicion.Location = new System.Drawing.Point(35, 148);
            this.nudPosicion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPosicion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPosicion.Name = "nudPosicion";
            this.nudPosicion.Size = new System.Drawing.Size(120, 20);
            this.nudPosicion.TabIndex = 3;
            this.nudPosicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(223, 39);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(157, 20);
            this.btnAnyadir.TabIndex = 4;
            this.btnAnyadir.Text = "AÑADIR AL FINAL";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(223, 81);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(157, 25);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "INSERTAR POSICIÓN";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(223, 124);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(157, 20);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "BORRAR POSICIÓN";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // listPalabras
            // 
            this.listPalabras.FormattingEnabled = true;
            this.listPalabras.Location = new System.Drawing.Point(457, 37);
            this.listPalabras.Name = "listPalabras";
            this.listPalabras.Size = new System.Drawing.Size(175, 238);
            this.listPalabras.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPalabras);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.nudPosicion);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPosicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.NumericUpDown nudPosicion;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listPalabras;
    }
}

