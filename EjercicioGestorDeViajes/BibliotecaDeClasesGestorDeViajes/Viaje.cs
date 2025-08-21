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

        public Viaje(int Distancia, int CargaTransportada, DateTime Fecha)
        {
            this.Distancia = Distancia;
            this.CargaTransportada = CargaTransportada;
            this.Fecha = Fecha;
        }

        public int Distancia {  get; set; }

        public int CargaTransportada {  get; set; }

        public DateTime Fecha { get ; set; }


    }
}
