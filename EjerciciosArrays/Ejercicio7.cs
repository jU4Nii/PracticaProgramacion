using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio7
    {
        //Pedir nombres al usuario y almacenarlos hasta que escriba "fin".

        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese nombres para almacenarlos en una lista, para cerrar la lista ingrese 'fin'");

            List<string> listaNombres = new List<string>();

            listaNombres.Add(Console.ReadLine());

            for (int i = 0; 0 < listaNombres.Count; i++)
            {

                string palabra = Console.ReadLine();

                if (palabra == "fin")
                {
                    break;
                }

                listaNombres.Add(palabra);

            }


        }

    }
}
