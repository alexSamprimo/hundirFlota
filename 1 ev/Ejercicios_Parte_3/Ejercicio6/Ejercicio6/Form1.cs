using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Ejercicio6 : Form
    {
        
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string paloRandom, cartaRandom;
            int palo, carta;
            string paloFinal, cartaFinal;

            Random numPalo = new Random();
            Random numCarta = new Random();


            palo = numPalo.Next(1, 5);
            carta = numCarta.Next(1, 13);

            switch (palo) {
                case 1: paloFinal = "corazones";
                    break;
                case 2: paloFinal = "diamantes";
                    break;
                case 3: paloFinal = "picas";
                    break;
                case 4: paloFinal = "treboles";
                    break;
                default: paloFinal = "ERROR";
                    break;
            }
            switch (carta)
            {
                case 1:
                    cartaFinal = "as";
                    break;
                case 10:
                    cartaFinal ="sota";
                    break;
                case 11:
                    cartaFinal = "caballo";
                    break;
                case 12:
                    cartaFinal = "rey";
                    break;
                default:
                    cartaFinal = carta.ToString();
                    break;
            }
            MessageBox.Show("la carta que ha salido es el : " + cartaFinal + " de " +paloFinal);
        }

    }
}
