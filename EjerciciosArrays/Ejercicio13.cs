using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio13
    {
        //Dada una lista de palabras, encontrar las que tienen más de 5 letras.

        public static void Ejecutar()
        {

            List<string> lista = new List<string> { "gato", "auto", "pato", "perros", "tato","juanibonora" };

            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i].Length > 5)
                {

                    Console.WriteLine($"Palabra con más de 5 letras encontrada '{lista[i]}'");

                }

            }

        }

    }
}
