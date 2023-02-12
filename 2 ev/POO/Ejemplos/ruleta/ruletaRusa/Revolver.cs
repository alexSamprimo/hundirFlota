using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruletaRusa
{
    public class Revolver
    {
        Random random = new Random();
        //ATRIBUTOS
        private int posicionBala;
        private int posicionActual;


        //CONSTRUCTORES

        public Revolver()
        {
            posicionBala = 0;
            posicionActual = 0;
        }



        //GETTERS Y SETTERS
        public int PosicionBala { get => posicionBala; set => posicionBala = value; }
        public int PosicionActual { get => posicionActual; set => posicionActual = value; }

        //METODOS

        public void cargarBala()
        {
            posicionBala = random.Next(1, 7);
        }

        public void girarTambor()
        {
            posicionActual = random.Next(1, 7);
        }

        public bool disparar()
        {
            return posicionBala == posicionActual;
        }

        public void siguienteBala()
        {
            posicionActual++;
            if(posicionActual == 7)
            {
                posicionActual = 1;
            }
        }

        public String imprimir()
        {
            return "Posicion de la bala: " + posicionBala + "\n" + "Posición Actual: " + posicionActual;
        }

    }
}
