using Coches.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coches
{
    public partial class Form1 : Form
    {
        //declaro las variables globales para luego trabajar cone ellas

        int precioSalida;
        string dni, cliente;
        DateTime f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //al iniciar el programa, se mostrara la foto del logo
            pbImagen.Image = Resources.ford_logo;
            //al inicio no se mostrara el precio del coche de salida ni el resultado
            lbPrecioSalida.Visible = false;
            lbResult.Visible = false;

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui segun el modelo que se elija, se mostrara el precio inicial, y tambien se calculará el precio total, ademas de cambiar la imagen
            switch (cbModelo.Text)
            {
                case "KA":
                    pbImagen.Image = Properties.Resources.KA;
                    precioSalida = 8800;
                    lbPrecioSalida.Text = precioSalida.ToString();
                    lbPrecioSalida.Visible = true;
                    break;
                case "FIESTA":
                    pbImagen.Image = Properties.Resources.FIESTA;
                    precioSalida = 13975;
                    lbPrecioSalida.Text = precioSalida.ToString();
                    lbPrecioSalida.Visible = true;
                    break;
                case "C-MAX":
                    pbImagen.Image = Properties.Resources.B_MAX;
                    precioSalida = 18550;
                    lbPrecioSalida.Text = precioSalida.ToString();
                    lbPrecioSalida.Visible = true;
                    break;
                case "KUGA":
                    pbImagen.Image = Properties.Resources.KUGA;
                    precioSalida = 21750;
                    lbPrecioSalida.Text = precioSalida.ToString();
                    lbPrecioSalida.Visible = true;
                    break;
                case "MUSTANG":
                    pbImagen.Image = Properties.Resources.MUSTANG;
                    precioSalida = 39500;
                    lbPrecioSalida.Text = precioSalida.ToString();
                    lbPrecioSalida.Visible = true;
                    break;
                    
            }
        }



        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //comprobacion si es el black friday
            f = dtpFecha.Value;
            if (f.Day == 25 && f.Month == 11)
            {
                MessageBox.Show("Es Black Friday! Tienes un 21% de descuento");
            }
            calcular();

        }

        //aqui cada pack y extra llama a la funcion para calcular el precio
        private void rbSinPack_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void rbCity_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void rbTitanium_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void rbSport_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbClimatizador_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbLlantas_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbAsientos_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbFaros_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbGPS_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            double precioResult;
            precioResult = precioSalida;
            f = dtpFecha.Value;
            lbResult.Text = precioResult.ToString();

            //aqui hacemos las confguraciones de cada boton, lo que activa y desactiva cada uno
            if (rbSinPack.Checked)
            {
                cbClimatizador.Enabled = true;
                cbLlantas.Enabled = true;
                cbAsientos.Enabled = true;
                cbFaros.Enabled = true;
                cbGPS.Enabled = true;
            }

            if (rbCity.Checked)
            {
                cbClimatizador.Enabled = false;
                cbLlantas.Enabled = true;
                cbAsientos.Enabled = true;
                cbFaros.Enabled = true;
                cbGPS.Enabled = true;
                //aqui se esta sumando el valor extra de cada componente
                precioResult += 1000;
            }

            if (rbTitanium.Checked)
            {
                cbClimatizador.Enabled = false;
                cbLlantas.Enabled = false;
                cbAsientos.Enabled = false;
                cbFaros.Enabled = true;
                cbGPS.Enabled = true;
                precioResult += 2500;
            }

            if (rbSport.Checked)
            {
                cbClimatizador.Enabled = false;
                cbLlantas.Enabled = false;
                cbAsientos.Enabled = false;
                cbFaros.Enabled = false;
                cbGPS.Enabled = false;
                precioResult += 5000;
            }
            //se suma el valor de los extras
            if (cbClimatizador.Checked)
            {
                precioResult += 400;
            }

            if (cbLlantas.Checked)
            {
                precioResult += 450;
            }

            if (cbAsientos.Checked)
            {
                precioResult += 750;
            }

            if (cbFaros.Checked)
            {
                precioResult += 750;
            }

            if (cbGPS.Checked)
            {
                precioResult += 1200;
            }


            
            //comprobacion si es el black friday y hacer el descuento
            if (f.Day == 25 && f.Month == 11)
            {    
                precioResult = precioResult - (precioResult * 0.21);
                
            }

            lbResult.Text = precioResult.ToString();
            lbResult.Visible = true;
            //comprobacion de si no se ha rellenado el nombre o dni que salte el mensaje
            if (txtBoxCliente.Text == "" || txtBoxDNI.Text == "")
            {
                MessageBox.Show("No has rellenado los campos obligatorios!");
                lbResult.Visible = false;
            }

            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //este es el mensaje de adios donde se muestra el precio el cliente, dni y fecha
            string precio = lbResult.Text;
            cliente = txtBoxCliente.Text;
            dni = txtBoxDNI.Text;
            f = dtpFecha.Value;
            MessageBox.Show("Cliente: " + cliente + "\n" + "DNI: " + dni + "\n" + "Fecha: " + f + "\n" + "Precio: " + precio + "€");
        }
    }

}
