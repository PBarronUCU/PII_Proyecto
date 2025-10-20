using System;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public class Cotizacion
    {
        public Usuario Usuario { get;}
        public Cliente Cliente { get; }
        public DateTime Fecha { get; set; }
        public Double Valor { get; set; }
        public String Importancia { get; set; }

        public Cotizacion(Usuario usuario, Cliente cliente, DateTime fecha, Double valor, String imp)
        {
            Usuario = usuario;
            Cliente = cliente;
            Fecha = fecha;
            Valor = valor;
            Importancia = imp;
            
        }
        
    }
}