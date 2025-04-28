using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio16
    {
        //Dado un array de números, mostrar la tabla del 1 al 10 para cada uno.

        public static void Ejecutar()
        {

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int tabla = 0;

            for (int i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine($"Tabla del {i+1}");

                for (int j = 1; j <=10; j++)
                {

                    Console.WriteLine(numeros[i] * j);

                }

            }

        }

    }
}
