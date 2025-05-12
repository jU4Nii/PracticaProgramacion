using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio5
    {
        //5-Ordenar una lista de enteros usando el algoritmo de burbuja.
        public static void Ejecutar()
        {

            List<int> lista = new List<int> { 5, 7, 3, 4, 5, 2, 8, 3, 9, 3 };

            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - 1 - i; j++)
                {

                    if (lista[j] > lista[j + 1])
                    {
                        int burbuja = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = burbuja;
                    }

                }

            }



            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }


        }



    }
}
