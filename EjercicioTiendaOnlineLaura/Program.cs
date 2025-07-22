using BibliotecaClasesTiendaOnlineLaura;
using System.ComponentModel.Design;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EjercicioTiendaOnlineLaura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogo.InicializarCatalogo();
            Cliente cliente = null;

            Console.WriteLine("¡Bienvenido a la tienda online de Laura!");

            while(cliente == null)
            {
                Console.WriteLine("Seleccione su rol:\n2. Administrador\n3. Salir");
                string eleccion = Console.ReadLine();

                

                    switch (eleccion)
                    {


                        case "2":
                            Console.WriteLine("Opciones:\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n4. Crear cliente\n5. Volver al menu principal");
                            string eleccionAdmin = Console.ReadLine();

                             while (eleccionAdmin != "5")
                             {
    
                            
                                switch (eleccionAdmin)
                                {
                                    case "1":
                                        Console.WriteLine("");
                                        Console.WriteLine("Productos en stock");
                                        Console.WriteLine("Producto - Cantidad disponible");
                                        for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                        {

                                            Console.WriteLine($"{Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].CantidadDisponible}");

                                        }
                                        Console.WriteLine(" ");
                                        break;
                                    case "2":
                                        Console.WriteLine("A continuación debe ingresar el nombre del producto nuevo:");
                                        string nombreProdNuevo = Console.ReadLine();
                                        Console.WriteLine("Ingrese el precio del nuevo producto:");
                                        string ingresoDeInfo = Console.ReadLine();
                                        double precioProdNuevo;
                                        bool conversion1 = double.TryParse(ingresoDeInfo, out precioProdNuevo);
                                        while (conversion1 == false)
                                        {
                                            Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                            ingresoDeInfo = Console.ReadLine();
                                            conversion1 = double.TryParse(ingresoDeInfo, out precioProdNuevo);
                                        }
                                        Console.WriteLine("Ingrese la cantidad disponible actualmente:");
                                        string ingresoDeInfo1 = Console.ReadLine();
                                        int cantDisponibleProdNuevo;
                                        bool conversion2 = int.TryParse(ingresoDeInfo1, out cantDisponibleProdNuevo);
                                        while (conversion2 == false)
                                        {
                                            Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                            ingresoDeInfo1 = Console.ReadLine();
                                            conversion2 = int.TryParse(ingresoDeInfo1, out cantDisponibleProdNuevo);
                                        }
                                        Catalogo.ListaProductos.Add(new Producto(nombreProdNuevo, precioProdNuevo, cantDisponibleProdNuevo));
                                        Console.WriteLine("Producto añadido exitosamente");
                                        break;

                                    case "3":
                                        Console.WriteLine("Ingrese el nombre del producto al que quiere aumentar stock:");
                                        string nombreProduc = Console.ReadLine();
                                        Console.WriteLine("Ingrese la cantidad que quiere añadir:");
                                        string ingresoDeInfo2 = Console.ReadLine();
                                        int cant;
                                        bool conversion3 = int.TryParse(ingresoDeInfo2, out cant);
                                        while (conversion3 == false)
                                        {
                                            Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                            ingresoDeInfo1 = Console.ReadLine();
                                            conversion3 = int.TryParse(ingresoDeInfo1, out cant);
                                        }
                                        for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                        {
                                            if (nombreProduc == Catalogo.ListaProductos[i].NombreProducto)
                                            {

                                                Catalogo.ListaProductos[i].CantidadDisponible += cant;

                                            }
                                        }
                                        break;

                                    case "4":
                                        Console.WriteLine("A continuación se le pedirán los datos del nuevo cliente:");
                                        Console.WriteLine("Ingrese el nombre y apellido:");
                                        string nombre = Console.ReadLine();
                                        Console.WriteLine("Ingrese el DNI:");
                                        string input = Console.ReadLine();
                                        int DNI;
                                        bool conversion = int.TryParse(input, out DNI);
                                        while (conversion == false)
                                        {
                                            Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                            input = Console.ReadLine();
                                            conversion = int.TryParse(input, out DNI);
                                        }
                                        cliente = new Cliente(nombre, DNI);
                                        Console.WriteLine($"¡El cliente {nombre} fue creado con exito!");
                                        break;
                                default:
                                    Console.WriteLine("Opción inexistente, pruebe con otro número");
                                    Console.WriteLine("");
                                    break;
                                }

                            if (cliente == null)
                            {

                                Console.WriteLine("Opciones:\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n4. Crear cliente\n5. Volver al menu principal");
                                eleccionAdmin = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Opciones:\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n5. Volver al menu principal");

                                eleccionAdmin = Console.ReadLine();
                                while(eleccionAdmin == "4")
                                {
                                    Console.WriteLine("Ya se ha creado un cliente. Elija otra opción o vuelva al menú principal.");
                                    Console.WriteLine("");
                                    Console.WriteLine("Opciones:\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n5. Volver al menu principal");
                                    Console.WriteLine("");
                                    eleccionAdmin = Console.ReadLine();

                                }

                            }

                        }
                        break;
                        }
                    

                
            }
           
            
                Console.WriteLine("Seleccione su rol:\n1. Cliente\n2. Administrador\n3. Salir");
                string eleccionn = Console.ReadLine();

                switch (eleccionn)
                {


                    case "2":
                        Console.WriteLine("Opciones:\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n4. Crear cliente\n5. Volver al menu principal");
                        string eleccionAdmin = Console.ReadLine();
                        switch (eleccionAdmin)
                        {
                            case "1":
                                Console.WriteLine("Productos en stock");
                                Console.WriteLine("Producto - Cantidad disponible");
                                for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                {

                                    Console.WriteLine($"{Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].CantidadDisponible}");

                                }
                                break;
                            case "2":
                                Console.WriteLine("A continuación debe ingresar el nombre del producto nuevo:");
                                string nombreProdNuevo = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio del nuevo producto:");
                                string ingresoDeInfo = Console.ReadLine();
                                double precioProdNuevo;
                                bool conversion1 = double.TryParse(ingresoDeInfo, out precioProdNuevo);
                                while (conversion1 == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                    ingresoDeInfo = Console.ReadLine();
                                    conversion1 = double.TryParse(ingresoDeInfo, out precioProdNuevo);
                                }
                                Console.WriteLine("Ingrese la cantidad disponible actualmente:");
                                string ingresoDeInfo1 = Console.ReadLine();
                                int cantDisponibleProdNuevo;
                                bool conversion2 = int.TryParse(ingresoDeInfo1, out cantDisponibleProdNuevo);
                                while (conversion2 == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                    ingresoDeInfo1 = Console.ReadLine();
                                    conversion2 = int.TryParse(ingresoDeInfo1, out cantDisponibleProdNuevo);
                                }
                                Catalogo.ListaProductos.Add(new Producto(nombreProdNuevo, precioProdNuevo, cantDisponibleProdNuevo));
                                Console.WriteLine("Producto añadido exitosamente");
                                break;

                            case "3":
                                Console.WriteLine("Ingrese el nombre del producto al que quiere aumentar stock:");
                                string nombreProduc = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad que quiere añadir:");
                                string ingresoDeInfo2 = Console.ReadLine();
                                int cant;
                                bool conversion3 = int.TryParse(ingresoDeInfo2, out cant);
                                while (conversion3 == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                    ingresoDeInfo1 = Console.ReadLine();
                                    conversion3 = int.TryParse(ingresoDeInfo1, out cant);
                                }
                                for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                {
                                    if (nombreProduc == Catalogo.ListaProductos[i].NombreProducto)
                                    {

                                        Catalogo.ListaProductos[i].CantidadDisponible += cant;

                                    }
                                }
                                break;

                           
                        }
                        break;

                    case "1":

                        Console.WriteLine("Opciones:\n1. Ver productos disponibles\n2. Agregar productos al carrito\n3. Ver carrito\n4. Confirmar compra\n5. Volver al menu principal");
                        string eleccionCliente = Console.ReadLine();
                        switch (eleccionCliente)
                        {
                            case "1":
                                Console.WriteLine("Productos disponibles");
                                Console.WriteLine("Producto - Precio");
                                for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                {
                                    if (Catalogo.ListaProductos[i].CantidadDisponible > 0)
                                    {

                                        Console.WriteLine($"{Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].Precio}");

                                    }

                                }
                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Productos disponibles:");
                                Console.WriteLine("   Producto - Precio");
                                string nombreProd = Console.ReadLine();
                                for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                {

                                    if (Catalogo.ListaProductos[i].CantidadDisponible > 0)
                                    {

                                        Console.WriteLine($"{i + 1}. {Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].Precio}");

                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("Ingrese el número que esta a la izquierda de un producto para agregarlo al carrito");
                                string ingresoNumero = Console.ReadLine();
                                int numeroDeProductoQueSeAgrega;
                                bool conversion4 = int.TryParse(ingresoNumero, out numeroDeProductoQueSeAgrega);
                                while (conversion4 == false)
                                {
                                    Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                    ingresoNumero = Console.ReadLine();
                                    conversion4 = int.TryParse(ingresoNumero, out numeroDeProductoQueSeAgrega);
                                }
                                cliente.AñadirACarrito(numeroDeProductoQueSeAgrega);
                                break;
                        }
                        break;


                }

            
                
                

            
        }
    }
}
