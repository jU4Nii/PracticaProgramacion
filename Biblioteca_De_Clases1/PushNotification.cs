﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases1
{
    public class PushNotification : INotificable
    {

        public void Notificar(string Mensaje)
        {

            Console.WriteLine($"Se notificó el mensaje '{Mensaje}'");

        }

    }
}
