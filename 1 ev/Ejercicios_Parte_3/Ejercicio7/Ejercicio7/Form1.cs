using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Ejercicio7 : Form
    {
        String resultado = "";

        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            resultado = resultado + "1";

            if (resultado == "321") {
                MessageBox.Show("ENHORABUENA CRACK");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            resultado = resultado + "2";

            if (resultado == "321")
            {
                MessageBox.Show("ENHORABUENA CRACK");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Enabled = false;
            resultado = resultado + "3";

            if (resultado == "321")
            {
                MessageBox.Show("ENHORABUENA CRACK");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            resultado = "";
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {

        }
    }
}
