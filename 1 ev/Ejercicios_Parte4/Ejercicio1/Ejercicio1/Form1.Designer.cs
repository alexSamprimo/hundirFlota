namespace Ejercicio1
{
    partial class Ejercicio1
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
            this.grpBoxIngredientes = new System.Windows.Forms.GroupBox();
            this.chboxPimiento = new System.Windows.Forms.CheckBox();
            this.chboxCebolla = new System.Windows.Forms.CheckBox();
            this.chboxAnchoas = new System.Windows.Forms.CheckBox();
            this.chboxBacon = new System.Windows.Forms.CheckBox();
            this.grpBoxTamaño = new System.Windows.Forms.GroupBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMediana = new System.Windows.Forms.RadioButton();
            this.rbPequeña = new System.Windows.Forms.RadioButton();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.grpBoxIngredientes.SuspendLayout();
            this.grpBoxTamaño.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIngredientes
            // 
            this.grpBoxIngredientes.Controls.Add(this.chboxPimiento);
            this.grpBoxIngredientes.Controls.Add(this.chboxCebolla);
            this.grpBoxIngredientes.Controls.Add(this.chboxAnchoas);
            this.grpBoxIngredientes.Controls.Add(this.chboxBacon);
            this.grpBoxIngredientes.Location = new System.Drawing.Point(88, 74);
            this.grpBoxIngredientes.Name = "grpBoxIngredientes";
            this.grpBoxIngredientes.Size = new System.Drawing.Size(245, 197);
            this.grpBoxIngredientes.TabIndex = 0;
            this.grpBoxIngredientes.TabStop = false;
            this.grpBoxIngredientes.Text = "Ingredientes";
            // 
            // chboxPimiento
            // 
            this.chboxPimiento.AutoSize = true;
            this.chboxPimiento.Location = new System.Drawing.Point(20, 137);
            this.chboxPimiento.Name = "chboxPimiento";
            this.chboxPimiento.Size = new System.Drawing.Size(66, 17);
            this.chboxPimiento.TabIndex = 3;
            this.chboxPimiento.Text = "Pimiento";
            this.chboxPimiento.UseVisualStyleBackColor = true;
            // 
            // chboxCebolla
            // 
            this.chboxCebolla.AutoSize = true;
            this.chboxCebolla.Location = new System.Drawing.Point(20, 105);
            this.chboxCebolla.Name = "chboxCebolla";
            this.chboxCebolla.Size = new System.Drawing.Size(61, 17);
            this.chboxCebolla.TabIndex = 2;
            this.chboxCebolla.Text = "Cebolla";
            this.chboxCebolla.UseVisualStyleBackColor = true;
            // 
            // chboxAnchoas
            // 
            this.chboxAnchoas.AutoSize = true;
            this.chboxAnchoas.Location = new System.Drawing.Point(20, 70);
            this.chboxAnchoas.Name = "chboxAnchoas";
            this.chboxAnchoas.Size = new System.Drawing.Size(68, 17);
            this.chboxAnchoas.TabIndex = 1;
            this.chboxAnchoas.Text = "Anchoas";
            this.chboxAnchoas.UseVisualStyleBackColor = true;
            // 
            // chboxBacon
            // 
            this.chboxBacon.AutoSize = true;
            this.chboxBacon.Location = new System.Drawing.Point(20, 32);
            this.chboxBacon.Name = "chboxBacon";
            this.chboxBacon.Size = new System.Drawing.Size(57, 17);
            this.chboxBacon.TabIndex = 0;
            this.chboxBacon.Text = "Bacon";
            this.chboxBacon.UseVisualStyleBackColor = true;
            // 
            // grpBoxTamaño
            // 
            this.grpBoxTamaño.Controls.Add(this.rbGrande);
            this.grpBoxTamaño.Controls.Add(this.rbMediana);
            this.grpBoxTamaño.Controls.Add(this.rbPequeña);
            this.grpBoxTamaño.Location = new System.Drawing.Point(424, 70);
            this.grpBoxTamaño.Name = "grpBoxTamaño";
            this.grpBoxTamaño.Size = new System.Drawing.Size(237, 191);
            this.grpBoxTamaño.TabIndex = 1;
            this.grpBoxTamaño.TabStop = false;
            this.grpBoxTamaño.Text = "Tamaño";
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(23, 109);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 2;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMediana
            // 
            this.rbMediana.AutoSize = true;
            this.rbMediana.Location = new System.Drawing.Point(23, 74);
            this.rbMediana.Name = "rbMediana";
            this.rbMediana.Size = new System.Drawing.Size(66, 17);
            this.rbMediana.TabIndex = 1;
            this.rbMediana.TabStop = true;
            this.rbMediana.Text = "Mediana";
            this.rbMediana.UseVisualStyleBackColor = true;
            // 
            // rbPequeña
            // 
            this.rbPequeña.AutoSize = true;
            this.rbPequeña.Location = new System.Drawing.Point(23, 40);
            this.rbPequeña.Name = "rbPequeña";
            this.rbPequeña.Size = new System.Drawing.Size(68, 17);
            this.rbPequeña.TabIndex = 0;
            this.rbPequeña.TabStop = true;
            this.rbPequeña.Text = "Pequeña";
            this.rbPequeña.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(93, 307);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(93, 360);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(568, 20);
            this.txtBoxTotal.TabIndex = 3;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.grpBoxTamaño);
            this.Controls.Add(this.grpBoxIngredientes);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxIngredientes.ResumeLayout(false);
            this.grpBoxIngredientes.PerformLayout();
            this.grpBoxTamaño.ResumeLayout(false);
            this.grpBoxTamaño.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIngredientes;
        private System.Windows.Forms.CheckBox chboxPimiento;
        private System.Windows.Forms.CheckBox chboxCebolla;
        private System.Windows.Forms.CheckBox chboxAnchoas;
        private System.Windows.Forms.CheckBox chboxBacon;
        private System.Windows.Forms.GroupBox grpBoxTamaño;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMediana;
        private System.Windows.Forms.RadioButton rbPequeña;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtBoxTotal;
    }
}

