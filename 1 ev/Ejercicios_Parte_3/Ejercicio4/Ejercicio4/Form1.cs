using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int calificación1 = 44;
            int calificación2 = 51;
            int media;
            media = (calificación1 + calificación2) / 2;
            lbText3.Text = Convert.ToString(media);
            lbText3.Visible = true;


        }
    }
}
