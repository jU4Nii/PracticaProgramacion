using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParcialAñoPasado
{
    internal class Ejercicio1Recuperatorio
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar números para contar pares e impares, introduzca 0 para cortar. ");

            int contadorPares = 0;

            int contadorImpares = 0;

            string texto = Console.ReadLine();

            int num; 

            bool conversion = int.TryParse(texto, out num);

            while(conversion == false)
            {
                Console.WriteLine("Valor incorrecto, ingreselo de vuelta:");

                texto = Console.ReadLine(); 

                conversion = int.TryParse(texto, out num);

            }

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    contadorPares++;
                    Console.WriteLine("Número par ingresado");
                }
                else
                {
                    contadorImpares++;
                    Console.WriteLine("Número impar ingresado");
                }

                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out num);

                while (conversion == false)
                {
                    Console.WriteLine("Valor incorrecto, ingreselo de vuelta:");

                    texto = Console.ReadLine();

                    conversion = int.TryParse(texto, out num);

                }

            }

            Console.WriteLine($"Se detectaron {contadorPares} números pares y {contadorImpares} impares");

            
                




                


        }

    }
}
