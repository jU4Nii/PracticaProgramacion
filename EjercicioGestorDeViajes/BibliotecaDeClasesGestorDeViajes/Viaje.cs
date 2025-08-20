using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesGestorDeViajes
{
    public class Viaje
    {
        //Viaje: clase para registrar cada viaje, con propiedades distancia, cargaTransportada, y fecha.

        public int Distancia {  get; set; }

        public int CargaTransportada {  get; set; }

        public DateTime Fecha { get ; set; }


    }
}
