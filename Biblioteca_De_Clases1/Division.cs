using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Division : IOperacion
    {

        public double Calcular(double a, double b)
        {

            double division = a / b;

            Console.WriteLine($"{a} dividido {b} es igual a {division}");

            return division;

        }

    }
}
