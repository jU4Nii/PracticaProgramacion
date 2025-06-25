using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class Email : INotificable
    {

        public void Notificar(string Mensaje)
        {

            Console.WriteLine($"Se notificó el email con el mensaje '{Mensaje}'");

        }

    }
}
