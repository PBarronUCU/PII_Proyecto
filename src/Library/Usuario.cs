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
        public bool Suspendido { get; private set; }

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

        public void CrearCliente(String name, String apell, int tel, String correo)
        {
            BaseDatos bd1 = BaseDatos.Instance; 
            //Inecesario, pero por si acaso para no encontrarme errores al agregarlo a la cartera
            if (!bd1.ExisteCorreo(correo) & !bd1.ExisteTel(tel))
            {
                Cliente instancia1 = new Cliente(name, apell, correo, tel);
                Cartera.Add(instancia1);
            }
            else
            {
                Console.WriteLine("El correo o telefono ya esta ocupado");
            }
        }

        public void Suspender()
        {
            Suspendido = true;
        }
        public void CrearVentas(int tel,string prod,Double precio,DateTime fecha)
        {
            BaseDatos bd1 = BaseDatos.Instance;
            Cliente client = bd1.ClienteSegunTelefono(tel);
            if (!bd1.ExisteVenta(this,client, prod, precio, fecha))
            {
                if (VerificarTelCartera(tel))
                {
                    Ventas instancia3 = new Ventas(this,client,prod,precio,fecha);
                    bd1.AgregarVenta(instancia3);
                }
                else
                {
                    Console.WriteLine("Telefono no encontrado");
                }
                
            }
            else
            {
                Console.WriteLine("Venta repetida");
            }
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

        public void EliminarTelCartera(int tel)
        {
            foreach (Cliente cliente in Cartera)
            {
                if (cliente.Tel == tel)
                {
                    Cartera.Remove(cliente);
                }
            }
        }
        
        

        public void CrearCoti(int telcliente, DateTime fecha, Double valor, String imp)
        {
            BaseDatos bd1 = BaseDatos.Instance;
            Cliente cliente = bd1.ClienteSegunTelefono(telcliente);
            if (VerificarTelCartera(telcliente))
            {
                Cotizacion instancia2 = new Cotizacion(this,cliente,fecha, valor, imp);
                OportunidadesVentas.Add(instancia2);
            }
            else
            {
                Console.WriteLine("Telefono no encontrado");
            }
        }

        /// <summary>
        /// El telefono es para identificar el Cliente, NO para cambiarlo.
        /// </summary>
        public void ModificarCliente(string nombre,string apell, int tel, string genero,DateTime fecha )
        {
            int i = 0;
            bool encontrado = false;
            Cliente client;
            BaseDatos bd1 = BaseDatos.Instance;
            while (i < bd1.ListaCliente.Count & !encontrado)
            {
                if (bd1.ListaCliente[i].Tel == tel) //primero hago metodos de base de datos
                {
                    Cliente cliente = bd1.ListaCliente[i];
                    encontrado = true;
                }

                i++;
            }
            
        }
    }
} 