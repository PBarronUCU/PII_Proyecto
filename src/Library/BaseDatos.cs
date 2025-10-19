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

        public bool ExisteCorreo(string correo)
        {
            bool result = false;
            foreach (Usuario user in ListaUsuario)
            {
                if (user.Correo == correo)
                {
                    result = true;
                }
            }
            foreach (Cliente client in ListaCliente)
            {
                if (client.Correo == correo)
                {
                    result = true;
                }
            }
            return result;
        }
        
        public bool ExisteTel(int tel)
        {
            bool result = false;
            foreach (Cliente client in ListaCliente)
            {
                if (client.Tel == tel)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool ExisteCorreoUser(string correo)
        {
            bool result = false;
            foreach (Usuario user in ListaUsuario)
            {
                if (user.Correo == correo)
                {
                    result = true;
                }
            }
            return result;
        }

        public void AgregarUsuario(Usuario user)
        {
            string correo = user.Correo;
            if (!ExisteCorreo(correo))
            {
                ListaUsuario.Add(user);
            }
            
        }

        public void AgregarCliente(Cliente client)
        {
            string correo = client.Correo;
            int tel = client.Tel;
            if (!ExisteCorreo(correo) && !ExisteTel(tel))
            {
                ListaCliente.Add(client);
            }
        }
        
    }
}