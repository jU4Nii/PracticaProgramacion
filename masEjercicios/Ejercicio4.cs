using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio4
    {
        //4-Eliminar los valores duplicados de una lista.
        public static void Ejecutar()
        {

            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7, 8, 8, 9, 9, 9, 9, 9, };

            List<int> sinDuplicados = lista.Distinct().ToList();

            foreach (int num in sinDuplicados)
            {
                Console.WriteLine(num);
            }

        }

    }
}
