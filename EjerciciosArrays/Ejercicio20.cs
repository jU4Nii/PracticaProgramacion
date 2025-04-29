using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio20
    {
        //Simular una votación con 3 candidatos. El usuario ingresa votos (1, 2 o 3) hasta escribir 0. Mostrar resultados.
        public static void Ejecutar()
        {

            List<int> candidato1 = new List<int>();

            List<int> candidato2 = new List<int>();

            List<int> candidato3 = new List<int>();

            Console.WriteLine("Ingrese su voto (1, 2 o 3), presione 0 para mostrar resultados");

            int voto = int.Parse(Console.ReadLine());   

            while(voto != 0)
            {

                if (voto == 1)
                {

                    candidato1.Add(voto);

                }
                else if (voto == 2)
                {

                    candidato2.Add(voto);

                }
                else if (voto == 3)
                {

                    candidato3.Add(voto);

                }
                
                voto = int.Parse((Console.ReadLine()));

            }

            Console.WriteLine($"votos candidato 1: {candidato1.Count}");

            Console.WriteLine($"votos candidato 2: {candidato2.Count}");

            Console.WriteLine($"votos candidato 3: {candidato3.Count}");


        }
    }
}
