using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Rectangulo : Figura
    {
        public Rectangulo(double Basee, double Altura)
        {
            this.Basee = Basee;

            this.Altura = Altura;   

        }
        public override double CalcularArea()
        {

            double area = Basee * Altura;

            Console.WriteLine($"El área del rectangulo con base {Basee} y altura {Altura} es {area}");

            return area;

        }

        public double Basee { get; set; }

        public double Altura { get; set; }

    }
}
