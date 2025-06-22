using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Persona
    {

        public Persona(string Nombre, int Edad, Direccion Domicilio)
        {
            this.Nombre = Nombre;

            this.Edad = Edad;

            this.Domicilio = Domicilio;

        }

        public void MostrarInfo()
        {

            Console.WriteLine($"{Nombre} tiene {Edad} años");
            Console.WriteLine($"Vive en {Domicilio.Calle}, {Domicilio.Altura}");
        }

        public string Nombre { get; set; }

        public int Edad {  get; set; }

        public Direccion Domicilio { get; set; }

    }
}
