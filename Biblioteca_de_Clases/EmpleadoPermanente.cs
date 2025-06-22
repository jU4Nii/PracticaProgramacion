using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class EmpleadoPermanente : Empleado
    {

        public EmpleadoPermanente(string Nombre, int CantHoras, float PagoxHora) : base(Nombre, CantHoras, PagoxHora) 
        {
            

        }

        public override float CalcularSueldo()
        {

            float sueldo = CantHoras * PagoxHora;

            Console.WriteLine($"El empleado permanente {Nombre} tiene un sueldo de ${sueldo}");

            return sueldo;

        }

    }
}
