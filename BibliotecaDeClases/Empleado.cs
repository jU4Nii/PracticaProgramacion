using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    //2. Crea una clase Empleado que herede de Persona. Añade la propiedad Puesto y
    //un método Trabajar() que imprima qué hace.
    public class Empleado : Persona
    {

        public Empleado(string Nombre,int edad, string Puesto) : base(Nombre, edad)
        {

            this.Puesto = Puesto;

        }

        public string Puesto {  get; set; }

        public void Trabajar()
        {

            Console.WriteLine($"El empleado {Nombre}, de {Edad} años, trabaja de {Puesto}");

        }

    }
}
