using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Camion : Automovil
    {
        public Camion(string Marca,int CantPuertas, float CapacidadCarga) : base(Marca, CantPuertas)
        {
            this.Marca = Marca;

            this.CapacidadCarga = CapacidadCarga;

            this.CantPuertas = CantPuertas;


        }
        public override void Conducir()
        {

            Console.WriteLine("Manejando camión ¡Tener cuidado!");

        }

        

        public float CapacidadCarga { get; set; }

        


    }
}
