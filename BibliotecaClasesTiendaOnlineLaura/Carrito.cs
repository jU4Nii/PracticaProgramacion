﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Carrito
    {

        public Carrito()
        {

            ListaCarritoUsuario = new List<Producto>();

        }


        public List<Producto> ListaCarritoUsuario {  get; set; } 

       

        public void AñadirObjeto(Producto producto)
        {
            ListaCarritoUsuario.Add(producto);
            


        }

        public void MostrarCarrito()
        {
            Console.WriteLine("Productos en el carrito:");

            for (int i = 0; i < ListaCarritoUsuario.Count; i++)
            {
                Console.WriteLine($"{ListaCarritoUsuario[i].NombreProducto}");
            }


        }

        public void GenerarFactura()
        {

            foreach(Producto p in ListaCarritoUsuario)
            {

                Console.WriteLine($"{p.NombreProducto} - ${p.Precio}");

            }


        }

    }
}
