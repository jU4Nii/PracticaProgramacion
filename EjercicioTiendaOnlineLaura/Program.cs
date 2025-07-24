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

            Administrador admin = new Administrador("Juan Ignacio Bonora", 46044159);

            Console.WriteLine("¡Bienvenido a la tienda online de Laura!");

            Catalogo.InicializarCatalogo();
            
            Cliente cliente = null;

            while (true)
            {

                
                if(cliente == null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Seleccione su rol:\n2. Administrador\n3. Salir");
                    
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Seleccione su rol:\n1. Cliente\n2. Administrador\n3. Salir");
                    
                }
                    
                string eleccionn = Console.ReadLine();

                Console.WriteLine("");

                if (eleccionn == "3")
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Usted salió del programa");
                    Console.WriteLine("");
                    break;
                    }
                    else
                    {

                            switch (eleccionn)
                        {


                            case "2":
                            if (cliente == null)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Opciones: Administrador\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n4. Crear cliente\n5. Volver al menu principal");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Opciones: Administrador\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n5. Volver al menu principal");
                                Console.WriteLine("");
                            }
                                string eleccionAdmin = Console.ReadLine();
                                while (eleccionAdmin != "5")
                                {

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
                                        Console.WriteLine("Producto - Cantidad disponible");
                                        for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                        {

                                            Console.WriteLine($"{i + 1}. {Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].CantidadDisponible}");
                                            
                                        }
                                        Console.WriteLine("Ingrese el número que esta a la izquierda del producto al cual quiere aumentar su stock:");
                                        string ingresoNumeroIzq = Console.ReadLine();
                                        int numProductto;
                                        bool convertir = int.TryParse(ingresoNumeroIzq, out numProductto);
                                        while(convertir == false)
                                        {
                                            Console.WriteLine("Valor incorrecto, ingreselo de nuevo:");
                                            ingresoNumeroIzq = Console.ReadLine();
                                            convertir = int.TryParse(ingresoNumeroIzq, out numProductto);
                                        }
                                        admin.AgregarStock(numProductto);
                                            
                                 
                                            break;

                                        case "4":
                                        if (cliente == null)
                                        {
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
                                        }
                                        else
                                        {
                                            Console.WriteLine("La opción crear cliente no está disponible porque ya existe uno.");
                                        }
                                            break;
                                        

                                        default:
                                            Console.WriteLine("Opción inexistente, debe elegir alguna de las siguientes:");
                                            Console.WriteLine("");
                                            break;
                                    }

                                if (cliente == null)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Opciones: Administrador\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n4. Crear cliente\n5. Volver al menu principal");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Opciones: Administrador\n1. Ver productos\n2. Agregar nuevo producto\n3. Aumentar stock de un producto existente\n5. Volver al menu principal");
                                    Console.WriteLine("");
                                }
                                eleccionAdmin = Console.ReadLine();

                            }
                                break;

                            case "1":
                            if (cliente == null)
                            {
                                Console.WriteLine("Todavía no se ha creado ningun cliente. Se debe crear uno desde el panel de administrador.");

                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Opciones: Cliente\n1. Ver productos disponibles\n2. Agregar productos al carrito\n3. Ver carrito\n4. Confirmar compra\n5. Volver al menu principal");
                                
                                string eleccionCliente = Console.ReadLine();
                                Console.WriteLine("");
                                while (eleccionCliente != "5")
                                {

                                    switch (eleccionCliente)
                                    {
                                        case "1":
                                            Console.WriteLine("");
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

                                            for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                                            {

                                                if (Catalogo.ListaProductos[i].CantidadDisponible > 0)
                                                {

                                                    Console.WriteLine($"{i + 1}. {Catalogo.ListaProductos[i].NombreProducto} - {Catalogo.ListaProductos[i].Precio}");

                                                }

                                            }
                                            Console.WriteLine("");
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

                                        case "3":

                                            cliente.VerCarrito();

                                            break;

                                        case "4":
                                            cliente.ConfirmarCompra();
                                            break;

                                        default:
                                            Console.WriteLine("Opción inexistente, debe elegir alguna de las siguientes:");



                                            Console.WriteLine("");
                                            break;
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("Opciones: Cliente\n1. Ver productos disponibles\n2. Agregar productos al carrito\n3. Ver carrito\n4. Confirmar compra\n5. Volver al menu principal");
                                    eleccionCliente = Console.ReadLine();
                                    Console.WriteLine("");

                                }
                                
                            }
                            break;

                    }





                }
            }
            
        }
    }
}
