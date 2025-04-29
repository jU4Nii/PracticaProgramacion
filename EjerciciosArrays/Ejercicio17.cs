using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio17
    {
        //Determinar el valor que más se repite en una lista
        public static void Ejecutar()
        {
            int contador = 0;

            int max = 0;

            int numeroMasRepetido = 0;

            List<int> lista = new List<int> { 1, 2, 2, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 10, 10 };

            for (int i = 0; i < lista.Count; i++)
            {

                contador = 1;

                for (int j = i+1; j < lista.Count; j++)
                {

                    if (lista[i] == lista[j])
                    {

                        contador++;

                        if (contador > max)
                        {

                            max = contador;

                            numeroMasRepetido = lista[i];

                        }

                    }

                }

            }

            Console.WriteLine($"El número que más se repite es {numeroMasRepetido}");

            
        }

    }
}
