using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class Ejemplo5 : Form
    {

        public Ejemplo5()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String nombre, edad, sexo, aficiones, estudios, salario;

            nombre = txtBoxNombre.Text;
            edad = nudEdad.Text;
            
            if (rbHombre.Checked == true)
            {
                sexo = "Hombre";
            }
            else
            {
                if (rdMujer.Checked == true)
                {
                    sexo = "Mujer";
                }
                else
                {
                    sexo = "No ha seleccionado el sexo";
                }
            }
            aficiones = "";
            if (chBricolaje.Checked==true)
            {
                aficiones = "Bricolaje";
            }

            if (chBotanica.Checked == true)
            {
                aficiones += " ,Botanica"; //aficiones = aficiones + " ,Botanica";
            }

            if (chSenderismo.Checked == true)
            {
                aficiones += " ,Senderismo";
            }
            if (chElectronica.Checked == true)
            {
                aficiones += " ,Electronica";
            }

            estudios = lsEstudios.Text;
            salario = cbSalario.Text;

            MessageBox.Show(nombre + "\n" + edad+ "\n"+sexo+"\n"+aficiones + "\n" + estudios + "\n" + salario);
            //VAMOS A REINICIAR LAS CAJAS
            txtBoxNombre.Text = "";
            nudEdad.Value = 25;
            rbHombre.Checked = false;
            rdMujer.Checked = false;
            chBotanica.Checked = false;
            chSenderismo.Checked = false;
            chElectronica.Checked = false;
            chBricolaje.Checked = false;
            lsEstudios.ClearSelected();
            cbSalario.SelectedIndex = -1; // esto es para que no marque ninguno
        
                

        }
    }
}
