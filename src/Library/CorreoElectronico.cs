using System;

namespace Library
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

{
    public class CorreoElectronico : IInteracion
    {
        public DateTime Fecha { get; set; }
        public string Tema { get; set; }
        public string Notas { get; set; }
        public int TelCliente { get; }
        public UsuarioOCliente Remitente {get; set;}
    }
}