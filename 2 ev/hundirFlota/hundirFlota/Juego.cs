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
                    botonesPC[i, j].Click += new EventHandler(button_ClickPC);

                    this.Controls.Add(botonesPC[i, j]);
                }
            }
        }

        private void button_ClickPC(object sender, EventArgs e)
        {
            
        }

        private void button_ClickJugador(object sender, EventArgs e)
        {
            
        }
    }
}
