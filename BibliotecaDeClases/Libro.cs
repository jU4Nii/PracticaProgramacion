using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Libro
    {
        public Libro(string Titulo, string Autor, int CantPags)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.CantPags = CantPags;
        }

        public string Titulo {  get; set; }

        public string Autor {  get; set; }

        public int CantPags { get; set; }

    }
}
