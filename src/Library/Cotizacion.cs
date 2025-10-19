using System;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public class Cotizacion
    {
        public Usuario Usuario { get;}
        public int ClienteTel { get; }
        public DateTime Fecha { get; set; }
        public Double Valor { get; set; }
        public String Importancia { get; set; }

        public Cotizacion(Usuario usuario, int clienteTel, DateTime fecha, Double valor, String imp)
        {
            Usuario = usuario;
            ClienteTel = clienteTel;
            Fecha = fecha;
            Valor = valor;
            Importancia = imp;
            
        }
        
    }
}