using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio12
    {
        //Determinar si una lista contiene números duplicados.
        public static void Ejecutar()
        {

            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9,7, 3, 10 };

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i+1; j < lista.Count; j++)
                {

                    if (lista[i] == lista[j])
                    {

                        Console.WriteLine($"Número duplicado {lista[i]}");

                    }

                }


            }

        }

    }
}
