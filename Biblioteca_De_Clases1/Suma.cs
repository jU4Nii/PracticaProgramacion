using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Suma : IOperacion
    { 

        public double Calcular(double a, double b)
        {

            double suma = a + b;

            Console.WriteLine($"La suma entre {a} y {b} es {suma}");

            return suma;

        }

    }
}
