using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    // Crea una clase abstracta Animal con un método abstracto HacerSonido().
    // Crea clases Perro y Gato que hereden de Animal e implementen HacerSonido(). Crear sus constructores.
    public class Animal
    {
        public virtual void HacerSonido()
        {

            Console.WriteLine("Sonido genérico");

        }


    }
}
