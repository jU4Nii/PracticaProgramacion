using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    internal class Ejercicio1
    {
        //1- Realizar una encuesta a N usuarios que califiquen un servicio (1 al 5). Al final, mostrar el porcentaje de cada calificación.
        public static void Ejecutar()
        {

            int[] calificaciones = new int[5];

            Console.WriteLine("Ingrese la cantidad de usuarios a calificar");

            string texto = Console.ReadLine();

            int n;

            bool conversion = int.TryParse(texto, out n);

            while (conversion == false)
            {
                Console.WriteLine("Valor incorrecto, ingréselo de vuelta");

                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out n);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Usuario {i + 1}: Ingrese su calificación del servicio (1 al 5)");

                int calificacion = int.Parse(Console.ReadLine());

                if (calificacion < 6 && calificacion > 1) calificaciones[calificacion - 1]++;
                else
                {
                    Console.WriteLine("Calificación fuera de rango, deberá ingresarla de vuelta");
                    i--;
                }

               
            }

            for (int i = 0; i < calificaciones.Length; i++) 
            {
                double porcentaje = (double)calificaciones[i] / n * 100;

                Console.WriteLine($"El porcentaje de la calificación {i + 1} es {porcentaje}%");
            }

        }



    }
}
