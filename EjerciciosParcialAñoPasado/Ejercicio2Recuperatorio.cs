using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParcialAñoPasado
{
    internal class Ejercicio2Recuperatorio
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar el tamaño que quiere que tenga su arreglo");

            string input = Console.ReadLine();

            int num;

            bool conversion = int.TryParse(input, out num);

            while(conversion == false)
            {
                Console.WriteLine("Valor incorrecto, ingresarlo de vuelta por favor");

                input = Console.ReadLine();

                conversion = int.TryParse(input, out num);
            }

            int[] arreglo = new int[num];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Ingrese el número en la posición {i+1}");

                input = Console.ReadLine();

                conversion = int.TryParse(input, out num);

                while(conversion == false)
                {
                    Console.WriteLine("Valor incorrecto, ingreselo de nuevo");

                    input = Console.ReadLine();

                    conversion = int.TryParse(input, out num);
                }

                arreglo[i] = num;
                
            }

            int suma = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {

                suma += arreglo[i];

            }

            float promedio = (float)suma / arreglo.Length;

            Console.WriteLine($"El promedio del arreglo es {promedio}");

        }

    }
}
