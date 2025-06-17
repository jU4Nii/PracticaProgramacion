using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ProductoPerecedero : Producto
    {

        public ProductoPerecedero(string Nombre, float Precio, DateTime FechaCaducidad) : base(Nombre,Precio)
        {

            this.FechaCaducidad = FechaCaducidad;

        }

        public void EstaVencido(DateTime Fecha)
        {

           if (Fecha > FechaCaducidad) Console.WriteLine("El producto está vencido");
           else if (Fecha < FechaCaducidad) Console.WriteLine("El producto todavía esta en fecha");
           else Console.WriteLine("Tu producto vence hoy");

        }

        public DateTime FechaCaducidad { get; set; }

    }
}
