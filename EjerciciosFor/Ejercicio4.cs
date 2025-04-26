using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFor
{
    internal class Ejercicio4
    {
        public static void Ejecutar()
        {
            //De una lista de 8 números indicar cual es el mayor.
            //int[] arreglo = { 3, 7, 4, 6, 74, 4, 7, 20 };
            int[] arreglo = new int[8];

            int max = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Ingrese el {i+1}° número:");

                arreglo[i] = int.Parse(Console.ReadLine());

                if (arreglo[i] > max) max = arreglo[i]; 


            }
            Console.WriteLine($"El número mayor es {max}");

        }

    }
}
