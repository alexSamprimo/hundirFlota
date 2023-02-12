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

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
          /*  String box1;
            box1= txtBox1.Text;
            if (box1 == "abc123")
            { 
                MessageBox.Show("Clave correcta");
                lbText1.Text = "Hola";
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            } */
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String box1;
            box1 = txtBox1.Text;
            if (box1 == "abc123")
            {
                MessageBox.Show("Clave correcta");
                lbText1.Text = "La clave es " + box1;
                lbText1.Visible = true;
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
                
            }
        }
    }
}
