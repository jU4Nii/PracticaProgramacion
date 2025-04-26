using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio2
    {
        public static void Ejecutar()
        {

            int[] calificaciones = { 8, 6, 4, 7, 8, 5, 3 };

            double suma = 0;

            double promedio = 0;

            for (int i = 0; i < calificaciones.Length; i++)
            {

                suma = suma + calificaciones[i];

            }

            promedio = suma / calificaciones.Length;

            Console.WriteLine($"El promedio de las notas es {promedio}");

        }


    }
}
