using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio15
    {
        //Pedir números al usuario hasta que se ingresen 5 valores entre 1 y 100 válidos.
        public static void Ejecutar()
        {

            int[] valoresValidos = new int[5];

            for (int i = 0; i < valoresValidos.Length; i++)
            {
                Console.WriteLine("Ingrese un valor válido:");

                int valor = int.Parse(Console.ReadLine());

                while(valor < 1 || valor > 100)
                {

                    Console.WriteLine("Debe ingresar un valor que esté entre 1 y 100, ingréselo de vuelta:");

                    valor = int.Parse(Console.ReadLine());

                }

                valoresValidos[i] = valor;

            }

        }

    }
}
