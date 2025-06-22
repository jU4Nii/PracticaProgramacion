using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Auto : IVehiculo
    {

        public Auto(string Marca, string Modelo, int Año)
        {
            this.Marca = Marca;

            this.Año = Año;

            this.Modelo = Modelo;

        }

        public void Conducir()
        {

            Console.WriteLine($"Manejando el auto {Marca} {Modelo}");

        }

        public string Marca { get; set; }

        public int Año { get; set; }

        public string Modelo { get; set; }

    }
}
