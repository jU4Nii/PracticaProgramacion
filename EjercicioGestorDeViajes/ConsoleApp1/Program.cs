using BibliotecaDeClasesGestorDeViajes;
using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eleccion = IngresarString("¡Bienvenido a nuestro sistema de viajes!\nElija una opción:\n1. Agregar un vehículo\n2. Registrar un viaje para un vehículo\n3. Mostrar información de un vehículo\n4. Mostrar todos los vehículos y estadísticas generales\n5. Salir");

            while (eleccion != "5")
            {

                Console.Clear();

                switch (eleccion)
                {


                    case "1":
                        
                        string eleccionTipoVehiculo = IngresarString("Elija el tipo de vehículo que quiere registrar:\n1. Camion\n2. Furgoneta\n3. Motocicleta");
                        while(eleccionTipoVehiculo != "1" && eleccionTipoVehiculo != "2" && eleccionTipoVehiculo != "3")
                        {


                            eleccionTipoVehiculo = IngresarString("Ese tipo de vehículo no existe, pruebe con los mencionados:\n1. Camion\n2. Furgoneta\n3. Motocicleta");

                        }
                        switch (eleccionTipoVehiculo)
                        {

                            case "1":
                                string Patente = IngresarString("Ingrese la placa del camión:");
                                int kilometraje = PedirEntero("Ingrese el kilometraje:");
                                int carga = PedirEntero("Ingrese la capacidad de carga adicional que tiene el camión:");
                                Camion camion = new Camion(Patente, kilometraje, carga);
                                Vehiculo.ListaVehiculos.Add(camion);
                                break;

                            case "2":
                                Patente = IngresarString("Ingrese la placa de la furgoneta:");
                                kilometraje = PedirEntero("Ingrese el kilometraje");
                                carga = PedirEntero("Ingrese la capacidad de carga adicional que tiene la furgoneta:");
                                Furgoneta furgo = new Furgoneta(Patente, kilometraje, carga);
                                Vehiculo.ListaVehiculos.Add(furgo);
                                break;

                            case "3":
                                Patente = IngresarString("Ingrese la placa de la motocicleta:");
                                kilometraje = PedirEntero("Ingrese el kilometraje");
                                Motocicleta moto = new Motocicleta(Patente, kilometraje);
                                Vehiculo.ListaVehiculos.Add(moto);
                                break;

                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey(); 
                        break;

                    case "2":
                        MostrarVehiculos();
                        int eleccionVehiculoARegistrarleViaje = PedirEntero("Elija el vehículo al cual necesita registrarle un viaje:");
                        Vehiculo vehiculo = Vehiculo.ListaVehiculos[eleccionVehiculoARegistrarleViaje - 1];
                        int distanciaRecorrida = PedirEntero("Ingrese la distancia recorrida en el viaje:");
                        if (vehiculo.Tipo == "Camión" || vehiculo.Tipo == "Furgoneta")
                        {

                            int cargaTransportadaEnElViaje = PedirEntero("Ingrese la carga transportada en el viaje");
                            DateTime fechaDelViaje = PedirFecha("Ingrese la fecha del viaje");
                            Viaje viajeNuevo = new Viaje(distanciaRecorrida, fechaDelViaje);
                            viajeNuevo.AgregarCarga(cargaTransportadaEnElViaje);
                            vehiculo.AgregarViaje(viajeNuevo);

                        }
                        else
                        {

                            DateTime fechaDelViaje = PedirFecha("Ingrese la fecha del viaje");
                            Viaje viajeNuevo = new Viaje(distanciaRecorrida, fechaDelViaje);
                            vehiculo.AgregarViaje(viajeNuevo);


                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        MostrarVehiculos();
                        int eleccionInfoVehiculo = PedirEntero("Elija el vehiculo del cual quiere ver su información:");
                        while (eleccionInfoVehiculo < 1 || eleccionInfoVehiculo > Vehiculo.ListaVehiculos.Count)
                        {

                            eleccionInfoVehiculo = PedirEntero("Ese vehiculo no esta registrado, prueba con otro:");

                        }
                        Vehiculo vehiculoElegido = Vehiculo.ListaVehiculos[eleccionInfoVehiculo - 1];
                        if (vehiculoElegido is Camion camioon)
                        {

                            Console.WriteLine($"Tipo de vehículo: {camioon.Tipo}; Kilometraje total: {camioon.Kilometraje}; Capacidad de carga: {camioon.CargaAdicional}; Cantidad de viajes realizados: {camioon.ListaViajes.Count}; Carga total transportada: {camioon.CargaTotalTransportada()}; Distancia total recorrida: {camioon.CalcularDistanciaTotal()}");

                        }
                        else if (vehiculoElegido is Furgoneta furgo)
                        {

                            Console.WriteLine($"Tipo de vehículo: {furgo.Tipo}; Kilometraje total: {furgo.Kilometraje}; Capacidad de carga: {furgo.CargaAdicional}; Cantidad de viajes realizados: {furgo.ListaViajes.Count}; Carga total transportada: {furgo.CargaTotalTransportada()}; Distancia total recorrida: {furgo.CalcularDistanciaTotal()}");

                        }
                        else if (vehiculoElegido is Motocicleta moto)
                        {

                            Console.WriteLine($"Tipo de vehículo: {moto.Tipo}; Kilometraje total: {moto.Kilometraje}; Cantidad de viajes realizados: {moto.ListaViajes.Count}; Distancia total recorrida: {moto.CalcularDistanciaTotal()}");

                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        int CargaGlobalTransportada = 0;
                        int DistanciaGlobalRecorrida = 0;
                        foreach (Vehiculo v in Vehiculo.ListaVehiculos)
                        {

                            Console.WriteLine($"placa: {v.Placa}; Tipo de vehículo: {v.Tipo}; Kilometraje: {v.Kilometraje}; Cantidad de viajes {v.ListaViajes.Count}; Distancia total recorrida: {v.CalcularDistanciaTotal}km");
                            if (v is Camion truck)
                            {

                                
                                int CargaTotalTransportadaPorVehiculo = truck.CargaTotalTransportada();
                                Console.WriteLine($"{CargaTotalTransportadaPorVehiculo}kg");
                                CargaGlobalTransportada += CargaTotalTransportadaPorVehiculo;


                            }
                            else if (v is Furgoneta furg)
                            {

                                
                                int CargaTotalTransportadaPorVehiculoFurgo = furg.CargaTotalTransportada();
                                Console.WriteLine($"{CargaTotalTransportadaPorVehiculoFurgo}kg");
                                CargaGlobalTransportada += CargaTotalTransportadaPorVehiculoFurgo;

                            }

                            DistanciaGlobalRecorrida += v.CalcularDistanciaTotal();

                        }
                        Console.WriteLine("Información de la flota:");

                        Console.WriteLine($"Carga total transportada por todos los vehículos: {CargaGlobalTransportada}");
                        Console.WriteLine($"Cantidad de vehículos: {Vehiculo.ListaVehiculos.Count}");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opción equivocada, elija otra");
                        break;
                }


                Console.Clear();
                eleccion = IngresarString("¡Bienvenido a nuestro sistema de viajes!\nElija una opción:\n1. Agregar un vehículo\n2. Registrar un viaje para un vehículo\n3. Mostrar información de un vehículo\n4. Mostrar todos los vehículos y estadísticas generales\n5. Salir");


            }


            Console.WriteLine("Saliste del programa");

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

        public static void MostrarVehiculos()
        {
            Console.WriteLine("Vehículos registrados:");
            for (int i = 0; i < Vehiculo.ListaVehiculos.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {Vehiculo.ListaVehiculos[i].Tipo} {Vehiculo.ListaVehiculos[i].Placa}");

            }

        }

        public static string IngresarString(string mensaje)
        {
            
            Console.WriteLine(mensaje);
            string palabra = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(palabra) == true)
            {

                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                palabra = Console.ReadLine();

            }

            return palabra;

        }



    }
}
