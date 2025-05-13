using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace EjerciciosParcialAñoPasado
{
    internal class Ejercicio1Parcial
    {

        public static void Ejecutar()
        {
            List<int> lista = new List<int>();

            Console.WriteLine("Ingresar números para filtrar los impares:");
            
            string texto = Console.ReadLine();

            int num;

            bool conversion = int.TryParse(texto, out num);

            while(conversion == false)
            {
                Console.WriteLine("Valor incorrecto, ingresar de vuelta:");

                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out num);
            }

            while (num != 0)
            {
                lista.Add(num);

                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out num);

                while (conversion == false)
                {
                    Console.WriteLine("Valor incorrecto, ingresar de vuelta:");

                    texto = Console.ReadLine();

                    conversion = int.TryParse(texto, out num);
                }
            }

            List<int> listaImpares = lista.Where(n => n % 2 != 0).OrderByDescending(x => x).ToList();

            foreach(int n in listaImpares)
            {

                Console.WriteLine(n);

            }





        }

    }
}
