using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class ProbandoCosas
    {

        public static void Ejecutar()
        {

            List<int> lista = new List<int>();

            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                lista.Add(num);

                num = int.Parse(Console.ReadLine());
            }

            foreach (int n in lista)
            {
                Console.WriteLine(n);
            }

                //Console.WriteLine("Escriba un número");

                //string texto = Console.ReadLine();

                //int numero;

                //bool conversion = int.TryParse(texto, out numero);

                //while(conversion == false)
                //{
                //    Console.WriteLine("Ingresaste un string, debes ingresar un número");

                //    texto = Console.ReadLine();

                //    conversion = int.TryParse(texto, out numero);

                //}

                //Console.WriteLine($"Conversión hecha, numero ingresado: {numero}");

                //int calificacion1, calificacion2, calificacion3, calificacion4, calificacion5;

            }

    }
}
