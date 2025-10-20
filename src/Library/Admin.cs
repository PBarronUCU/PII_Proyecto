using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
{
    public class Admin
    {
        public string Nombre { get; set; }

        // 👇 Constructor: se ejecuta al crear un nuevo Admin
        public Admin(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarUsuario(string name, string apell, string correo)
        {
            BaseDatos bd2 = BaseDatos.Instance;
            if (!bd2.ExisteCorreo(correo))
            {
                Usuario instanca2 = new Usuario(name, apell, correo);
            }
            else
            {
                Console.WriteLine("El correo ya esta ocupado");
            }
        }

        public void SuspenderUsuario(string correo)
        {
            BaseDatos bd1 = BaseDatos.Instance;

            foreach (Usuario usuario in bd1.ListaUsuario)
            {
                if (usuario.Correo == correo) // buscamos el correo del usuario a suspender
                {
                    usuario.Suspender();
                    break; // salimos del bucle cuando lo encontramos
                }
            }
        }
    }
}