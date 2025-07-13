using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Video : IArchivo
    {

        public Video(string Nombre)
        {

            this.Nombre = Nombre;

        }

        public void Abrir()
        {

            Console.WriteLine($"Reproduciendo video {Nombre}.mp4");

        }

        public void Cerrar()
        {

            Console.WriteLine($"Se cerró el video {Nombre}.mp4");

        }

        public string Nombre { get; set; }

    }
}
