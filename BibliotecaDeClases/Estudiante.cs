using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Estudiante : Persona1
    {

        public Estudiante(string Nombre, int DNI, int Legajo) : base(Nombre,DNI)
        {

            this.Legajo = Legajo;

        }

        public int Legajo { get; set; }

        public void Estudiar()
        {

            Console.WriteLine($"El alumno {Nombre} está estudiando");

        }

    }
}
