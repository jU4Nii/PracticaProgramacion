using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrePrimerParcial
{
    internal class EjercicioHamming
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese el primer adn");

            string adn1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese el primer adn");

            string adn2 = Console.ReadLine().ToUpper();

            if (adn1.Length != adn2.Length)
            {

                Console.WriteLine("Los ADN ingresados deben tener la misma longitud.");

            }
            else
            {

                int distancia = 0;

                for(int i = 0; i < adn1.Length; i++)
                {
                    if(adn1[i] != adn2[i])
                    {

                        distancia++;

                    }


                }

                Console.WriteLine($"La distancia de Hamming es: {distancia}");

            }

            Console.WriteLine("Presione enter para salir");

        }
    }
}
