using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Resta : IOperacion
    {

        public double Calcular(double a, double b)
        {

            double resta = a - b;

            Console.WriteLine($"{a} menos {b} es {resta}");

            return resta;

        }

    }
}
