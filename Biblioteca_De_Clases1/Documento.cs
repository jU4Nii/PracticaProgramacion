using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Documento : IArchivo
    {

        public Documento(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Abrir()
        {

            Console.WriteLine($"Se abrió el documento {Nombre}.docx");

        }

        public void Cerrar()
        {

            Console.WriteLine($"Se cerró el documento {Nombre}.docx");

        }

        public string Nombre { get; set; }


    }
}
