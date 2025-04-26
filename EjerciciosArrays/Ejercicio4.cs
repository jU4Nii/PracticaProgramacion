using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio4
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar cinco números:");

            List<int> listaNumeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {

                listaNumeros.Add(int.Parse(Console.ReadLine()));

            }

            for (int i = 4; i >= 0; i--)
            {

                Console.WriteLine(listaNumeros[i]);

            }

        }        
    }
}
