using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio14
    {
        //Separar los números pares e impares de una lista en dos listas diferentes.
        public static void Ejecutar()
        {

            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> listaPares = new List<int>(); 

            List<int> listaImpares = new List<int>();


            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] % 2 == 0)
                {

                    listaPares.Add(lista[i]);

                }
                else
                {

                    listaImpares.Add(lista[i]);

                }

            }

            Console.WriteLine("Lista pares");
            
            foreach (int par in listaPares)
            {

                Console.WriteLine(par);

            }

            Console.WriteLine("Lista impares");

            foreach(int impar in listaImpares)
            {

                Console.WriteLine(impar);

            }


        }

    }
}
