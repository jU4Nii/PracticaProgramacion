using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio6
    {
        //6- Rotar los elementos de un array una posición a la derecha.
        public static void Ejecutar()
        {

            int[] arreglo = new int[5] { 1, 2, 3, 4, 5 };

            int ultimaPos = arreglo[4];

            for (int i = arreglo.Length - 2; i >= 0; i--)
            {

                arreglo[i+1] = arreglo[i];

            }

            arreglo[0] = ultimaPos;

            foreach (int num in arreglo)
            {
                Console.WriteLine(num);
            }


            
        }
    }
}
