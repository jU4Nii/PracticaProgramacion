using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Bicicleta : IVehiculo
    {

        public Bicicleta(string Marca)
        {

            this.Marca = Marca;

        }

        public void Conducir()
        {

            Console.WriteLine($"Manejando la bicicleta {Marca}");

        }

        public string Marca { get; set; }

    }
}
