namespace BibliotecaDeClasesGestionDeViajes
{
    public abstract class Vehiculo
    {

        public string Placa { get; set; }   

        public int Kilometraje {  get; set; }   

        public List<Viaje> listaViajes { get; set; }

        public void AgregarViaje(Viaje ViajeAAgregar)
        {

            listaViajes.Add(ViajeAAgregar);

        }

    }
}
