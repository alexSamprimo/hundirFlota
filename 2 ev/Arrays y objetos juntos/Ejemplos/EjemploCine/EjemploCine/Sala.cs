using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCine
{
    public class Sala
    {
        //ATRIBUTOS

        private String pelicula;
        private int aforo;
        private int ocupadas;
        private float precio;

        //CONSTRUCTORES

        public Sala()
        {

        }

        public Sala(string pelicula, int aforo, int ocupadas, float precio)
        {
            this.pelicula = pelicula;
            this.aforo = aforo;
            this.ocupadas = ocupadas;
            this.precio = precio;
        }

        //GETTERS Y SETTERS
        public string Pelicula { get => pelicula; set => pelicula = value; }
        public int Aforo { get => aforo; set => aforo = value; }
        public int Ocupadas { get => ocupadas; set => ocupadas = value; }
        public float Precio { get => precio; set => precio = value; }

        //METODOS PROPIOS

        public int butacasLibres()
        {
            return aforo - ocupadas;
        }

        public float porcentajeOcupacion()
        {
            return ocupadas * 100 / aforo;
        }

        public float ingresos()
        {
            return precio * ocupadas;
        }

        public void vaciar()
        {
            ocupadas = 0;
        }

        public bool entraUno()
        {
            if(ocupadas < aforo)
            {
                ocupadas++;
                return true;
            }
            return false;
        }

    }
}
