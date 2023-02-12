using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbGrande.Checked = true;
            chboxBacon.Checked = false;
            chboxAnchoas.Checked = false;
            chboxCebolla.Checked = false;
            chboxPimiento.Checked = false;
            MessageBox.Show("PIZZERIA ALEX");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            String ingredientes;
            double precio = 0;

            //esto para loas checkbox de los ingredientes

            if (chboxBacon.Checked == true)
            {
                precio += 1.5;
            }
            if (chboxAnchoas.Checked == true)
            {
                precio += 1.8;
            }
            if (chboxCebolla.Checked == true)
            {
                precio += 1;
            }
            if (chboxPimiento.Checked == true)
            {
                precio += 1.2;
            }

            if (chboxBacon.Checked == true)
            {
                precio += 1.5;
            }

            //ahora los radio button de los tamaños

            if (rbPequeña.Checked == true)
            {
                precio += 7;
            }

            if (rbMediana.Checked == true)
            {
                precio += 9;
            }

            if (rbGrande.Checked == true)
            {
                precio += 11;
            }

            //AHORA VAMOS A PONER EL PRECIO TOTAL EN EL TEXTBOX TOTAL

            txtBoxTotal.Text = precio.ToString();
        }
    }
}
