using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo6
{
    public partial class Ejemplo6 : Form
    {
        Random rd = new Random();
        public Ejemplo6()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            DateTime origen;

            origen = dtpFechaOrigen.Value;

            mcFechaDestino.SetDate(origen);

            //MessageBox.Show(origen.ToString());
        }

        private void btnFechaActual_Click(object sender, EventArgs e)
        {
            dtpFechaOrigen.Value = DateTime.Today;
            mcFechaDestino.SetDate(DateTime.Now);
        }

        private void mcFechaDestino_DateChanged(object sender, DateRangeEventArgs e)
        {
            // aqui estamos recogiendo la fecha seleccionada en el calendario y guardandola en la variable
            DateTime fechaSeleccionada = mcFechaDestino.SelectionStart;
            if (fechaSeleccionada.Day == 31 && fechaSeleccionada.Month == 10)
            {
                MessageBox.Show("Spooky cabron");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int numerito;

            numerito = rd.Next(1, 13);

            switch (numerito)
            {
                case 1: pbImagen.Image = Properties.Resources.capricornio;
                    break;
                case 2: pbImagen.Image = Properties.Resources.acuario;
                    break;
                case 3: pbImagen.Image = Properties.Resources.piscis;
                    break;
                case 4: pbImagen.Image = Properties.Resources.aries;
                    break;
                case 5: pbImagen.Image = Properties.Resources.tauro;
                    break;
                case 6: pbImagen.Image = Properties.Resources.geminis;
                    break;
                case 7: pbImagen.Image = Properties.Resources.cancer;
                    break;
                case 8: pbImagen.Image = Properties.Resources.leo;
                    break;
                case 9: pbImagen.Image = Properties.Resources.virgo;
                    break;
                case 10: pbImagen.Image = Properties.Resources.libra;
                    break;
                case 11: pbImagen.Image = Properties.Resources.escorpio;
                    break;
                case 12: pbImagen.Image = Properties.Resources.sagitario;
                    break;
            }

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled; //esta seria la forma super optimizada
          /*if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else 
            {
                timer1.Enabled = true;
            }
          */
        }
    }
}
