using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFor
{
    internal class Ejercicio2
    {

        public static void Ejecutar()
        {
            //Se necesita calcular el promedio de 8 números ingresados por el usuario.
            Console.WriteLine("A continuación se le pedirá que ingrese ocho números para calcular un promedio");

            int suma = 0;

            for (int i = 1; i <= 8; i++)
            {

                Console.WriteLine($"Ingrese el valor {i}");

                int num = int.Parse(Console.ReadLine() );

                suma = suma + num;

            }

            double promedio = suma / 8;

            Console.WriteLine($"El promedio de los ocho números ingresados es {promedio}");

        }

    }
}
