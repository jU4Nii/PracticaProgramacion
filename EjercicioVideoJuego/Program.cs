using BibliotecaVideoJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVideoJuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bienvenido a Combate Mortal, elija una opción:");
                Console.WriteLine("1. Registrar personajes (Guerrero, Mago, Arquero).\n2. Ver lista de personajes creados.\r\n3- Iniciar un combate entre dos personajes.\n4. Ver historial de combates.\n5. Ver estadísticas globales de cada personaje.\n6. Salir.\n");
                string eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        Console.WriteLine("Elija que tipo de personaje quiere registrar:\n1. Guerrero\n2. Mago\n3. Arquero");
                        eleccion = Console.ReadLine();
                        switch (eleccion)
                        {
                            case "1":
                                Console.WriteLine("Ingrese el nombre de su guerrero:");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel:");
                                string input = Console.ReadLine();
                                int nivel;
                                bool conversion = int.TryParse(input, out nivel);
                                while ( conversion == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingresar otro:");
                                    input = Console.ReadLine();
                                    conversion = int.TryParse(input,out nivel);
                                }
                                ControlDePersonajes.ListaPersonajes.Add(new Guerrero(nombre, nivel));
                                break;

                            case "2":
                                Console.WriteLine("Ingrese el nombre de su mago:");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel:");
                                input = Console.ReadLine();
                                
                                conversion = int.TryParse(input, out nivel);
                                while (conversion == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingresar otro:");
                                    input = Console.ReadLine();
                                    conversion = int.TryParse(input, out nivel);
                                }
                                ControlDePersonajes.ListaPersonajes.Add(new Mago(nombre, nivel));
                                break;

                            case "3":
                                Console.WriteLine("Ingrese el nombre de su arquero:");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel:");
                                input = Console.ReadLine();
                                
                                conversion = int.TryParse(input, out nivel);
                                while (conversion == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingrese otro:");
                                    input = Console.ReadLine();
                                    conversion = int.TryParse(input, out nivel);
                                }
                                ControlDePersonajes.ListaPersonajes.Add(new Arquero(nombre, nivel));
                                break;

                        }
                        break;

                    case "2":
                        for (int i = 0; i < ControlDePersonajes.ListaPersonajes.Count; i++)
                        {

                            Console.WriteLine($"{i+1}. {ControlDePersonajes.ListaPersonajes[i].Tipo} {ControlDePersonajes.ListaPersonajes[i].Nombre}");

                        }
                        break;

                    case "3":
                        Console.WriteLine("Elija el primer personaje para batallar:");
                        for (int i = 0; i < ControlDePersonajes.ListaPersonajes.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {ControlDePersonajes.ListaPersonajes[i].Tipo} {ControlDePersonajes.ListaPersonajes[i].Nombre}");

                        }
                        string input1 = Console.ReadLine();
                        int eleccionPersonaje1;
                        bool conversion1 = int.TryParse(input1, out eleccionPersonaje1);
                        while(conversion1 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingrese otro:");
                            input1 = Console.ReadLine();
                            conversion1 = int.TryParse(input1, out eleccionPersonaje1);

                        }
                        Personaje personaje1 = ControlDePersonajes.ListaPersonajes[eleccionPersonaje1-1];
                        var ListaTemporalParaSegundo = ControlDePersonajes.ListaPersonajes.Where(x => x != personaje1).ToList();
                        Console.WriteLine("Elija el segundo personaje para batallar:");
                        for (int i = 0; i < ListaTemporalParaSegundo.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {ListaTemporalParaSegundo[i].Tipo} {ListaTemporalParaSegundo[i].Nombre}");

                        }
                        input1 = Console.ReadLine();
                        int eleccionPersonaje2;
                        conversion1 = int.TryParse(input1, out eleccionPersonaje2);
                        while (conversion1 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingrese otro:");
                            input1 = Console.ReadLine();
                            conversion1 = int.TryParse(input1, out eleccionPersonaje2);

                        }
                        Personaje personaje2 = ListaTemporalParaSegundo[eleccionPersonaje2-1];
                        var combate = new Combate(personaje1 , personaje2 );
                        HistorialDeCombates.ListaDeCombates.Add(combate);
                        combate.Combatir();


                        break;

                }


            }

    
        }
    }
}
