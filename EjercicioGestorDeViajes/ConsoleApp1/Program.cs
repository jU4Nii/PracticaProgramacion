using BibliotecaDeClasesGestorDeViajes;
using Microsoft.VisualBasic;

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
                            Console.WriteLine("Ingrese el kilometraje:");
                            string input = Console.ReadLine();
                            int Kilometraje;
                            bool Conversion = int.TryParse(input, out Kilometraje);
                            while(Conversion == false)
                            {
                                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                                input = Console.ReadLine();
                                Conversion = int.TryParse(input,out Kilometraje);

                            }
                            break;

                        case "2":
                            Console.WriteLine("Ingrese la placa de la furgoneta:");
                            Patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el kilometraje:");
                            input = Console.ReadLine();
                            
                            Conversion = int.TryParse(input, out Kilometraje);
                            while (Conversion == false)
                            {
                                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                                input = Console.ReadLine();
                                Conversion = int.TryParse(input, out Kilometraje);

                            }
                            break;

                        case "3":
                            Console.WriteLine("Ingrese la placa de la moto:");
                            Patente = Console.ReadLine();
                            Console.WriteLine("Ingrese el kilometraje:");
                            input = Console.ReadLine();

                            Conversion = int.TryParse(input, out Kilometraje);
                            while (Conversion == false)
                            {
                                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                                input = Console.ReadLine();
                                Conversion = int.TryParse(input, out Kilometraje);

                            }
                            break;

                    }
                    break;

                case "2":
                    Console.WriteLine("Elija el vehículo para el cual quiere registrarle un viaje:");
                    for(int i = 0; i < Vehiculo.ListaVehiculo.Count; i++)
                    {

                        Console.WriteLine($"{i+1}. {Vehiculo.ListaVehiculo[i]}");

                    }
                    string input2 = Console.ReadLine();
                    int eleccion2;
                    bool conversion2 = int.TryParse(input2, out eleccion2);
                    while (conversion2 == false)
                    {
                        Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                        input2 = Console.ReadLine();
                        conversion2 = int.TryParse(input2, out eleccion2);

                    }
                    Vehiculo vehiculo = Vehiculo.ListaVehiculo[eleccion2 - 1];
                    break;

            }
            
           

        }
    }
}
