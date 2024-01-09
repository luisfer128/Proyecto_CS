using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuloFacturacion;

namespace ModuloFacturacion.Tests
{
    [TestClass]
    public class FacturaCRUDTests
    {
        [TestMethod]
        public void ObtenerDetallesFacturaPorUsuario_DeberiaObtenerDatos()
        {
            // Arrange
            string idUsuario = "1";
            FacturaCRUD facturaCRUD = new FacturaCRUD();

            // Act
            var detallesFactura = facturaCRUD.ObtenerDetallesFacturaPorUsuario(idUsuario);

            // Assert
            Assert.IsNotNull(detallesFactura, "El resultado de la factura no debería ser nulo");
            Assert.IsTrue(detallesFactura.Rows.Count > 0, "Se esperaba al menos una fila en el resultado");
            // Puedes agregar más aserciones según la estructura de tu resultado esperado.
        }
    }
}
