using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase
{
    public class Persona
    {
        public Persona(string Nombre, int Edad, float Nota)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;

        }
        public string Nombre { set; get; }

        public int Edad { get; set; }

        public float Nota { set; get; }

        public float ObtenerPromedio()
        {

            return this.Nota / 2;

        }

        public void Saludar()
        {

            Console.WriteLine($"Hola, soy {Nombre}");

        }

    }
}
