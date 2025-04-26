using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrePrimerParcial
{
    internal class EjercicioCollatzConjecture
    {
        public static void Ejecutar()
        {

            int pasos = 0;

            Console.WriteLine("Ingrese un número positivo:");

            int num = int.Parse(Console.ReadLine());


            if (num >= 0)
            {
                
                while (num != 1)
                    {

                        if (num % 2 == 0)
                        {
                            num = num / 2;
                            pasos++;
    
                        }
                        else
                        {
                            num = (num * 3) + 1;
                            pasos++;

                        }
                    }

            }

            Console.WriteLine($"Cantidad de pasos {pasos}");


            //if (num %2 == 0)
            //{
            //    num = num / 2;

            //    while(num != 1)
            //    {

            //        num= num / 2;
            //        pasos++;

            //    }

            //}
            //else
            //{

            //    num = (num * 3) + 1;

            //    while (num != 1)
            //    {
            //        num = (num * 3) + 1;
            //        pasos++;
            //    }

                

            //}
            //Console.WriteLine($"Cantidad de pasos{pasos}");
        }


    }
}
