using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class TarjetaCredito : IMetodoPago
    {

        public TarjetaCredito(string NombreTitular, long NumeroTarjeta, int PinSeguridad)
        {
            this.NombreTitular = NombreTitular;

            this.NumeroTarjeta = NumeroTarjeta;

            this.PinSeguridad = PinSeguridad;
        }

        public void Pagar(float Monto)
        {

            Console.WriteLine($"Pago exitoso de ${Monto} mediante tarjeta de crédito");

        }

        public string NombreTitular {  get; set; }

        public long NumeroTarjeta { get; set; }

        public int PinSeguridad { get; set; }

    }
}
