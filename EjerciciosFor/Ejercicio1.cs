using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFor
{
    internal class Ejercicio1
    {
        public static void Ejecutar()
        {
            //El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5.
            Console.WriteLine("A continuación se le pedirá que ingrese cinco valores para sumarlos");

            int num;
            int suma = 0;

            for (int i = 1; i<= 5; i++)
            {
                Console.WriteLine($"Ingrese el valor {i}");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                

            }

            Console.WriteLine($"La suma de los numeros ingresados es {suma}");

        }

    }
}
