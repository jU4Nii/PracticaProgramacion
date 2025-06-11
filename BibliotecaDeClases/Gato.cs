using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Gato : Animal
    {

        public Gato(string Color, int Edad)
        {

            this.Color = Color;
            this.Edad = Edad;


        }

        public override void HacerSonido()
        {

            Console.WriteLine("Miauuuuu");

        }

        public string Color { get; set; }
        public int Edad { get; set; }

    }
}
