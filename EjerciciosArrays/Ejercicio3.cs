using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio3
    {

        public static void Ejecutar()
        {

            int[] arreglo = { 12, 34, 56, 34, 23, 69 };

            Console.WriteLine("Ingrese el número que quiere verificar si está en el arreglo:");

            int num = int.Parse(Console.ReadLine());

            int numAlmacenado = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {

                if (arreglo[i] == num)
                {

                    numAlmacenado = arreglo[i];

                }
            }

            if (numAlmacenado == num) Console.WriteLine("El número está en el arreglo");
            else Console.WriteLine("El número no está en el arreglo");

        }

    }
}
