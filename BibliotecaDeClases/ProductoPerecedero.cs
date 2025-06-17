using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ProductoPerecedero : Producto
    {

        public ProductoPerecedero(string Nombre, int Precio, string FechaCaducidad) : base(Nombre,Precio)
        {

            this.FechaCaducidad = FechaCaducidad;

        }

        public void EstaVencido(string Fecha)
        {
            


        }

        public string FechaCaducidad { get; set; }

    }
}
