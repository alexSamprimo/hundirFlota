using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            int a, b, c;
            int clave = 246;
            int resultadoEntero;
            

            //aqui estoy pasando los valores de los campos a entero para poder operar con ellos
            a = int.Parse(nudA.Text);
            b = int.Parse(nudB.Text);
            c = int.Parse(nudC.Text);

            resultadoEntero = a * 100 + b * 10 + c;
            //MessageBox.Show(resultadoEntero.ToString());

            if (resultadoEntero == clave)
            {
                txtBoxResultado.Text = "Caja abierta";
            }

            if (resultadoEntero < clave)
            {
                txtBoxResultado.Text = "El numero secreto es mayor";
            }

            if (resultadoEntero > clave)
            {
                txtBoxResultado.Text = "El numero secreto es menor";
            }
        }
    }
}
