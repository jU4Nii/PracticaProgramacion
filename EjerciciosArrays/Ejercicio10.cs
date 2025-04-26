using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio10
    {

        public static void Ejecutar()
        {

            List<int> lista = new List<int> { 1, 2, 3, 4, -3, -5, 4, 3 };

            for (int i = lista.Count - 1; i >=0; i--)
            {
                if (lista[i] < 0)
                {

                    lista.RemoveAt(i);

                }


            }

            foreach( int i in lista)
            {

                Console.WriteLine(i);

            }

        }

    }
}
