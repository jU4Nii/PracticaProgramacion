using Biblioteca_De_Clases1;
namespace MásPrácticaPOO

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            TarjetaCredito Visa = new TarjetaCredito("Francisco Osenda", 1234123412341234, 793);
            TransferenciaBancaria MercadoPago = new TransferenciaBancaria("Alias del local", 0000001239123912392);

            List<IMetodoPago> ListaMetodoDePago = new List<IMetodoPago> {Visa, MercadoPago};

            Console.WriteLine("Ingrese el monto a pagar:");

            float Monto = float.Parse(Console.ReadLine()); 

            foreach(IMetodoPago metodo in ListaMetodoDePago)
            {

                metodo.Pagar(Monto);

            }
            */

            /*
            Paloma paloma = new Paloma();
            Pez pez = new Pez();   
            Leon leon = new Leon();

            List<Animal> animales = new List<Animal> { paloma, pez, leon };

            foreach(Animal animal in animales)
            {

                animal.Movilidad();

            }
            */

            /*
            Teclado teclado = new Teclado();
            Monitorr monitor = new Monitorr();
            Impresora impresora = new Impresora();

            List<IConectable> listaDispositivos = new List<IConectable> { teclado, monitor, impresora};

            foreach (IConectable dispositivo in listaDispositivos)
            {

                dispositivo.Conectar();
                dispositivo.Desconectar();

            }
            */

            PushNotification notificacion = new PushNotification();
            Email correo = new Email();
            SMS mensaje = new SMS();

            List<INotificable> listaNotificaciones = new List<INotificable> { notificacion, correo, mensaje };

            foreach (INotificable noti in listaNotificaciones)
            {

                noti.Notificar("Mensaje");

            }

        }
    }
}
