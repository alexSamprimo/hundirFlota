using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entregable
{
    public partial class juego : Form
    {
        //hacemos estas variables globales para trabajar con ellas

        int random1, random2, record, puntuacion, result, masResult, menosResult, randomposicion,partidas;

        public juego()
        {
            InitializeComponent();
            Random rd = new Random();
            
             //creamos los numeros aleatorios para la suma
            random1 = rd.Next(1, 10);
            random2 = rd.Next(1, 10);

            //aqui ponemos dentro de las labels los valores
            lbrandom1.Text = random1.ToString();
            lbrandom2.Text = random2.ToString();

            //esto es para que al iniciar, la puntuacion y el record sean 0 y el resultado no se vea
            lbPuntuacion.Text = "0";
            lbRecord.Text = "0";
            lbresult.Text = "";

            //aqui estoy sacando los valores de los botones, tanto la respuesta correcta como 5 mas y 5 menos
            result = random1 + random2;
            masResult = result + 5;
            menosResult = result - 5;

            //esta variable es para sacar la posicion de la respuesta correcta
            randomposicion = rd.Next(1, 4);

            //aqui se cambia la posicion de la respuesta correcta segun el numero que ha salido antes

            switch (randomposicion)
            {
                case 1:
                    btnresp1.Text = result.ToString();
                    btnresp2.Text = masResult.ToString();
                    btnresp3.Text = menosResult.ToString();
                    break;
                case 2:
                    btnresp1.Text = masResult.ToString();
                    btnresp2.Text = result.ToString();
                    btnresp3.Text = menosResult.ToString();
                    break;
                case 3:
                    btnresp1.Text = menosResult.ToString();
                    btnresp2.Text = masResult.ToString();
                    btnresp3.Text = result.ToString();
                    break;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void juego_Load(object sender, EventArgs e)
        {
            //esto es para que cada vez que arranquemos el programa, el contador de numero de partidas empiece en 1
            partidas = 1;
        }

        private void btnresp1_Click(object sender, EventArgs e)
        {
            //se abre un if para comprobar si la respuesta seleccionada es la misma que el resultado

            if (btnresp1.Text == result.ToString())
            {
                MessageBox.Show("Respuesta correcta, puedes seguir jugando");
                //el resultado de la suma aparece con su valor correcto
                lbresult.Text = result.ToString();
                //al ser respuesta correcta, la puntuacion subira un punto
                puntuacion++;
                lbPuntuacion.Text = puntuacion.ToString();

                //hacemos comprobacion para actualizar el record
                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                //desactivamos los botones para evitar posibles fallos
                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Has fallado, prueba otra vez");
                
                //este if es para que el record funcione, ya que si la puntuacion era mayor que el record anterior, se actualizará el record

                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                lbPuntuacion.Text = "0";
                puntuacion = 0;

                //desactivamos botones para que no se pueda intentar de nuevo despues de fallar
                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;

            }
        }

        private void btnresp2_Click(object sender, EventArgs e)
        {
            //es el mismo codigo que para el boton anterior
            
            if (btnresp2.Text == result.ToString())
            {
                MessageBox.Show("Respuesta correcta, puedes seguir jugando");
                
                lbresult.Text = result.ToString();
                
                puntuacion++;
                lbPuntuacion.Text = puntuacion.ToString();

                
                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                
                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Has fallado, prueba otra vez");

                

                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                lbPuntuacion.Text = "0";
                puntuacion = 0;

                
                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;

            }
        }

        private void btnresp3_Click(object sender, EventArgs e)
        {
            //mimso codigo que antes
            if (btnresp3.Text == result.ToString())
            {
                MessageBox.Show("Respuesta correcta, puedes seguir jugando");
                lbresult.Text = result.ToString();
                puntuacion++;
                lbPuntuacion.Text = puntuacion.ToString();

                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Has fallado, prueba otra vez");


                if (puntuacion > record)
                {
                    record = puntuacion;
                    lbRecord.Text = record.ToString();
                }

                lbPuntuacion.Text = "0";
                puntuacion = 0;

                btnresp1.Enabled = false;
                btnresp2.Enabled = false;
                btnresp3.Enabled = false;

            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            //al darle aqui reiniciaremos casi todo, el record se mantendrá

            //volvemos a activar los botones de respuesta
            btnresp1.Enabled = true;
            btnresp2.Enabled = true;
            btnresp3.Enabled = true;

            //incrementamos el numero de partida
            partidas++;

            //todo esto es el mismo codigo que al principio para que vuelvan a salir los numeros aleatorios
            Random rd = new Random();

            //creamos los numeros aleatorios para la suma
            random1 = rd.Next(1, 10);
            random2 = rd.Next(1, 10);

            //aqui ponemos dentro de las labels los valores
            lbrandom1.Text = random1.ToString();
            lbrandom2.Text = random2.ToString();
            
            lbresult.Text = "";

            //aqui estoy sacando los valores de los botones, tanto la respuesta correcta como 5 mas y 5 menos
            result = random1 + random2;
            masResult = result + 5;
            menosResult = result - 5;

            //esta variable es para sacar la posicion de la respuesta correcta
            randomposicion = rd.Next(1, 4);

            //aqui se cambia la posicion de la respuesta correcta segun el numero que ha salido antes

            switch (randomposicion)
            {
                case 1:
                    btnresp1.Text = result.ToString();
                    btnresp2.Text = masResult.ToString();
                    btnresp3.Text = menosResult.ToString();
                    break;
                case 2:
                    btnresp1.Text = masResult.ToString();
                    btnresp2.Text = result.ToString();
                    btnresp3.Text = menosResult.ToString();
                    break;
                case 3:
                    btnresp1.Text = menosResult.ToString();
                    btnresp2.Text = masResult.ToString();
                    btnresp3.Text = result.ToString();
                    break;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //mostramos una ventana con el record y el numero de partidas, despues se cierra la aplicacion
            MessageBox.Show("El record ha sido de: " + record + " y has jugado " + partidas + " partidas");
            Application.Exit();
        }
    }
}
