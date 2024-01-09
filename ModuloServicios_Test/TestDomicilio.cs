using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuloServicios;

namespace ModuloServicios.Tests
{
    [TestClass]
    public class DomicilioCRUDTests
    {
        [TestMethod]
        public void AgregarDomicilio_DeberiaAgregarDomicilioYDevolverId()
        {
            // Arrange
            string idUsuario = "3";
            string calle = "Calle Ejemplo";
            string estado = "Estado Ejemplo";
            string ciudad = "Ciudad Ejemplo";
            string pais = "Pais Ejemplo";
            string codigoPostal = "12345";

            DomicilioCRUD domicilioCRUD = new DomicilioCRUD();

            // Act
            int idDomicilio = domicilioCRUD.AgregarDomicilio(idUsuario, calle, estado, ciudad, pais, codigoPostal);

            // Assert
            Assert.IsTrue(idDomicilio > 0, "Se esperaba un valor de Id_Domicilio mayor a 0");
        }
    }
}
