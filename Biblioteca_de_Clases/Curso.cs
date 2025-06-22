using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Curso
    {

        public Curso(string NombreCurso)
        {

            this.NombreCurso = NombreCurso;
            ListaAlumnos = new List<Alumno>();
        }

        public void añadirAlumno(Alumno alumno)
        {

            ListaAlumnos.Add(alumno);

        }

        public void MostrarAlumnos()
        {

            Console.WriteLine($"Curso: {NombreCurso}");

            foreach(Alumno a in ListaAlumnos)
            {

                Console.WriteLine(a.NombreAlumno);

            }

        }

        public string NombreCurso { get; set; }

        List<Alumno> ListaAlumnos {  get; set; }

        

    }
}
