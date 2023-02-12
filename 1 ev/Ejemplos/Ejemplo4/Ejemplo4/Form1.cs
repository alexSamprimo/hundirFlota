using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Ejemplo4 : Form
    {
        int numerito;
        public Ejemplo4()
        {
            InitializeComponent();
        }

        private void Ejemplo4_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            // aqui pasamos el resultado del numero aleatorio a string
            numerito = aleatorio.Next(1, 11);
            lbNum.Text = numerito.ToString();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (numerito  > 0)
            {
                numerito = int.Parse(lbNum.Text) -1;
                //numerito--; es otra opcion de hacer lo mismo mas optimizado
                lbNum.Text = numerito.ToString();
            }
            else
            {
                MessageBox.Show("Deja el boton");
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (numerito < 10)
            {
                numerito = int.Parse(lbNum.Text) + 1;
            //numerito++; es otra opcion de hacer lo mismo mas optimizado
            lbNum.Text = numerito.ToString();
            }
            else
            {
                MessageBox.Show("Deja el boton");
            }
        }
    }   
}
