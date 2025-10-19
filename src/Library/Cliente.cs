using System;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; }
        public int Tel { get; }
        public string Genero { get; }
        public DateTime FechaNac { get; set; }

        public Cliente(string nombre, string apellido, string correo, int tel)
        {
            BaseDatos bd1 = BaseDatos.Instance;
            if (!bd1.ExisteCorreo(correo) && !bd1.ExisteTel(tel))
            {
                Nombre = nombre;
                Apellido = apellido;
                Correo = correo;
                Tel = tel;
                bd1.AgregarCliente(this);
            }
            else
            {
                Console.WriteLine("Correo o Telefono ya ocupado");
            }
        }
    }
}