using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio3
    {
        //3- Verificar si un array de enteros se lee igual de izquierda a derecha que de derecha a izquierda.
        public static void Ejecutar()
        {

            int[] arreglo = new int[8] { 1, 2, 3, 4, 5, 3, 2, 1 };

            int[] arregloInvertido = new int[8];

            int posArreglo = 7;

            for (int i = 0; i < arreglo.Length; i++)
            {
                arregloInvertido[i] = arreglo[posArreglo];

                posArreglo--;
            }

            int contadorSimilitudes = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arregloInvertido[i] == arreglo[i]) contadorSimilitudes++;
            }

            if (contadorSimilitudes == arreglo.Length) Console.WriteLine("El arreglo se lee igual de izquierda a derecha y de derecha a izquierda");
            else Console.WriteLine("El arreglo no se lee igual de izquierda a derecha y de derecha a izquierda");
        }
    }
}
