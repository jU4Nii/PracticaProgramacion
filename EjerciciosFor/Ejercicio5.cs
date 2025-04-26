using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFor
{
    internal class Ejercicio5
    {
        public static void Ejecutar()
        {
            //El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más.
            Console.WriteLine("Deberá ingresar el nombre de cliente y el total gastado");

            int[] clientes = new int[5];

            int[] totalesGastados = new int[5];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Nombre de cliente:");

                clientes[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Total gastado por {clientes[i]}");

                totalesGastados[i] = int.Parse(Console.ReadLine());


            }
        }


    }
}
