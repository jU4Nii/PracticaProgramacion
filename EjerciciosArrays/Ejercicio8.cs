using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio8
    {

        public static void Ejecutar()
        {

            int[] arreglo = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Arreglo ordenado de forma normal");

            for (int i = 0;  i < arreglo.Length; i++)
            {

                Console.WriteLine(arreglo[i]);

            }

            Console.WriteLine("Arreglo en orden inverso");

            for (int i = arreglo.Length - 1; i >= 0; i--)
            {


                Console.WriteLine(arreglo[i]);

            }

        }

    }
}
