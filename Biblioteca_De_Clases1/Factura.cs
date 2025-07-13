using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Factura : IImprimible
    {

        public Factura(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Imprimir()
        {

            Console.WriteLine($"Se imprimió la factura '{Nombre}'");

        }


        public string Nombre { get; set; }

    }
}
