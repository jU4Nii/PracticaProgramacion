using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio2
    {
        //2- Registrar alumnos en 3 cursos(A, B, C), y luego listar cuántos hay en cada un
        public static void Ejecutar()
        {

            int[] conteoAlumnos = new int[3];

            Console.WriteLine("Ingrese la cantidad de alumnos que quiere registrar");

            string texto = Console.ReadLine();

            int n;

            bool conversion = int.TryParse(texto, out n);

            while (conversion == false)
            {
                Console.WriteLine("Valor incorrecto, ingréselo de nuevo:");

                texto = Console.ReadLine();

                conversion = int.TryParse(texto, out n);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Alumno {i + 1}, Curso:");

                string curso = Console.ReadLine().ToLower();

                if (curso == "a") conteoAlumnos[0]++;
                else if (curso == "b") conteoAlumnos[1]++;
                else if (curso == "c") conteoAlumnos[2]++;
                else
                {
                    Console.WriteLine("Ese curso no existe, ingréselo de vuelta:");
                    i--;
                }
            }

            Console.WriteLine("Cantidad de alumnos por curso");

            char letraCurso = 'a';

            for (int i = 0; i < conteoAlumnos.Length; i++)
            {
                Console.WriteLine($"Curso {letraCurso}: {conteoAlumnos[i]} alumnos");
                letraCurso++;
            }

        }
    }
}
