using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Ejercicio8 : Form
    {
        Random ranPiedra = new Random();
        int resultado;

        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Random ranPiedra = new Random();
           //int resultado;
           resultado = ranPiedra.Next(1, 4);
           

            switch (resultado)
            {
                case 1: MessageBox.Show("LA MAQUINA HA SACADO PIEDRA, ES UN EMPATE");
                    break;
                case 2: MessageBox.Show("LA MAQUINA HA SACADO PAPEL, PIERDES");
                    break;
                case 3: MessageBox.Show("LA MAQUINA HA SACADO TIJERAS, GANAS");
                    break;
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            resultado = ranPiedra.Next(1, 4);

            switch (resultado)
            {
                case 1:
                    MessageBox.Show("LA MAQUINA HA SACADO PIEDRA, GANAS");
                    break;
                case 2:
                    MessageBox.Show("LA MAQUINA HA SACADO PAPEL, ES UN EMPATE");
                    break;
                case 3:
                    MessageBox.Show("LA MAQUINA HA SACADO TIJERAS, PIERDES");
                    break;
            }
        }

        private void btnTijeras_Click(object sender, EventArgs e)
        {
            resultado = ranPiedra.Next(1, 4);

            switch (resultado)
            {
                case 1:
                    MessageBox.Show("LA MAQUINA HA SACADO PIEDRA, PIERDES");
                    break;
                case 2:
                    MessageBox.Show("LA MAQUINA HA SACADO PAPEL, GANAS");
                    break;
                case 3:
                    MessageBox.Show("LA MAQUINA HA SACADO TIJERAS, ES UN EMPATE");
                    break;
            }
        }
    }
}
