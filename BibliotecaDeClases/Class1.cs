using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    //1. Crear una clase con propiedades y un método simple. Crea la clase Persona con propiedades Nombre, Edad.
    //Agrega un método Saludar() que imprima "Hola, soy {Nombre}".
    public class Persona 
    {

        public string Nombre { get; set; }

        public int Edad {  get; set; }

        public void Saludar()
        {

            Console.WriteLine($"Hola, soy {Nombre}");

        }

    }
}
