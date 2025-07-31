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
            Console.WriteLine("¡Bienvenido a Deporte Total!");
            Console.WriteLine("Seleccione una opción:\n1. Registrar nuevo equipo\n2. Ver equipos\n3. Jugar partido\n4. Ver tabla de posiciones\n5. Ver historial de partidos\n6. Salir");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                    Console.WriteLine("Ingrese el nombre del nuevo equipo:");
                    string nombreEquipoNuevo = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la ciudad del equipo:");
                    string ciudadEquipoNuevo = Console.ReadLine();
                    TablaDePosiciones.TablaDeEquipos.Add(new Equipo(nombreEquipoNuevo, ciudadEquipoNuevo));
                    Console.WriteLine("Se registró el equipo con éxito");
                    break;

                case "2":
                    TablaDePosiciones.VerEquipos();
                    break;

                case "3":
                    Console.WriteLine("Elija el equipo local:");
                    TablaDePosiciones.VerEquipos();
                    string inputEquipo1 = Console.ReadLine();
                    int eleccionEquipo1;
                    bool conversionEquipo1 = int.TryParse(inputEquipo1, out eleccionEquipo1);
                    while(conversionEquipo1 == false)
                    {
                        Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                        inputEquipo1 = Console.ReadLine();
                        conversionEquipo1 = int.TryParse(inputEquipo1, out  eleccionEquipo1);
                    }

                    Equipo equipo1 = TablaDePosiciones.TablaDeEquipos[eleccionEquipo1 - 1];
                    Console.WriteLine("Elija el equipo visitante:");
                    string inputEquipo2 = Console.ReadLine();
                    int eleccionEquipo2;
                    bool conversionEquipo2 = int.TryParse(inputEquipo2, out eleccionEquipo2);
                    while (conversionEquipo1 == false)
                    {
                        Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                        inputEquipo2 = Console.ReadLine();
                        conversionEquipo2 = int.TryParse(inputEquipo2, out eleccionEquipo2);
                    }

                    Equipo equipo2 = TablaDePosiciones.TablaDeEquipos[eleccionEquipo2 - 1];
                    new Partido(equipo1, equipo2);
            }




        }
    }
}
