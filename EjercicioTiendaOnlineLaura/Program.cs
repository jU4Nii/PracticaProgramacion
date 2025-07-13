using BibliotecaClasesTiendaOnlineLaura;
namespace EjercicioTiendaOnlineLaura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto remera = new Producto("Remera", 1245, 3);
            Cliente juani = new Cliente("juani", 23, 2);
            juani.AñadirACarrito(remera, 1);
            juani.verCarrito();


        }
    }
}
