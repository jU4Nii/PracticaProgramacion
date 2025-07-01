using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Guerrero : Personaje
    {
        public Guerrero(string Nombre) : base(Nombre)
        {

        }
        public override void Atacar()
        {
            Console.WriteLine("Guerrero atacó con arma");
        }

    }
}
