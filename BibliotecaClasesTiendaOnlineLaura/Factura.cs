using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Factura
    {

        public Factura(List<Producto> ListaProductosFactura, List<double> SubTotales, double Impuestos, double Total)
        {

            this.ListaProductosFactura = ListaProductosFactura;

            this.SubTotales = SubTotales;

            this.Impuestos = Impuestos;

            this.Total = Total;

        }

        public List<Producto> ListaProductosFactura { get; set; }

        public List<double> SubTotales { get; set; }

        public double Impuestos { get; set; }

        public double Total { get; set; }

    }
}
