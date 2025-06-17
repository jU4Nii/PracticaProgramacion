using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }   

        public Circulo(double Radio)
        {

            this.Radio = Radio;

        }

        public override double CalcularArea()
        {

            double area = 3.14 * (Radio * Radio);

            Console.WriteLine($"El área del circulo con radio {Radio} es {area}");

            return area;

        }


    }
}
