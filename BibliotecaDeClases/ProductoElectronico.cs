using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ProductoElectronico : Producto
    {

        public ProductoElectronico(string Nombre, float Precio, int Voltaje, bool TieneGarantia) : base(Nombre, Precio)
        {
            this.Voltaje = Voltaje;

            this.TieneGarantia = TieneGarantia;

        }
           
        public int Voltaje { get; set; }

        public bool TieneGarantia { get; set; }

    }
}
