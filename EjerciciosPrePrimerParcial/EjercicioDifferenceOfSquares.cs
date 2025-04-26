using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrePrimerParcial
{
    internal class EjercicioDifferenceOfSquares
    {

        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese un número:");

            int num = int.Parse(Console.ReadLine());

            double suma = 0;

            double cuadradoSuma = 0;

            double sumaCuadrados = 0;

            for (int i = 1; i <= num; i++)
            {

                suma = suma + i;

            }

            cuadradoSuma = Math.Pow(suma, 2);

            for (int i = 1; i <= num; i++)
            {

                sumaCuadrados = sumaCuadrados + Math.Pow(i, 2);

            }

            double diferencia = cuadradoSuma - sumaCuadrados;

            Console.WriteLine($"La diferencia entre el cuadrado de la suma y la suma de los cuadrados de los primeros {num} números naturales es {diferencia}");

        }

    }
}
