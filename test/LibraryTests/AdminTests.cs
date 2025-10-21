using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    public class AdminTests
    {
        [Test]
        public void CrearYSuspenderUsuario()
        {
            Admin admin1 = new Admin("Carlos");
            admin1.AgregarUsuario("Ana", "Pérez", "ana@mail.com");
            admin1.SuspenderUsuario("ana@mail.com");

            bool existe = BaseDatos.Instance.ExisteCorreo("ana@mail.com");
            Assert.That(existe, Is.True); 
        }
    }
}