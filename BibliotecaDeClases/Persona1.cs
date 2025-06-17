using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona1
    {
        public Persona1(string Nombre, int DNI)
        {

            this.Nombre = Nombre;

            this.DNI = DNI;

        }
        public string Nombre { get; set; }

        public int DNI {  get; set; }

    }
}
