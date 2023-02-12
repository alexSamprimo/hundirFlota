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
    public partial class Configurador : Form
    {
        private Sala[] cine;

        public Configurador()
        {
            InitializeComponent();
        }

        public Configurador(Sala[] cine)
        {
            this.cine = cine;
            InitializeComponent(); //ESTO HACE QUE SE INICIE LA PARTE GRAFICA
            for (int i = 0; i < cine.Length; i++)
            {
                cbSala.Items.Add("Sala" + (i + 1)); //este bucle es para que al iniciar la ventana, el combobox tenga tantos items como casillas hay en el array

            }
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            Sala misala;

            misala = new Sala(txtPelicula.Text, (int)nudAforo.Value, (int)nudOcupadas.Value, ponerPrecio());


            int aforo, ocupadas;
            float precio;

            MessageBox.Show(misala.Pelicula + " " + misala.Aforo + " " + misala.Ocupadas + " " + misala.Precio);

            cine[cbSala.SelectedIndex] = misala; // esto es para guardar la informacion de la sala dentro del array cine

            limpiar();
        }

        private float ponerPrecio()
        {
            if (rb5.Checked)
            {
                return 5;
            }
            if (rb6.Checked)
            {
                return 6.5f;
            }
            if (rb8.Checked)
            {
                return 8;
            }
            return 0;
        }
        private void limpiar()
        {
            txtPelicula.Clear();
            nudAforo.Value = 0;
            nudOcupadas.Value = 0;

            rb5.Checked = false;
            rb6.Checked = false;
            rb8.Checked = false;
        }
    }
}
