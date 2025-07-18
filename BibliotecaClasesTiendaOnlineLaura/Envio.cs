using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Envio                                       
    {

        public Envio(string EstadoEnvio, string Direccion)
        {

            this.EstadoEnvio = EstadoEnvio;
            this.Direccion = Direccion;

        }

        public string Direccion { get; set; }

        public string EstadoEnvio {  get; set; }

    }
}
