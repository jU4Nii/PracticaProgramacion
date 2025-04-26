using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio5
    {

        public static void Ejecutar()
        {

            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arreglo.Length; i++)
            {

                if (arreglo[i] % 2 == 0) Console.WriteLine(arreglo[i]);
                
            }

        }

    }
}
