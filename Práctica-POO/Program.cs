using BibliotecaDeClases;
namespace Práctica_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Persona pibe = new Persona("Juani", 20);
            pibe.Saludar();
            Empleado Juan = new Empleado("Juan Ignacio", 20, "Desarrollador");
            Juan.Trabajar(); */

            /*Gato Charly = new Gato("Negro", 4);
            Perro Picante = new Perro("Callejero", 15);
            Perro Flopi = new Perro("Galgo", 10);
            Gato Irma = new Gato("Naranja", 3);
            Gato Infil = new Gato("Tricolor", 5);

            List<Animal> listaAnimales = new List<Animal> {Charly, Picante, Flopi, Irma, Infil };

            for (int i = 0; i < listaAnimales.Count; i++)
            {

                listaAnimales[i].HacerSonido();

            }*/

            /*Vehiculo vehiculo = new Vehiculo();
            vehiculo.Conducir();
            Automovil auto = new Automovil("Chevrolet", 3);
            auto.Conducir();
            Camion mionca = new Camion("Peterbilt", 1000);
            mionca.Conducir();*/

            /*Circulo perez = new Circulo(5);
            Rectangulo recto = new Rectangulo(2, 5);
            perez.CalcularArea();
            recto.CalcularArea();*/

            /*LibroDigital libroDigi = new LibroDigital("El Secreto de mi voz", "Perez", 300, 50, "pdf");
            libroDigi.MostrarInfo();*/

            /*ProductoPerecedero Leche = new ProductoPerecedero("Leche", 1200, DateTime.Parse("14 / 08 / 2025"));
            ProductoElectronico Tv = new ProductoElectronico("Tv Philips", 500000, 220, true);

            Leche.EstaVencido(DateTime.Parse("13/08/2025"));*/

            Estudiante Juani = new Estudiante("Juan Ignacio Bonora", 46044159, 14);
            Profesor Juani1 = new Profesor("Juan Ignacio Carignano", 34202456, "Programación");
            Juani.Estudiar();
            Juani1.Enseñar();


        }
    }
}
