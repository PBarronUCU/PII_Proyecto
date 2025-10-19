#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System;
namespace Library
{
    public interface IInteracion
    {
        DateTime Fecha { get; set; }
        String Tema { get; set; }
        String Notas { get; set; }
        int TelCliente { get; }
    }
}