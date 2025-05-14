using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParcialAñoPasado
{
    internal class Ejercicio2Parcial
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese el tamaño que desea que tenga el arreglo");

            string texto = Console.ReadLine();

            int num;

            bool conversion = int.TryParse(texto, out num);

            while(conversion == false || num <= 0)
            {
                Console.WriteLine("Valor incorrecto, pruebe de vuelta:");
                
                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out num);
            }

            float[] arreglo = new float [num];

            for ( int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Ingrese el elemento N°{i+1}");

                string texto2 = Console.ReadLine();

                float numArreglo;

                bool conversion2 = float.TryParse(texto2, out numArreglo);

                while (conversion2 == false)
                {
                    Console.WriteLine("Valor incorrecto, pruebe de vuelta:");

                    texto2 = Console.ReadLine();

                    conversion2 = float.TryParse(texto2, out numArreglo);
                }

                arreglo[i] = numArreglo;
            }

            float valorResultante = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {

                if (i % 2 == 0) valorResultante += arreglo[i];
                else valorResultante -= (arreglo[i] * 3 - 1);
                

            }


            Console.WriteLine($"El valor resultante es {valorResultante}");

        }

    }
}
