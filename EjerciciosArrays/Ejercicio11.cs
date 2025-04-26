using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace EjerciciosArrays
{
    internal class Ejercicio11
    {

        //Pedir el nombre y 3 notas de 5 estudiantes. Mostrar el promedio de cada uno

        public static void Ejecutar()
        {

            List<List<double>> notas = new List<List<double>>(); 

            List<string> nombres = new List<string>();

            for (int i = 0; i < 5; i++)
            {

                List<double> notasTemp = new List<double>();

                Console.WriteLine($"Ingrese el nombre del alumno {i+1}:");

                string nombre = Console.ReadLine();

                while (nombre == "" ||  nombre == " " || nombre is null)
                {

                    Console.WriteLine("Nombre incorrecto, ingreselo de nuevo:");

                    nombre = Console.ReadLine();

                }

                nombres.Add(nombre);

                Console.WriteLine("A continuación, ingrese tres notas del alumno:");

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"nota {j+1}");

                    double nota = double.Parse(Console.ReadLine());   

                    notasTemp.Add(nota);

                }

                notas.Add(notasTemp);

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i]);

                double promedio = notas[i].Average();

                Console.WriteLine($"Promedio: {promedio}");
            }


        


    }

    }
}
