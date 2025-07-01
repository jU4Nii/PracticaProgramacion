using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Multiplicacion : IOperacion
    {

        public double Calcular(double a, double b)
        {

            double multiplicacion = a * b;

            Console.WriteLine($"La multiplicación entre {a} y {b} es {multiplicacion}");

            return multiplicacion;

        }

    }
}
