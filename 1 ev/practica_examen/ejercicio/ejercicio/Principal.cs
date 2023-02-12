using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eJEMPLO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EJEMPLO1.Form1 ventana = new EJEMPLO1.Form1();//esto crea la ventana pero no se ve
            ventana.MdiParent = this; //esto es para que la ventana aparezca dentro
            ventana.WindowState = FormWindowState.Maximized;// esto abre la ventana por defecto maximizada
            ventana.Show();//esto es para que muestre la ventana que acabamos de crear


        }

        private void eJEMPLO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EJEMPLO2.Form1 ventana = new EJEMPLO2.Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void eJEMPLO7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo3 ventana = new Ejemplo3();//creamos la ventana para el formulario dentro del pryecto
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
