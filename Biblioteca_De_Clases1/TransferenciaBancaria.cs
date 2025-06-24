using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class TransferenciaBancaria : IMetodoPago
    {

        public TransferenciaBancaria(string Alias, long CBU)
        {
            this.Alias = Alias;
            this.CBU = CBU;
        }

        public void Pagar(float Monto)
        {

            Console.WriteLine($"Pago exitoso de ${Monto} mediante transferencia bancaria");

        }

        public string Alias { get; set; }

        public long CBU {  get; set; }

    }
}
