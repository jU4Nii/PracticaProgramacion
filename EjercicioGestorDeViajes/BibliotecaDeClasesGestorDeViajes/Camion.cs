using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesGestorDeViajes
{
    public class Camion : Vehiculo
    {
        //Camión tiene capacidad de carga adicional y método para calcular carga máxima por viaje.

        public Camion(string Placa, int Kilometraje, int CargaAdicional) : base(Placa, Kilometraje)
        {
            this.CargaAdicional = CargaAdicional;
            Tipo = "Camión";

        }
        public int CargaAdicional {  get; set; }

        public int CalcularCargaMaxima()
        {
            int max = 0;

            foreach(Viaje viaje in ListaViajes)
            {

                if (viaje.CargaTransportada > max)
                {

                    max = viaje.CargaTransportada;

                }

                
            }

            int cargaMaxima = max;
            return cargaMaxima;

        }

    }
}
