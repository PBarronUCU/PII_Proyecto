using System;
using System.Collections.Generic;using System.Collections.ObjectModel;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Library


{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; }
        public List<Cliente> Cartera = new List<Cliente>();
        public List<IInteracion> ListaInteracciones = new List<IInteracion>();
        public bool Suspendido { get; }

        public Usuario(string nombre, string apellido, string correo)
        {
            BaseDatos bd1 = BaseDatos.Instance;
            if (!bd1.ExisteCorreo(correo))
            {
                Nombre = nombre;
                Apellido = apellido;
                Correo = correo;
                Suspendido = false;
                bd1.AgregarUsuario(this);
            }
            else
            {
                Console.WriteLine("El correo ya esta ocupado");
            }
        }
    }
} 