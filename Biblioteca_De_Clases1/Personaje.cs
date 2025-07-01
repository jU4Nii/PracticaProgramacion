using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public abstract class Personaje
    {
        public Personaje(string Nombre)
        {
            
            this.Nombre = Nombre;

        }

        public abstract void Atacar();

        public string Nombre { get; set; }

    }
}
