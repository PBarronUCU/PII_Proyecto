using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member


namespace Library
{
    public class Ventas
    {
        public DateTime Dia_venta { get; set; }
        public Usuario Usuario { get; set; }
        public int ClienteTel { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }

        public Ventas(Usuario usuario, int clienteTel, string producto, double precio, DateTime diaVenta)
        {
            Usuario = usuario;
            ClienteTel = clienteTel;
            Producto = producto;
            Precio = precio;
            Dia_venta = diaVenta;
        }
    }
}