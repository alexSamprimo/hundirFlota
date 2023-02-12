using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo7
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eJEMPLOSANTERIORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo1.Form1 ventana = new Ejemplo1.Form1();
            ventana.MdiParent = this;
            //esto es para que el formulario se abra dentro de la ventana y no fuera
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();

        }

        private void ejemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo2.Form1 ventana = new Ejemplo2.Form1();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void cUADROSDEDIALOGOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejemplo7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo8 ventana = new Ejemplo8();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
