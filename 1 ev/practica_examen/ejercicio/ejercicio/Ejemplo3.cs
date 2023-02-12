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
    public partial class Ejemplo3 : Form
    {
        public Ejemplo3()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ofdCargarFoto.Filter = "Archivo imagen (*.jpg)|*.jpg|" + "Archivo imagen(*.png)|*.png";

            if (ofdCargarFoto.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = ofdCargarFoto.FileName; 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdGuardar.Filter = "Archivo imagen (*.jpg)|*.jpg|" + "Archivo imagen(*.png)|*.png";

            if(sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image.Save(sfdGuardar.FileName);
            }
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            MiCuadro cuadrito = new MiCuadro(); //se crea el objeto

            if(cuadrito.ShowDialog() == DialogResult.OK) //aqui recoge la contestacion de la ventana de cuadrito
            {
                MessageBox.Show("SE HA PULSADO ACEPTAR");
            }
            else
            {
                MessageBox.Show("SE HA PULSADO CANCELAR");
            }
        }
    }
}
