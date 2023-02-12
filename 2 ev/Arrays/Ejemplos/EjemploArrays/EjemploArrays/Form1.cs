using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArrays
{
    public partial class Form1 : Form
    {

        String[] palabras = new String[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            String nombre;
            bool hayHueco = false;

            nombre = txtPalabra.Text;

            if (!nombre.Equals(""))
            {
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i] == null)
                    {
                        palabras[i] = nombre;
                        hayHueco = true;
                        actualizarLista();
                        break;
                    }
                }
                if (!hayHueco) //hayHueco == false (es lo mismo)
                {
                    MessageBox.Show("No queda hueco");
                }
            }
            else
            {
                MessageBox.Show("Tienes que escribir algo en Palabra");
            }
        }

        private void actualizarLista()
        {
            listPalabras.Items.Clear();
            foreach (String palabrita in palabras)
            {
                if(palabrita != null)
                {
                    listPalabras.Items.Add(palabrita);
                }
                else
                {
                    listPalabras.Items.Add(" ");
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String nombre = txtPalabra.Text;
            int posicion = (int)nudPosicion.Value -1;

            for (int i = palabras.Length - 1; i > posicion; i--)
            {
                palabras[i] = palabras[i - 1];
            }

            palabras[posicion] = nombre;
            actualizarLista();

        }
    }
}
