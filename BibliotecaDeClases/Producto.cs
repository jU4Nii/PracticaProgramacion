﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Producto
    {

        public Producto(string Nombre, float Precio)
        {
            this.Nombre = Nombre;

            this.Precio = Precio;


        }

        public string Nombre { get; set; }

        public float Precio { get; set; }

    }
}
