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
        public List<Cotizacion> OportunidadesVentas = new List<Cotizacion>();
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

        public void AgregarCliente(String name, String apell, int tel, String correo)
        {
            BaseDatos bd1 = BaseDatos.Instance; 
            //Inecesario, pero por si acaso para no encontrarme errores al agregarlo a la cartera
            if (!bd1.ExisteCorreo(correo) && !bd1.ExisteTel(tel))
            {
                Cliente instanca1 = new Cliente(name, apell, correo, tel);
                Cartera.Add(instanca1);
            }
            else
            {
                Console.WriteLine("El correo o telefono ya esta ocupado");
            }
        }
        
        public void CrearVentas()
        {
            //Falta Implementar Ventas
        }
        
        //Vere si la agrego al UML
        public bool VerificarTelCartera(int tel)
        {
            bool resultado = false;
            foreach (Cliente cliente in Cartera)
            {
                if (cliente.Tel == tel)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public void CrearCoti(int telcliente, DateTime fecha, Double valor, String imp)
        {
            if (VerificarTelCartera(telcliente))
            {
                Cotizacion instancia2 = new Cotizacion(this,telcliente,fecha, valor, imp);
                OportunidadesVentas.Add(instancia2);
            }
            else
            {
                Console.WriteLine("Telefono no encontrado");
            }
        }
        
        
    }
} 