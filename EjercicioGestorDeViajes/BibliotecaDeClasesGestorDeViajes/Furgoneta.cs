using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesGestorDeViajes
{
    public class Furgoneta : Vehiculo
    {
        //Furgoneta: capacidad menor que un camión.
        public Furgoneta(string Placa, int Kilometraje) : base(Placa, Kilometraje)
        {

            Tipo = "Furgoneta";

        }



    }
}
