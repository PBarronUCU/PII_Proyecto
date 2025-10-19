using System.Collections.Generic;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public sealed class BaseDatos
    {
        private static readonly BaseDatos _instance = new BaseDatos();
        public List<Usuario> ListaUsuario = new List<Usuario>();
        public List<Ventas> ListaVentas = new List<Ventas>();
        public List<Cliente> ListaCliente = new List<Cliente>();
        
        
        private BaseDatos()
        {
        }
        
        public static BaseDatos Instance
        {
            get { return _instance; }
        }
        
    }
}