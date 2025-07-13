using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Imagen : IArchivo
    {

        public Imagen(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Abrir()
        {

            Console.WriteLine($"Se abrió la imagen {Nombre}.jpg");

        }

        public void Cerrar()
        {

            Console.WriteLine($"Se cerró la imagen {Nombre}.jpg");

        }

        public string Nombre { get; set; }

    }
}
