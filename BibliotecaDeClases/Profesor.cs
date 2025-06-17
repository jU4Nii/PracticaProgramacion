using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Profesor : Persona1
    {

        public Profesor(string Nombre, int DNI, string Materia) : base(Nombre,DNI)
        {

            this.Materia = Materia;

        }

        public string Materia { get; set; }

        public void Enseñar()
        {

            Console.WriteLine($"El profesor {Nombre} esta enseñando {Materia}");

        }

    }
}
