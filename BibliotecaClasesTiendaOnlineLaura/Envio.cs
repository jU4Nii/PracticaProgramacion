using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Envio                                       
    {

        public Envio(string EstadoEnvio)
        {

            this.EstadoEnvio = EstadoEnvio;

        }

        public string EstadoEnvio {  get; set; }

    }
}
