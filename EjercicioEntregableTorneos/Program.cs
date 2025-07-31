using BibliotecaDeClasesEntregableTorneos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregableTorneos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.WriteLine("¡Bienvenido a Deporte Total!");
            Console.WriteLine("Seleccione una opción:\n1. Registrar nuevo equipo\n2. Ver equipos\n3. Jugar partido\n4. Ver tabla de posiciones\n5. Ver historial de partidos\n6. Salir");
            string eleccion = Console.ReadLine();
            Console.WriteLine("");

            while (eleccion != "6")
            {
                
                Console.Clear();

                switch (eleccion)
                {


                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del nuevo equipo:");
                        string nombreEquipoNuevo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre de la ciudad del equipo:");
                        string ciudadEquipoNuevo = Console.ReadLine();
                        TablaDePosiciones.TablaDeEquipos.Add(new Equipo(nombreEquipoNuevo, ciudadEquipoNuevo));
                        Console.WriteLine("Se registró el equipo con éxito");
                        Console.WriteLine("");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        TablaDePosiciones.VerEquipos();
                        Console.WriteLine("");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Elija el equipo local:");
                        TablaDePosiciones.VerEquipos();
                        string inputEquipo1 = Console.ReadLine();
                        int eleccionEquipo1;
                        bool conversionEquipo1 = int.TryParse(inputEquipo1, out eleccionEquipo1);
                        while (conversionEquipo1 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                            inputEquipo1 = Console.ReadLine();
                            conversionEquipo1 = int.TryParse(inputEquipo1, out eleccionEquipo1);
                        }

                        Equipo equipo1 = TablaDePosiciones.TablaDeEquipos[eleccionEquipo1 - 1];
                        Console.WriteLine("Elija el equipo visitante:");
                        var listaParaSegundo = TablaDePosiciones.TablaDeEquipos.Where(x => x != equipo1).ToList();
                        for (int i = 0; i < listaParaSegundo.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {listaParaSegundo[i].NombreEquipo}");

                        }
                        string inputEquipo2 = Console.ReadLine();
                        int eleccionEquipo2;
                        bool conversionEquipo2 = int.TryParse(inputEquipo2, out eleccionEquipo2);
                        while (conversionEquipo2 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                            inputEquipo2 = Console.ReadLine();
                            conversionEquipo2 = int.TryParse(inputEquipo2, out eleccionEquipo2);
                        }
                        Equipo equipo2 = listaParaSegundo[eleccionEquipo2 - 1];

                        Partido partido = new Partido(equipo1, equipo2);

                        Console.WriteLine("Ingrese los goles anotados por el equipo 1:");
                        string inputGolesEquipo1 = Console.ReadLine();
                        int CantGolesEquipo1;
                        bool conversionGolesEquipo1 = int.TryParse(inputGolesEquipo1, out CantGolesEquipo1);
                        while (conversionGolesEquipo1 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                            inputGolesEquipo1 = Console.ReadLine();
                            conversionGolesEquipo1 = int.TryParse(inputGolesEquipo1, out CantGolesEquipo1);
                        }

                        Console.WriteLine("Ingrese los goles anotados por el equipo 2:");
                        string inputGolesEquipo2 = Console.ReadLine();
                        int CantGolesEquipo2;
                        bool conversionGolesEquipo2 = int.TryParse(inputGolesEquipo2, out CantGolesEquipo2);
                        while (conversionGolesEquipo2 == false)
                        {
                            Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                            inputGolesEquipo2 = Console.ReadLine();
                            conversionGolesEquipo2 = int.TryParse(inputGolesEquipo2, out CantGolesEquipo2);
                        }

                        partido.RegistrarResultado(CantGolesEquipo1, CantGolesEquipo2);
                        Console.WriteLine("");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Tabla de posiciones actualizada");
                        TablaDePosiciones.MostrarTabla();
                        Console.WriteLine("");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Historial de partidos jugados:");
                        TablaDePosiciones.VerHistorialDePartidos();
                        Console.WriteLine("");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no valida");
                        break;
                }

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opción:\n1. Registrar nuevo equipo\n2. Ver equipos\n3. Jugar partido\n4. Ver tabla de posiciones\n5. Ver historial de partidos\n6. Salir");
                eleccion = Console.ReadLine();
                Console.WriteLine("");
            }
            }



        }
    }

