using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCine
{
    public partial class Principal : Form
    {
        Sala[] cine = new Sala[4];
        public Principal()
        {
            InitializeComponent();
        }

        private void cONFIGURARSALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configurador ventana = new Configurador(cine);
            ventana.Show();
            ventana.MdiParent = this;
        }

        private void vENDERENTRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenderEntradas ventana = new VenderEntradas(cine);
            ventana.Show();
            ventana.MdiParent = this;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
