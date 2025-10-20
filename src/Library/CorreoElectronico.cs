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
        
        public CorreoElectronico(string remitente, string tema, string notas, DateTime fecha, int telCliente)
        {
            Remitente = remitente;
            Tema = tema;
            Notas = notas;
            Fecha = fecha;
            TelCliente = telCliente;
        }
    }
    
}