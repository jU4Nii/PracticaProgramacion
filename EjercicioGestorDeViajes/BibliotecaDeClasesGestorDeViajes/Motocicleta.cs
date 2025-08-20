using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesGestorDeViajes
{
    public class Motocicleta : Vehiculo
    {

        public Motocicleta(string Placa, int Kilometraje) : base(Placa, Kilometraje)
        {

            Tipo = "Motocicleta";

        }

    }
}
