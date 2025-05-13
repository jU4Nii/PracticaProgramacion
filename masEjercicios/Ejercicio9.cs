using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace masEjercicios
{
    class Ejercicio9
    {
        //9- Crear un programa de consola con un menú interactivo que permita al usuario ver, agregar, eliminar y cambiar el estado(pendiente o completada)
        //de una lista de tareas, utilizando listas paralelas para almacenar las descripciones y los estados.
        public static void Ejecutar()
        {

            List<string> descripcionTareas = new List<string> { "Desayunar", "Almorzar", "Ir al gimnasio", "Estudiar", "Dormir" };

            List<string> estadoTareas = new List<string> { "Completada", "Pendiente", "Pendiente", "Pendiente", "Pendiente" };

            Console.WriteLine("Elija la opción que desee hacer con las tareas: 1. Ver, 2. Agregar, 3. Eliminar, 4. Cambiar el estado(pendiente o completada. 5. Salir");

            string accion = Console.ReadLine().ToLower();

            while (accion != "salir")
            {
                switch (accion)
                {
                    case "ver":
                        Console.WriteLine("Lista de tareas y su respectivo estado:");
                        for (int i = 0; i < descripcionTareas.Count; i++)
                        {


                            Console.WriteLine(descripcionTareas[i] + " ; " + estadoTareas[i]);

                        }
                        break;

                    case "agregar":
                        Console.WriteLine("Escriba el nombre de la tarea que desea agregar:");
                        descripcionTareas.Add(Console.ReadLine());
                        Console.WriteLine("Ingrese el estado en el que se encuentra dicha tarea:");
                        estadoTareas.Add(Console.ReadLine());
                        break;

                    case "eliminar":
                        Console.WriteLine("Ingrese el nombre de la tarea que desea eliminar:");
                        string eliminar = Console.ReadLine();
                        for (int i = 0; i < descripcionTareas.Count; i++)
                        {
                            if (descripcionTareas[i] == eliminar)
                            {
                                descripcionTareas.RemoveAt(i);
                                estadoTareas.RemoveAt(i);
                                Console.WriteLine("Tarea eliminada exitosamente");

                            }
                            
                        }
                        break;

                    case "cambiar el estado":
                        Console.WriteLine("Elija la tarea a la cual desea cambiar el estado:");
                        for (int i = 0; i < descripcionTareas.Count; i++)
                        {

                            Console.WriteLine(descripcionTareas[i] + " ; " + estadoTareas[i]);

                        }
                        string cambio = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo estado (Pendiente o completada):");
                        for (int i = 0; i < descripcionTareas.Count; i++)
                        {
                            
                            if (descripcionTareas[i] == cambio)
                            {

                                estadoTareas[i] = Console.ReadLine();

                            }
                            

                        }
                        break;

                    default:
                        Console.WriteLine("No se encontró una tarea con ese nombre.");
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Elija la opción que desee hacer con las tareas: 1. Ver, 2. Agregar, 3. Eliminar, 4. Cambiar el estado(pendiente o completada. 5. Salir");
                accion = Console.ReadLine().ToLower();

            }

        }
        

    }
}
