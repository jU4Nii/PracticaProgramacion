using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio1
    {

        public static void Ejecutar()
        {

            int[] arreglo = [12,34,45,54,23];

            int suma = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {

                suma = suma + arreglo[i];

            }

            Console.WriteLine($"La suma de los elementos del arreglo es {suma}");

        }

    }
}
