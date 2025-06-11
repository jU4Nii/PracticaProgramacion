using BibliotecaDeClases;
namespace Práctica_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona pibe = new Persona();

            pibe.Nombre = "Juani";

            pibe.Edad = 20;

            //pibe.Saludar();

            Empleado Juan = new Empleado();

            Juan.Puesto = "Desarrollador";

            Juan.Trabajar();            


        }
    }
}
