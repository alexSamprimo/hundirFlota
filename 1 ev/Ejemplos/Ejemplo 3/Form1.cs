using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //definir num1 como Entero
            //TIPOS --> ENTERO--> INT
            //REAL --> float, double
            //CARACTER --> string
            //LOGICO--> boolean

            int num1, num2, suma;
            

            // SI CONDICINO ENTONCES
            // SOLUCION A
            // SINO
            //SOLUCION B
            //FINSI

            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Tienes que rellenar con numeros");
            }
            else
            {
                num1 = int.Parse(txtNumero1.Text); //aqui estoy convirtiendo la sting a numero entero con int
                num2 = int.Parse(txtNumero2.Text);
                suma = num1 + num2;
                //txtResultado.Text = suma.ToString(); ESTO ES UNA FORMA de convertir a string
                //txtResultado.txt = Convert.ToString(suma); OTRA FORMA
                txtResultado.Text = "" + suma; //ESTO ES OTRA FORMA, aqui estamos forzando a que sea una string
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = ""; //esto es una forma de hacerlo, de limpiar campos
            txtNumero2.Clear(); //esto es otra forma de hacerlo
            txtResultado.Text=String.Empty; //otra forma de hacerlo
        }
    }
}
