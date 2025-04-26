using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio6
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar un número para ver cuántas veces esta en una lista:");

            int num = int.Parse(Console.ReadLine());

            List<int> listaNums = new List<int> {1,2,3,4,5,5,5,2,3,4,5,54,4};

            int contador = 0;

            for (int i = 0;  i < listaNums.Count; i++)
            {
                if (listaNums[i] == num)
                {

                    contador++;

                }


            }

            Console.WriteLine($"El número {num} aparece {contador} veces");

        }

    }
}
