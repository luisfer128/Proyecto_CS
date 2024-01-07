using ModuloRegistro;
using ModuloSeguridad.__obj;
using ModuloServicios;
using System.Data;

namespace controlador
{
    public class ManejadorCRUD
    {
        private readonly IOperacionesCRUD operacionesCRUD;
        private readonly ICarritoCRUD carritoCRUD; 

        public ManejadorCRUD(IOperacionesCRUD operacionesCRUD)
        {
            this.operacionesCRUD = operacionesCRUD;
        }

        public ManejadorCRUD(ICarritoCRUD carritoCRUD)
        {
            this.carritoCRUD = carritoCRUD;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            operacionesCRUD.AgregarUsuario(usuario);
        }

        public void ActualizarUsuario(string id_usuario, string nombre, string apellido, string rol, string direccion,char estado, string telefono)
        {
            operacionesCRUD.ActualizarUsuario(id_usuario, nombre, apellido, rol, direccion, estado, telefono);
        }

        public void EliminarUsuario(string idUsuario)
        {
            operacionesCRUD.EliminarUsuario(idUsuario);
        }

        public List<Usuario> SelecUsuarios()
        {
            return operacionesCRUD.SelectUsuarios();
        }

        public void AgregarServicio(string Idusuario, int IdProducto, int Cantidad)
        {
            carritoCRUD.AgregarServicio(Idusuario,IdProducto,Cantidad);
        }

        public void EliminarServicio(string IdUsuario, int IdProducto)
        {
            carritoCRUD.EliminarServicio(IdUsuario, IdProducto);
        }

        public DataTable ObtenerProductosDelCarrito(string IdUsuario)
        {
            return carritoCRUD.ObtenerProductosDelCarrito(IdUsuario);
        }

        public int ObtenerCantidadProductoEnCarrito(string IdUsuario, int IdProducto)
        {
            return carritoCRUD.ObtenerCantidadProductoEnCarrito(IdUsuario, IdProducto);
        }

        public decimal ObtenerValorTotalCarrito(string IdUsuario)
        {
            return carritoCRUD.ObtenerValorTotalCarrito(IdUsuario);
        }

        public void VaciarCarrito(string IdUsuario)
        {
            carritoCRUD.VaciarCarrito(IdUsuario);
        }
    }
}
