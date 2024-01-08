using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios
{
    public interface ICarritoCRUD
    {
        void AgregarServicio(string IdUsuario, int IdProducto, int Cantidad);
        void EliminarServicio(string IdUsuario, int IdProducto);
        public void VaciarCarrito(string IdUsuario);
        DataTable ObtenerProductosDelCarrito(string IdUsuario);
        public int ObtenerCantidadProductoEnCarrito(string IdUsuario, int IdProducto);
        public decimal ObtenerValorTotalCarrito(string IdUsuario);
        public int InsertarOrdenPago(string IdUsuario, int IdDomicilio, int IdPago, decimal Total);
        public int InsertarDetalleOrdenPago(int IdOrdenPago, int IdProducto, int Cantidad);
        public void InsertarFactura(int IdDetalleOrdenPago, DateTime FechaEmision, string EstadoPago);
    }
}
