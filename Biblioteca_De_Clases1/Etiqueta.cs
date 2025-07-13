using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Etiqueta : IImprimible
    {

        public Etiqueta(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Imprimir()
        {

            Console.WriteLine($"Se imprimió la etiqueta '{Nombre}'");

        }


        public string Nombre { get; set; }

    }
}
