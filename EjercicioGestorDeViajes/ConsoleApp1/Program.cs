using BibliotecaDeClasesGestorDeViajes;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a nuestro sistema de viajes!\nElija una opción:\n1. Agregar un vehículo\n2. Registrar un viaje para un vehículo\n3. Mostrar información de un vehículo\n4. Mostrar todos los vehículos y estadísticas generales\n5. Salir");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {


                case "1":
                    Console.WriteLine("Elija el tipo de vehículo que quiere registrar:\n1. Camion\n2. Furgoneta\n3. Motocicleta");
                    string eleccionTipoVehiculo = Console.ReadLine();
                    switch (eleccionTipoVehiculo)
                    {

                        case "1":
                            Console.WriteLine("Ingrese la placa del camión:");
                            string Patente = Console.ReadLine();
                            int kilometraje = PedirEntero("Ingrese el kilometraje:");
                            break;

                        case "2":
                            Console.WriteLine("Ingrese la placa de la furgoneta:");
                            Patente = Console.ReadLine();
                            kilometraje = PedirEntero("Ingrese el kilometraje");
                            break;

                        case "3":
                            Console.WriteLine("Ingrese la placa de la moto:");
                            Patente = Console.ReadLine();
                            kilometraje = PedirEntero("Ingrese el kilometraje");
                            break;

                    }
                    break;

                case "2":
                    Console.WriteLine("Vehículos registrados:");
                    for(int i = 0; i < Vehiculo.ListaVehiculos.Count; i++)
                    {

                        Console.WriteLine($"{i+1}. {Vehiculo.ListaVehiculos[i]}");

                    }
                    int eleccionVehiculoARegistrarleViaje = PedirEntero("Elija el vehículo al cual necesita registrarle un viaje:");
                    Vehiculo vehiculo = Vehiculo.ListaVehiculos[eleccionVehiculoARegistrarleViaje - 1];
                    int distanciaRecorrida = PedirEntero("Ingrese la distancia recorrida en el viaje:");
                    int cargaTransportadaEnElViaje = PedirEntero("Ingrese la carga transportada en el viaje");
                    DateTime fechaDelViaje = PedirFecha("Ingrese la fecha del viaje");
                    Viaje viajeNuevo = new Viaje(distanciaRecorrida, cargaTransportadaEnElViaje, fechaDelViaje);
                    Vehiculo.ListaVehiculos[eleccionVehiculoARegistrarleViaje - 1].ListaViajes.Add(viajeNuevo);
                    break;

            }
            
          

        }

        public static int PedirEntero(string mensaje)
        {
            
            int num;
            Console.WriteLine(mensaje);
            while (int.TryParse(Console.ReadLine(), out num) == false)
            {

                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");

            }

            return num;

        }

        public static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha;
            Console.WriteLine(mensaje);
            string input = Console.ReadLine();

            while (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out fecha) == false)
            {
                Console.WriteLine("Fecha inválida, ingrese nuevamente (dd/MM/yyyy):");
                input = Console.ReadLine();
            }

            return fecha;
        }

        //Se usa: DateTime fechaViaje = PedirFecha("Ingrese la fecha del viaje (dd/MM/yyyy):");
        //Console.WriteLine("Fecha ingresada: " + fechaViaje.ToShortDateString());

    }
}
