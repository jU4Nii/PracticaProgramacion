using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Arquero : Personaje
    {

        public Arquero(string Nombre) : base(Nombre)
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} atacó con flechas");
        }

    }
}
