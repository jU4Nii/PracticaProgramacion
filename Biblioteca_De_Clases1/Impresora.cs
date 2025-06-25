using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Impresora : IConectable
    {

        public void Conectar()
        {

            Console.WriteLine("Impresora conectada");

        }

        public void Desconectar()
        {

            Console.WriteLine("Impresora desconectada");

        }

    }
}
