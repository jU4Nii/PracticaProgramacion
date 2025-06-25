using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Teclado : IConectable
    {

        public void Conectar()
        {

            Console.WriteLine("Teclado conectado");

        }

        public void Desconectar()
        {

            Console.WriteLine("Teclado desconectado");

        }

    }
}
