using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio9
    {

       public static void Ejecutar()
        {

            

            List<int> listaNum = new List<int> { 1, 2, 3, 4, 5, 5, 6, 67, 7,87, 6, 65, 67, 56, 4334, 34, 4, 342, };

            int min = listaNum[0];

            int max = 0;

            for ( int i = 0; i < listaNum.Count; i++)
            {
                if( listaNum[i] < min)
                {

                    min = listaNum[i];

                }
                
            }

            for ( int i = 0;i < listaNum.Count; i++)
            {
                if ( listaNum[i] > max)
                {

                    max = listaNum[i];

                }

            }

            Console.WriteLine($"Máximo: {max}; Mínimo {min}");



        }

    }
}
