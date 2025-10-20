using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member


namespace Library
{
    public class Ventas
    {
        public DateTime FechaVenta {get;}
        public Usuario Usuario { get; }
        public int ClienteTel { get;}
        public string Producto { get;}
        public double Precio { get;}

        public Ventas(Usuario usuario, int clienteTel, string producto, double precio, DateTime diaVenta)
        {
            Usuario = usuario;
            ClienteTel = clienteTel;
            Producto = producto;
            Precio = precio;
            FechaVenta = diaVenta;
        }
    }
}