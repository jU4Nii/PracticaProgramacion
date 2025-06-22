using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class EmpleadoTemporal : Empleado
    {

        public EmpleadoTemporal(string Nombre, int CantHoras, float PagoxHora, int CantidadMeses) : base(Nombre,CantHoras,PagoxHora)
        {
            
            this.CantidadMeses = CantidadMeses;

        }

        public override float CalcularSueldo()
        {
            float sueldo = CantHoras * PagoxHora;

            float sueldoDurantePasantia = sueldo * CantidadMeses;

            Console.WriteLine($"El empleado temporal {Nombre} tiene un sueldo de ${sueldo}. Va a cobrar en total ${sueldoDurantePasantia} por sus {CantidadMeses} meses de contrato.");
            

            return sueldo;

        }

        public int CantidadMeses {  get; set; }

    }
}
