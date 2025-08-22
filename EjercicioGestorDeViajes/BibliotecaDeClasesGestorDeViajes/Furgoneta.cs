using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesGestorDeViajes
{
    public class Furgoneta : Vehiculo
    {
        
        public Furgoneta(string Placa, int Kilometraje, int CargaAdicional) : base(Placa, Kilometraje)
        {
            this.CargaAdicional = CargaAdicional;
            Tipo = "Furgoneta";

        }

        public int CargaAdicional { get; set; }

        public int CargaTotalTransportada()
        {
            int cargaTotal = 0;
            for (int i = 0; i < ListaViajes.Count; i++)
            {

                cargaTotal += ListaViajes[i].CargaTransportada;


            }

            Console.WriteLine($"{cargaTotal}kg");
            return cargaTotal;
        }

    }
}
