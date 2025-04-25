using System;
using System.Xml;

namespace EjercicioEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;

            double nota;

            Console.WriteLine("Ingrese el nombre del estudiante:");

            string nombre = Console.ReadLine();

            while (nombre == "")
            {

                Console.WriteLine("El nombre está vacio, ingréselo de nuevo por favor:");

                nombre = Console.ReadLine();

            }

            Console.WriteLine($"Ingrese la cantidad de calificaciones que tiene {nombre}");

            int cantidad = int.Parse( Console.ReadLine());

            while (cantidad < 1 || cantidad > 5)
            {

                Console.WriteLine("El número de calificaciones debe estar entre 1 y 5, por favor ingrese una cantidad correcta:");

                cantidad = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i <= cantidad; i++)
            {

                Console.WriteLine($"Escriba la nota {i}");

                nota = double.Parse(Console.ReadLine());

                while (nota < 1 || nota > 10)
                {

                    Console.WriteLine("La calificación ingresada no está en un rango correcto, tendrá que ingresarla de vuelta");

                    nota = double.Parse(Console.ReadLine());

                }

                suma = suma + nota;
            }

            double promedio = suma / cantidad;

            if (promedio >= 9) Console.WriteLine($"{nombre}; promedio: {promedio}; Excelente");
            else if (promedio >= 7) Console.WriteLine($"{nombre}; promedio: {promedio}; Bueno");
            else if (promedio >= 6) Console.WriteLine($"{nombre}; promedio: {promedio}; Regular");
            else Console.WriteLine($"{nombre}; promedio: {promedio}; Reprobado");
          
        }
    }
}
