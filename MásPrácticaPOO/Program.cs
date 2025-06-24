using Biblioteca_De_Clases1;
namespace MásPrácticaPOO

{
    internal class Program
    {
        static void Main(string[] args)
        {

            TarjetaCredito Visa = new TarjetaCredito("Francisco Osenda", 1234123412341234, 793);
            TransferenciaBancaria MercadoPago = new TransferenciaBancaria("Alias del local", 0000001239123912392);

            List<IMetodoPago> ListaMetodoDePago = new List<IMetodoPago> {Visa, MercadoPago};

            Console.WriteLine("Ingrese el monto a pagar:");

            float Monto = float.Parse(Console.ReadLine()); 

            foreach(IMetodoPago metodo in ListaMetodoDePago)
            {

                

            }

        }
    }
}
