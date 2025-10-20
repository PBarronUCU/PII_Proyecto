using System;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member


namespace Library
{
    public class Reunion : IInteracion
    {
        public DateTime Fecha { get; set; }
        public string Tema { get; set; }
        public string Notas { get; set; }
        public int TelCliente { get; }
        public Reunion(string tema, string notas, DateTime fecha, int telCliente)
        {
            
            Tema = tema;
            Notas = notas;
            Fecha = fecha;
            TelCliente = telCliente;
        }
    }
}