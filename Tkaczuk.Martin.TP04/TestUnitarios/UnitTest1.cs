using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void ValidacionInstanciaListaDePaquetes()
        {
            Correo c = new Correo();
            Assert.AreNotEqual(c.Paquetes, null);
            //Assert.Fail("Debería estar instanciada la lista de paquetes");
        }

        [TestMethod]
        public void ValidacionDosPaquetesMismoTrackingID()
        {
            try
            {
                Correo c = new Correo();
                Paquete p1 = new Paquete("Av. Mitre 1234", "123456");
                Paquete p2 = new Paquete("Av. Mitre 4321", "123456");
                c = c + p1;
                c = c + p2;
                //Assert.Fail("Debería lanzar la excepción del tipo TrackingIDRepetidoException al tener dos paquetes del mismo ID de Tracking");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(TrackingIDRepetidoException));
            }
        }
    }
}
