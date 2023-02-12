using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatepokemon
{
    internal class Pokemon
    {
        //ATRIBUTOS

        private String nombre;
        private int vida;

        public Pokemon(String nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public int Vida { get => vida; set => vida = value; }
    }
}
