using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Perro : Animal
    {

        public Perro(string Raza, int Edad)
        {

            this.Raza = Raza;
            this.Edad = Edad;

        }

        public override void HacerSonido()
        {

            Console.WriteLine("Guauuu");

        }

        public string Raza { get; set; }

        public int Edad { get; set; }

    }
}
