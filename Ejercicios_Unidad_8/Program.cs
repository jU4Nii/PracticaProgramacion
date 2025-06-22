using Biblioteca_de_Clases;
using System.Security.Cryptography.X509Certificates;
namespace Ejercicios_Unidad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO1
            Perro Picante = new Perro();
            Vaca Lola = new Vaca();
            Animal animal = new Animal();  
            Perro perrito = new Perro();
            Vaca vaca = new Vaca();

            List<Animal> animales = new List<Animal> { Picante, Lola, animal, perrito, vaca };

            foreach(Animal a in animales)
            {
                a.HacerSonido();
            }
            */

            /*EJERCICIO2
            Direccion casa = new Direccion("Tucumán", 1267);
            Persona Juani = new Persona("Juan Ignacio Bonora", 20, casa);
            Juani.MostrarInfo();
            */

            /*EJERCICIO3
            EmpleadoPermanente Juani = new EmpleadoPermanente("Juan Ignacio Bonora", 160, 20000);
            Juani.CalcularSueldo();
            EmpleadoTemporal Marian = new EmpleadoTemporal("Mariano Aressi", 80, 10000,6);
            Marian.CalcularSueldo();
            */

            /*EJERCICIO4
            Bicicleta cleta = new Bicicleta("Venzo");
            //cleta.Conducir();
            Auto corolla = new Auto("Toyota", "Corolla", 2025);
            //corolla.Conducir();
            List<IVehiculo> listaVehiculos = new List<IVehiculo> { corolla, cleta};
            foreach(IVehiculo v in listaVehiculos)
{
                v.Conducir();
            }
            */

            Alumno Juani = new Alumno("Juan Ignacio Bonora");
            Alumno Marian = new Alumno("Mariano Aressi");
            Alumno Robertito = new Alumno("Roberto");

            Curso curso1 = new Curso("1° Desarrollo de Software");
            curso1.añadirAlumno(Juani);
            curso1.añadirAlumno(Marian);
            curso1.añadirAlumno(Robertito);
            curso1.MostrarAlumnos();

            Alumno Christian = new Alumno("Christian");
            Alumno Carlos = new Alumno("Carlos");

            Curso curso2 = new Curso("2° Desarrollo de Software");
            curso2.añadirAlumno(Christian);
            curso2.añadirAlumno(Carlos);
            curso2.MostrarAlumnos();

        }
    }
}
