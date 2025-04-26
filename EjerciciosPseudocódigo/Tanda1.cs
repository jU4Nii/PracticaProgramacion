using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Timers;

namespace EjerciciosPseudocódigo
{
    internal class Tanda1
    {
        static void Main(string[] args)
        {

            //Ejercicio1: Verificación de edad para votar

            //Console.WriteLine("Ingrese su edad:");

            //int edad = Int32.Parse(Console.ReadLine());

            //if (edad < 18) Console.WriteLine("No puedes votar");

            //else if (edad>70) Console.WriteLine("Puedes votar, pero no es obligatorio");

            //else Console.WriteLine("Puedes votar");



            //Ejercicio2: Clasificación de un número

            //Console.WriteLine("Ingrese un número:");

            //int num = Int32.Parse(Console.ReadLine());

            //if (num > 0)
            //{
            //   if (num > 100) Console.WriteLine("Número grande");

            //}
            //else if (num < 0)
            //{
            //    if (num < -100) Console.WriteLine("Número muy pequeño");

            //}
            //else Console.WriteLine("El número es 0");   



            //Ejercicio3: Cálculo de descuentos en una tienda
            //Console.WriteLine("Ingrese el monto de su compra:");

            //int monto = Int32.Parse(Console.ReadLine());

            //if (monto < 100) Console.WriteLine("No hay descuento");

            //else if (monto < 500)
            //{

            //    double descuento = monto * 0.10;

            //    Console.WriteLine("Tendras un descuento del 10%, el monto a pagar es de " + (monto - descuento) );

            //}

            //else
            //{

            //    double descuento2 = monto * 0.20;

            //    Console.WriteLine("Tendras un descuento del 20%, el monto a pagar es de " + (monto - descuento2));

            //}

            //Ejercicio 4: Imprimir los números del 1 al 10 usando un ciclo "PARA".
            //for (int i = 0; i < 11; i++)
            //{

            //    Console.WriteLine(i);

            //}

            //Ejercicio 5: Sumar los primeros 100 números naturales usando un ciclo "PARA".
            //int suma = 0;

            //for (int i = 0; i < 101; i++)
            //{

            //    suma += i;

            //}

            //Console.WriteLine("La suma de los primeros 100 números naturales es " + suma);

            ////Ejercicio 6: Pedir un número al usuario y mostrar su tabla de multiplicar del 1 al 10 con un ciclo "PARA".
            //Console.WriteLine("Ingresar un número para ver su tabla de multiplicar:");

            //int num = Int32.Parse(Console.ReadLine());

            //int multiplicacion;

            //for (int i= 1; i < 11 ; i++)
            //{

            //    multiplicacion = num * i;
            //    Console.WriteLine($"{num} x {i} = {multiplicacion}");

            //}

            //Ejercicio 7: Leer números hasta que el usuario ingrese un número negativo y mostrar la suma total de los números ingresados (usar "MIENTRAS").
            //Console.WriteLine("Ingrese números positivos, si ingresa uno negativo, se hará una suma de los positivos ingresados:");

            //int num = Int32.Parse(Console.ReadLine());

            //int suma = 0;

            //while (num > 0)
            //{

            //    suma += num;
            //    num = Int32.Parse(Console.ReadLine());



            //}

            //Console.WriteLine(suma);

            //Ejercicio 8: Pedir números al usuario hasta que ingrese un cero y contar cuántos números ingresó (usar "MIENTRAS").
            //Console.WriteLine("Ingrese la cantidad de números que desee, al ingresar  el número 0 se contará la cantidad de números ingresada:");

            //int num = Int32.Parse(Console.ReadLine());

            //int contador = 0;

            //while (num != 0)
            //{

            //    contador++;
            //    num = Int32.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Ingresaste " + contador + " números antes del 0");

            //Ejercicio 9: Generar un número aleatorio entre 1 y 100 y pedirle al usuario que lo adivine. Dar pistas de "mayor" o "menor" hasta que lo adivine (usar "MIENTRAS").
            //Random numero = new Random();
            //int numeroAleatorio = numero.Next(0, 100);

            //Console.WriteLine("Ingrese el número que usted cree es el correcto:");

            //int num = int.Parse(Console.ReadLine());    

            //while(num != numeroAleatorio)
            //{

            //    if (num < numeroAleatorio) Console.WriteLine("El número que buscas es mayor, prueba con otro");
            //    else Console.WriteLine("El número que buscas es menor, prueba con otro");

            //    num = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Felicidades, el numero a adivinar era " + numeroAleatorio);

            //Ejercicio 10: Mostrar los números impares entre 1 y 50 usando un ciclo "PARA".
            //for (int i = 1; i < 50; i += 2)
            //{

            //    Console.WriteLine(i);

            //}

            //Ejercicio 11: Pedir al usuario un número y calcular su factorial usando un ciclo "PARA".
            //Console.WriteLine("Ingrese un número para calcular su factorial:");

            //int num = Int32.Parse(Console.ReadLine());

            //int factorial = 1;

            //for (int i = 1; i <= num; i++)
            //{

            //    factorial *= i;

            //}

            //Console.WriteLine($"El factorial de {num} es {factorial}");

            //Ejercicio 12: Simular un cajero automático que permita hacer retiros mientras el saldo sea mayor a cero (usar "HACER-MIENTRAS").
            //Console.WriteLine("Ingrese su saldo");

            //int saldo = int.Parse(Console.ReadLine());

            //int retiro;

            //Console.WriteLine("Ingrese el monto a retirar");

            //retiro = int.Parse(Console.ReadLine());

            //do
            //{

            //    if (retiro <= saldo)
            //    {

            //        saldo = saldo - retiro;
            //        Console.WriteLine($"Retiro de ${retiro} realizado, ahora su saldo es de {saldo}");

            //        Console.WriteLine("¿Quieres realizar otro retiro?");

            //        string respuesta = Console.ReadLine();

            //        if (respuesta == "si")
            //        {

            //            Console.WriteLine("Ingrese el monto a retirar");

            //            retiro = int.Parse(Console.ReadLine());

            //        }
            //        else break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("No tienes saldo");
            //        Console.WriteLine("Ingrese un monto válido para retirar:");
            //        retiro = int.Parse(Console.ReadLine());
            //    }

            //} while (saldo > 0);



            //Ejercicio 13: Contar cuántos dígitos tiene un número ingresado por el usuario usando un ciclo "MIENTRAS".
            //Console.WriteLine("Ingresar un número para contar sus digitos");

            //int num = int.Parse(Console.ReadLine());

            //int division = 0;

            //while(num > 0)
            //{

            //    num = num / 10;
            //    division++;

            //}

            //Console.WriteLine("El número tiene " + division + " dígitos");



            //Ejercicios mezclando las distintas sentencias:

            //Ejercicio 1: 
            //Console.WriteLine("Ingresar las calificaciones de los estudiantes:");

            //int nota = int.Parse(Console.ReadLine());

            //int sumaNotas = 0;

            //int cantidadNotas = 0;

            //int promedio = 0;

            //while (nota > 0)
            //{
            //    sumaNotas = sumaNotas + nota;

            //    cantidadNotas++;

            //    nota = int.Parse(Console.ReadLine());

            //}

            //promedio = sumaNotas / cantidadNotas;

            //if (promedio >= 90)
            //{

            //    Console.WriteLine("Excelente " + promedio);
            //}
            //else if (promedio >= 70)
            //{
            //    if (promedio <= 89)
            //    {

            //        Console.WriteLine("Bueno " + promedio);

            //    }
            //}
            //else if (promedio >= 50)
            //{
            //    if(promedio <= 69)
            //    {

            //        Console.WriteLine("Regular " + promedio);

            //    }

            //}
            //else Console.WriteLine("Deficiente " + promedio);

            //Ejercicio 2:
            //Console.WriteLine("Indica qué operación deseas hacer: suma, resta, multiplicación o división");

            //string operacion = (Console.ReadLine());  

            //switch(operacion) {

            //    case "suma":
            //        Console.WriteLine("Ingrese el número 1");
            //        int num1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese el número 2");
            //        int num2 = int.Parse(Console.ReadLine());
            //        int suma = num1 + num2;
            //        Console.WriteLine("La suma entre los números es " + suma);
            //        break;

            //    case "resta":
            //        Console.WriteLine("Ingrese el número 1");
            //        int num3 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese el número 2");
            //        int num4 = int.Parse(Console.ReadLine());  
            //        int resta = num3 - num4;
            //        Console.WriteLine("La resta entre los números es " + resta);
            //        break;

            //    case "multiplicación":
            //        Console.WriteLine("Ingrese el número 1");
            //        int num5 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese el número 2");
            //        int num6 = int.Parse(Console.ReadLine());
            //        int multiplicacion = num5 * num6;
            //        Console.Write("La multiplicación entre ambos números es " + multiplicacion);
            //        break;

            //    case "division":
            //        Console.WriteLine("Ingrese el número 1");
            //        int num7 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese el número 2");
            //        int num8 = int.Parse(Console.ReadLine());
            //        while(num8 == 0)
            //        {
            //            Console.WriteLine("No se puede dividir por 0, ingrese otro número:");
            //            num8 = int.Parse(Console.ReadLine());

            //        }
            //        double division = num7 / num8;
            //        Console.WriteLine("La division entre los números es " + division);
            //        break;
            //    case "salir":
            //        break;
            //    default:
            //        Console.WriteLine("No ingresaste ninguna operación valida");
            //        break;

            //}

            //Ejercicio 3: 
            //Console.WriteLine("Ingrese un número hasta el cuál se mostrarán los numeros primos que hay:");

            //int limite = int.Parse(Console.ReadLine());

            //for (int i = 2; i < limite; i++)
            //{
            //    while (i >0)
            //    {
            //        if (i % i == 0)
            //        {
            //            if (i % 1 == 0)
            //            {
            //                Console.WriteLine(i);

            //            }
            //        }

            //    }



            //}

            //Ejercicio 4:
            // Console.WriteLine("Ingrese su pin");

            // string pin = (Console.ReadLine());

            // Console.WriteLine("Ingrese nuevamente el pin");

            // string pin2 = (Console.ReadLine());

            // int intentos = 3;

            // while (pin2 != pin && intentos != 0) 
            //{

            //     intentos--;
            //     Console.WriteLine($"Pin incorrecto, le quedan {intentos} intentos. Intente nuevamente:");
            //     pin2 = (Console.ReadLine());


            // }

            // if (pin2 == pin)
            // {

            //     Console.WriteLine("Has verificado correctamente el pin");

            //     Console.WriteLine("Ingrese su saldo");

            //     double saldo = double.Parse(Console.ReadLine());

            //     Console.WriteLine("Elige que operación deseas realizar: Consultar saldo, depositar, retirar o salir");

            //     string operacion = Console.ReadLine();

            //     while (operacion != "salir")
            //     {


            //         switch (operacion)
            //         {

            //             case "consultar saldo":
            //                 Console.WriteLine($"Su saldo es ${saldo}");
            //                  break;

            //             case "depositar":
            //                 Console.WriteLine("Ingrese el monto que desea depositar:");
            //                 double monto = double.Parse(Console.ReadLine());
            //                 saldo = saldo + monto;
            //                 Console.WriteLine($"El nuevo monto es {saldo}");
            //                 break;

            //             case "retirar":
            //                 Console.WriteLine("Ingrese el monto a retirar:");
            //                 double retiro = double.Parse(Console.ReadLine());
            //                 if (retiro <= saldo)
            //                 {

            //                     saldo = saldo - retiro;
            //                     Console.WriteLine($"Retiro de ${retiro} realizado, su saldo actual es ${saldo}");

            //                 }
            //                 else
            //                 {

            //                     Console.WriteLine("No tienes suficiente saldo para efectuar el retiro");

            //                 }
            //                 break;

            //             case "salir":
            //                 break;


            //         }

            //         Console.WriteLine("Elige que operación deseas realizar: Consultar saldo, depositar, retirar o salir");

            //         operacion = Console.ReadLine();

            //     }

            // }

            //Ejercicio: 
            //Console.WriteLine("Ingrese en que sistema está escrita la temperatura: farenheit o celsius ");

            //string tipoTemp = Console.ReadLine();

            //switch (tipoTemp)
            //{

            //    case "farenheit":
            //        Console.WriteLine("Elegiste farenheit, escribe la temperatura y será convertida a celsius");
            //        double faren = double.Parse(Console.ReadLine());
            //        double conversion = ((faren - 32) / 9) * 5;
            //        Console.WriteLine($"{conversion}°C");
            //        break;

            //    case "celsius":
            //        Console.WriteLine("Elegiste celsius, escribe la temperatura y será convertida a farenheit");
            //        double cels = double.Parse(Console.ReadLine());
            //        double conversioncels = (cels * 9 / 5) + 32;
            //        Console.WriteLine($"{conversioncels}°F");
            //        break;

            //    default:
            //        Console.WriteLine("No has ingresado un sistema de temperatura incluido o un termino incorrecto");
            //        break;


            //}

            //Ejercicio 6:

            //Console.WriteLine("¿Quieres calcularle el factorial a un número?");

            //String respuesta = Console.ReadLine();

            //while (respuesta != "No")
            //{

            //    switch (respuesta)
            //    {

            //        case "Si":
            //            Console.WriteLine("Ingrese un número para calcularle su factorial:");

            //            int num = int.Parse(Console.ReadLine());

            //            while (num < 0)
            //            {

            //                Console.WriteLine("Error, ingresaste un número negativo. Prueba ingresando un valor correcto mayor o igual que cero");

            //                num = int.Parse(Console.ReadLine());

            //            }

            //            int factorial = 1;


            //            for (int i = 1; i <= num; i++)
            //            {

            //                factorial = factorial * i;

            //            }

            //            Console.WriteLine($"El factorial de {num} es {factorial}");

            //            break;


            //        default:
            //            Console.WriteLine("Respuesta no válida");
            //            break;

            //    }

            //    Console.WriteLine("¿Deseas realizar otra operación?");
            //    respuesta = Console.ReadLine();

            //}

            //Console.WriteLine("Saliste del programa");

            






























        }
    }
}
