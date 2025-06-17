using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class LibroDigital : Libro
    {
        public LibroDigital(string Titulo, string Autor, int CantPags, int PesoEnMB, string Formato) : base(Titulo, Autor, CantPags)
        {
            
            this.PesoEnMB = PesoEnMB;
            this.Formato = Formato;


        }

        public void MostrarInfo()
        {

            Console.WriteLine(Titulo + " " + Autor + " " + CantPags + " " + PesoEnMB + " " + Formato);

        }

        public int PesoEnMB { get; set; }

        public string Formato { get; set; } 

    }
}
