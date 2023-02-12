using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruletaRusa
{
    public class Jugador
    {
        //ATRIBUTOS
        private int id;
        private String name;
        private bool vivo;
        private int derrotas;


        //CONSTRUCTORES
        public Jugador(int id, string name)
        {
            this.id = id;
            this.name = name;
            vivo = true;
            derrotas = 0;
        }

        //GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Vivo { get => vivo; set => vivo = value; }
        public int Derrotas { get => derrotas; set => derrotas = value; }

        //METODOS
        public bool disparar(Revolver r)
        {
            if (r.disparar())
            {
                vivo = false;
                derrotas++;
            }
            else
            {
                r.siguienteBala();
            }
            return vivo;
        }
    }
}
