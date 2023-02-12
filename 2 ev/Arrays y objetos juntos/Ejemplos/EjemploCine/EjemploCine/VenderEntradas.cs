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
    public partial class VenderEntradas : Form
    {
        private Sala[] cine;

        public VenderEntradas()
        {
            InitializeComponent();
        }

        public VenderEntradas(Sala[] cine)
        {
            this.cine = cine;
            InitializeComponent();
            for (int i = 0; i < cine.Length; i++)
            {
                cbSala.Items.Add("Sala" + (i + 1));
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cine[cbSala.SelectedIndex] != null)
            {
                actualizar();
            }
            else
            {
                limpiar();
            }

        }

        private void actualizar()
        {
            lbButacasLibres.Text = "" + cine[cbSala.SelectedIndex].butacasLibres(); //las comillas es para pasarlo todo a texto
            lbPorcentaje.Text = "" + cine[cbSala.SelectedIndex].porcentajeOcupacion();
            lbingresosSala.Text = "" + cine[cbSala.SelectedIndex].ingresos();
        }

        private void limpiar()
        {
            lbButacasLibres.Text = "";
            lbPorcentaje.Text = "";
            lbingresosSala.Text = "";
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cine[cbSala.SelectedIndex].entraUno())
            {
                MessageBox.Show("Entrada vendida");
                actualizar();

            }
            else
            {
                MessageBox.Show("Sala llena");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
