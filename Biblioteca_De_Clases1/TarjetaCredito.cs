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
           /* Console.WriteLine("Esta procesando su pago en tarjeta, elija la cantidad de cuotas en la que quiere hacerlo: 1, 3, 6, 9 o 12");
            string input = Console.ReadLine();
            int numCuotas;
            bool conversion = int.TryParse(input, out numCuotas);

            while (conversion == false)
            {
                Console.WriteLine("No se acepta ese número de cuotas, por favor elija alguna de las opciones que se muestran: 1, 3, 6, 9, 12.");
                input = Console.ReadLine();
                conversion = int.TryParse(input,out numCuotas);

            }

            while (numCuotas == 1 ||  numCuotas == 3 || numCuotas == 6 || numCuotas == 9 || numCuotas == 12)
            switch (numCuotas)
            {
                
                case 1:
                    Console.WriteLine($"La compra se ha procesado en un solo pago. El monto es {Monto}");
                    break;
                case 3:
                    double recargo = Monto * 0.10;
                    double montoFinal = Monto + recargo;
                    Console.WriteLine($"La compra se ha procesado en tres pagos. El monto queda en {montoFinal}, con un recargo de 10%");
                    break;

                case 6:
                    double recargo1 = Monto * 0.30;
                    double montoFinal1 = Monto + recargo1;
                    Console.WriteLine($"La compra se ha procesado en tres pagos. El monto queda en {montoFinal1}, con un recargo de 30%");
                    break;

                case 9:
                    double recargo2 = Monto * 0.50;
                    double montoFinal2 = Monto + recargo2;
                    Console.WriteLine($"La compra se ha procesado en tres pagos. El monto queda en {montoFinal2}, con un recargo de 50%");
                    break;

                case 12:
                    double recargo3 = Monto * 0.65;
                    double montoFinal3 = Monto + recargo3;
                    Console.WriteLine($"La compra se ha procesado en tres pagos. El monto queda en {montoFinal3}, con un recargo de 65%");
                    break;

                default:
                    Console.WriteLine("No se acepta ese número de cuotas, por favor elija alguna de las opciones que se muestran: 1, 3, 6, 9, 12.");
            }
            */
            Console.WriteLine($"Pago exitoso de ${Monto} mediante tarjeta de crédito");

        }

        public string NombreTitular {  get; set; }

        public long NumeroTarjeta { get; set; }

        public int PinSeguridad { get; set; }

    }
}
