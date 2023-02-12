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
    public partial class Ejemplo8 : Form
    {
        public Ejemplo8()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ofdCargarFoto.Filter = "Archivo Imagen (*.jpg)|*.jpg|" + "Archivo imagen(*.png)|*.png";

            if(ofdCargarFoto.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = ofdCargarFoto.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdGuardar.Filter = "Archivo Imagen (*.jpg)|*.jpg|" + "Archivo imagen(*.png)|*.png";

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image.Save(sfdGuardar.FileName);
            }
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            MiCuadro cuadrito = new MiCuadro();

            if(cuadrito.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("han elegido aceptar");
            }
            else
            {
                MessageBox.Show("Han elegido cancelar");
            }
        }
    }
}
