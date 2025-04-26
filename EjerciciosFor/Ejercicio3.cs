using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFor
{
    internal class Ejercicio3
    {
        public static void Ejecutar()
        {
            //Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado.

            Console.WriteLine("Ingrese el costo unitario y la cantidad comprada de cada producto");

            double total = 0;

            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine($"Ingrese costo unitario del producto {i}");

                double costoUnit = double.Parse( Console.ReadLine() );

                Console.WriteLine($"Ingrese la cantidad comprada del producto {i}");

                double cantComprada = double.Parse(Console.ReadLine() );

                double multiplicacion = costoUnit * cantComprada;

                total = total + multiplicacion;
            }

            Console.WriteLine($"El total adeudado es de ${total}");

        }

    }
}
