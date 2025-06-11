using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Camion : Vehiculo
    {
        public Camion(string Marca, float CapacidadCarga)
        {
            this.Marca = Marca;

            this.CapacidadCarga = CapacidadCarga;


        }
        public override void Conducir()
        {

            Console.WriteLine("Manejando camión ¡Tener cuidado!");

        }

        public string Marca { get; set; }

        public float CapacidadCarga { get; set; }


    }
}
