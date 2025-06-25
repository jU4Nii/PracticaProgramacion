using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Monitorr : IConectable
    {

        public void Conectar()
        {

            Console.WriteLine("Monitor conectado");

        }

        public void Desconectar()
        {

            Console.WriteLine("Monitor desconectado");

        }

    }
}
