using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        int farenheit;
        int celsius;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            
            //meto el valor del campo de texto en una variable de tipo string
            string boxC= txtBoxC.Text;
            //paso el campo de texto a entero, y lo meto dentro de la variable centigrados. 
            int centigrados = Convert.ToInt32(boxC);
            // incrementamos en 1 centigrados
            centigrados++;
            //Luego convierto el valor incrementado a string para mostrarlo en el campo de texto otra vez
            txtBoxC.Text = Convert.ToString(centigrados);
        }

        private void btn1f_Click(object sender, EventArgs e)
        {
            //esto hace lo mismo que el otro boton
            string boxF = txtBoxF.Text;
            farenheit = Convert.ToInt32(boxF);
            farenheit++;
            txtBoxF.Text = Convert.ToString(farenheit);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtBoxC.Enabled = false;
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            txtBoxF.Enabled = false;
        }
       
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtBoxC.Enabled= true)
            {
                celsius = int.Parse(txtBoxC.Text);
                double convF = (celsius * 1.8) + 32;
                txtBoxF.Text = (convF).ToString();
            }
            else
            {
                farenheit = int.Parse(txtBoxF.Text);
                double convC = (farenheit - 32) / 1.8;
                txtBoxC.Text = (convC).ToString();
            }
        }
    }
}
