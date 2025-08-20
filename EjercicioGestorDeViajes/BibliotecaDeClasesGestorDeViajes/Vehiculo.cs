namespace BibliotecaDeClasesGestorDeViajes
{
    public abstract class Vehiculo
    {
        //placa, kilometraje, viajes y métodos para agregar viajes y calcular distancia total.

        public Vehiculo(string Placa, int Kilometraje)
        {

            this.Placa = Placa;

            this.Kilometraje = Kilometraje; 

        }


        public string Placa { get; set; }

        public int Kilometraje { get; set; }

        public string Tipo { get; set; }

        public List<Viaje> ListaViajes { get; set; } = new List<Viaje>();

        public static List<Vehiculo> ListaVehiculo = new List<Vehiculo>();

        public void AgregarViaje(Viaje viajecito)
        {

            ListaViajes.Add(viajecito);

        }

        public void CalcularDistanciaTotal()
        {

            int distanciaTotal = 0;

            for(int  i = 0; i < ListaViajes.Count; i++)
            {

                distanciaTotal = distanciaTotal + ListaViajes[i].Distancia;

            }

        }


    }
}
