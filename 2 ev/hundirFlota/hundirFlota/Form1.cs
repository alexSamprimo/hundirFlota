﻿using System;
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
    public partial class Form1 : Form
    {
        private int[,] tableroJugador = new int[8, 8]; //creamos los tableros del usuario y el pc
        private int[,] tableroPC = new int[8, 8];

        public Form1()
        {
            InitializeComponent();
            iniciarTableros();
        }

        private void iniciarTableros() //este metodo simplemente llena los tableros con 0
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tableroJugador[i, j] = 0;
                    tableroPC[i, j] = 0;
                }
            }
        }

        private void button_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int x = button.Location.X / button.Width;
            int y = button.Location.Y / button.Height;
            int numBarcos = 0;
            //esto es para comprobar si la casilla que se quiere poner el barco esta vacia

            while (numBarcos <6)//bucle para que no deje marcar mas barcos de los que son
            {
                if (x > 0 && tableroJugador[x - 1, y] == 1) //el -1 y +1 es para comprobar la casilla contigua
                {
                    return;
                }
                if (x < 7 && tableroJugador[x + 1, y] == 1)
                {
                    return;
                }
                if (y > 0 && tableroJugador[x, y - 1] == 1)
                {
                    return;
                }
                if (y < 7 && tableroJugador[x, y + 1] == 1)
                {
                    return;
                }

                tableroJugador[x, y] = 1; //si no entra en niguna comprobacion, significa que cumple el requisito de casilla y llena esa posicion con un 1
                button.BackColor = System.Drawing.Color.Blue; //pintamos la casilla de azul
                numBarcos++;

            }
        }

        private void Form1_Load(object sender, EventArgs e) //generamos el tablero al iniciar el formulario
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Width = 40;
                    button.Height = 40;
                    button.Location = new System.Drawing.Point(i * 40, j * 40); //ajustamos la posicion del boton
                    button.Click += new EventHandler(button_Click); //le asignamos la funcion al boton
                    Controls.Add(button);//añadimos a la parte grafica cada boton
                }
            }
            ponerBarcosPC();
        }

        private void ponerBarcosPC()
        {
            Random random = new Random();
            int numBarcos = 0;
            while (numBarcos < 5)
            {
                int x = random.Next(0, 8); //sacamos la posicion para intentar poner el barco
                int y = random.Next(0, 8);

                if (x > 0 && tableroPC[x - 1, y] == 1) //si la casilla que comprueba tiene un 1, vuelve a hacer el bucle sacando otros numeros
                {
                    continue;
                }
                if (x < 7 && tableroPC[x + 1, y] == 1)
                {
                    continue;
                }
                if (y > 0 && tableroPC[x, y - 1] == 1)
                {
                    continue;
                }
                if (y < 7 && tableroPC[x, y + 1] == 1)
                {
                    continue;
                }

                tableroPC[x, y] = 1; //si estas vacias las casillas contiguas, llenara esa posicion con un 1
                numBarcos++;

            }
        }
    }
}
