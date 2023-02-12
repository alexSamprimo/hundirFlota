using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruletaRusa
{
    public partial class Juego : Form
    {
        Revolver revolver;
        Jugador jugador;
        Jugador ordenador;
        Random random = new Random();


        public Juego()
        {
            InitializeComponent();
            revolver = new Revolver();
            jugador = new Jugador(1, "JUGADOR");
            ordenador = new Jugador(2, "ORDENADOR");

        }

        private void btnCargarBala_Click(object sender, EventArgs e)
        {
            revolver.cargarBala();
            btnGirarTambor.Enabled = true;
            btnCargarBala.Enabled = false;

            lbOrEstado.Text = "Estado: VIVO";
            lbJrEstado.Text = "Estado : VIVO";

        }

        private void btnGirarTambor_Click(object sender, EventArgs e)
        {
            revolver.girarTambor();
            btnGirarTambor.Enabled = false;

            if (random.Next(1, 3) == 1)
            {
                btnOrDisparar.Enabled = true;
                lbOrTurno.Text = "Turno: JUGANDO";
            }
            else
            {
                btnJrDisparar.Enabled = true;
                lbJrTurno.Text = "Turno: JUGANDO";
            }

        }

        private void btnJrDisparar_Click(object sender, EventArgs e)
        {
            if (jugador.disparar(revolver))
            {//ESTA VIVO
                btnOrDisparar.Enabled = true;
                btnJrDisparar.Enabled = false;
                lbOrTurno.Text = "Turno: JUGANDO";
                lbJrTurno.Text = "Turno: ESPERANDO";
            }
            else //ESTA MUERTO
            {
                lbJrEstado.Text = "Estado: MUERTO";
                lbJrDerrotas.Text = "Derrotas: " + jugador.Derrotas;
                reiniciar();
            }
        }

        private void btnOrDisparar_Click(object sender, EventArgs e)
        {
            if (ordenador.disparar(revolver))
            {//ESTA VIVO
                btnOrDisparar.Enabled = true;
                btnJrDisparar.Enabled = false;
                lbOrTurno.Text = "Turno: JUGANDO";
                lbJrTurno.Text = "Turno: ESPERANDO";
                //HAY ALGUN ERROR
            }
            else //ESTA MUERTO
            {
                lbOrEstado.Text = "Estado: MUERTO";
                lbOrDerrotas.Text = "Derrotas: " + ordenador.Derrotas;
                reiniciar();
            }
        }

        private void reiniciar()
        {
            btnCargarBala.Enabled = true;
            btnGirarTambor.Enabled = true;
            btnJrDisparar.Enabled = false;
            btnOrDisparar.Enabled = false;

            lbJrTurno.Text = "Turno: ESPERANDO";
            lbOrTurno.Text = "Turno: ESPERANDO";

            jugador.Vivo = true;
            ordenador.Vivo = true;
        }
    }
}
