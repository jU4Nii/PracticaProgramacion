using BibliotecaClasesTiendaOnlineLaura;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EjercicioTiendaOnlineLaura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogo.InicializarCatalogo();

            Console.WriteLine("¡Bienvenido a la tienda online de Laura!");
            Console.WriteLine("Seleccione su rol:\n1. Cliente\n2. Administrador\n3. Salir");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                    
                    Console.WriteLine("Opciones:\n1. Ver productos disponibles\n2. Agregar productos al carrito\n3. Ver carrito\n4. Confirmar compra\n5. Volver al menu principal");
                    string eleccionCliente = Console.ReadLine();
                    switch (eleccionCliente)
                    {
                        case "1":
                            Console.WriteLine("Productos en stock");
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

                            Console.WriteLine("Ingrese el producto que quiere agregar al carrito:");
                            string nombreProd = Console.ReadLine();
                            for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
                            {

                                if (nombreProd == Catalogo.ListaProductos[i].NombreProducto)
                                {
                                    if (nombreProd != .ListaCarritoUsuario)


                                }


                            }
                            break;
                    }


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
                                conversion2 = int.TryParse(ingresoDeInfo1, out cantDisponibleProdNuevo);
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
                            new Cliente(nombre, DNI);
                            Console.WriteLine($"¡El cliente {nombre} fue creado con exito!");
                    }
                    break;

            }

            
        }
    }
}
