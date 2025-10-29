using NUnit.Framework;
using System;
using Library;

namespace LibraryTests
{
    [TestFixture]
    public class UsuarioTests
    {
        [Test]
        public void CrearUsuario_ConNombreYApellidoValidos_NoLanzaExcepcion()
        {
            var usuario = new Usuario("", "");

            Assert.That(usuario.Nombre, Is.EqualTo("Juan"));
            Assert.That(usuario.Apellido, Is.EqualTo("Pérez"));
        }

        [TestCase("", "Pérez")]
        [TestCase("Juan", "")]
        [TestCase(" ", "Gómez")]
        [TestCase("Carlos", " ")]
        public void CrearUsuario_ConNombreOVacio_DeberiaLanzarExcepcion(string nombre, string apellido)
        {
            Assert.Throws<ArgumentException>(() => new Usuario(nombre, apellido));
        }
    }
}