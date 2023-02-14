using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hundirFlota
{
    public partial class Juego : Form
    {
        private int[,] tableroJugador;
        private int[,] tableroPC;
        private int puntuacionJugador = 0;
        private int puntuacionPC = 0;

        private Button[,] botonesJugador;
        private Button[,] botonesPC;

        int numBarcosJugador = 5;
        int numBarcosPC = 5;
        public Juego(int[,] tableroJugador, int[,] tableroPC) //pasamos los tableros de antes a este formulario para poder trabajar con ellos
        {
            InitializeComponent();
            botonesJugador = new Button[8, 8]; //inicio la matriz para luego almacenar los botones
            botonesPC = new Button[8, 8];

            this.tableroJugador = tableroJugador;
            this.tableroPC = tableroPC;

            
        }
        private void Juego_Load(object sender, EventArgs e)
        {
            crearTableroJugador(); // se crean los tableros de botones nada mas iniciarse el formulario
            crearTableroPC();
        }

        private void crearTableroJugador()//creamos el tablero de botones del jugador
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    botonesJugador[i, j] = new Button();
                    botonesJugador[i, j].Location = new Point(i * 40, j * 40);
                    botonesJugador[i, j].Size = new Size(40, 40);
                    botonesJugador[i,j].Click += new EventHandler(button_ClickJugador);
                    this.Controls.Add(botonesJugador[i, j]);
                }
            }
        }

        private void crearTableroPC()//creamos tablero de botones para el pc
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    botonesPC[i, j] = new Button();
                    botonesPC[i, j].Location = new Point(375 + i * 40, j * 40); //se ajujsta la distancia para que los tableros no se pisen
                    botonesPC[i, j].Size = new Size(40, 40);
                    botonesPC[i, j].Enabled = false;
                    botonesPC[i, j].BackColor = Color.Gray;
                    //botonesPC[i, j].Click += new EventHandler(button_ClickPC);

                    this.Controls.Add(botonesPC[i, j]);
                }
            }
        }


        private void button_ClickJugador(object sender, EventArgs e) //basicamente es el turno del jugador
        {
            
            Button button = (Button)sender;
            int x = button.Location.X / button.Width; //cojo la poiscion del boton
            int y = button.Location.Y / button.Height;

            if (tableroPC[x,y] == 1) //comprobamos si la posicion esta llena
            {
                button.BackColor = Color.Red;
                button.Enabled = false;
                numBarcosPC--;
                if (numBarcosPC == 0)
                {
                    MessageBox.Show("HAS GANADO");
                    Close();
                }
            }
            else
            {
                button.BackColor = Color.Blue;
                button.Enabled = false;
            }
            turnopc();
        }

        private void turnopc()
        {
            Random random = new Random();


            int x = random.Next(0, 8); //cogemos posicion del boton
            int y = random.Next(0, 8);

            Button button = (Button)botonesPC[x, y]; //cogemos el boton con las cordenadas
            //int tirada = tableroJugador[x, y];

            //compruebo si lo que ha salido es repetido
           /* bool repetido = false;
            for (int i = 0; i < tableroPC.Length; i++)
            {
                for (int j = 0; j < tableroPC.Length; j++)
                {
                    if(i == x && j == y)
                    {
                        repetido = true;
                        break;
                    }
                }
            } */



            if (tableroJugador[x, y] == 1) //comprobamos si el boton esta ocupado por un barco del jugador
            {
                button.BackColor = Color.Red;
                numBarcosJugador--;//quitamos un barco al jugador
                button.Enabled = false;
                if (numBarcosJugador == 0)//comprobamos si ya no quedan mas barcos del jugador
                {
                    MessageBox.Show("Gana el ordenador!");
                    Close();
                }
            }
            else
            {
                button.BackColor = Color.Blue;
            }
        }

    }
}
