using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnApretar_Click(object sender, EventArgs e)
        {
            lbSaludo.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lbSaludo.Visible=false;
            lbSaludo.Text = "Ahora empieza lo bueno";
        }
    }
}
