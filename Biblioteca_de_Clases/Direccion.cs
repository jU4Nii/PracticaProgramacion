using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Direccion
    {

        public Direccion(string Calle, int Altura)
        {
            this.Calle = Calle;

            this.Altura = Altura;   

        }

        public void MostrarDireccion()
        {

            Console.WriteLine(Calle + Altura);

        }

        public string Calle {  get; set; }

        public int Altura { get; set; }


    }
}
