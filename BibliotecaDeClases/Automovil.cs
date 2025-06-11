using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Automovil : Vehiculo
    {

        public Automovil(string Marca, int CantPuertas)
        {
            this.Marca = Marca;

            this.CantPuertas = CantPuertas;

        }

        public override void Conducir()
        {

            Console.WriteLine("Manejando automovil");

        }

        public string Marca {  get; set; }

        public int CantPuertas {  get; set; }

    }
}
