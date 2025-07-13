using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Contrato : IImprimible
    {

        public Contrato(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Imprimir()
        {

            Console.WriteLine($"Se imprimió el contrato '{Nombre}'");

        }


        public string Nombre { get; set; }

    }
}
