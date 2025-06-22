using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public abstract class Empleado
    {

        public Empleado(string Nombre, int CantHoras, float PagoxHora)
        {
            this.Nombre = Nombre;

            this.CantHoras = CantHoras;

            this.PagoxHora = PagoxHora;

        }

        public abstract float CalcularSueldo();

        public string Nombre { get; set; }

        public int CantHoras { get; set; }

        public float PagoxHora { get; set; }

    }
}
