using ModuloRegistro;
using ModuloSeguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class ManejadorCRUD
    {
        private readonly IOperacionesCRUD operacionesCRUD;

        public ManejadorCRUD(IOperacionesCRUD operacionesCRUD)
        {
            this.operacionesCRUD = operacionesCRUD;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            operacionesCRUD.AgregarUsuario(usuario);
        }

        public void ActualizarUsuario(string id_usuario, string nombre, string apellido, string contraseña, string rol, string direccion,char estado, string telefono)
        {
            operacionesCRUD.ActualizarUsuario(id_usuario, nombre, apellido, contraseña, rol, direccion, estado, telefono);
        }

        public void EliminarUsuario(string idUsuario)
        {
            operacionesCRUD.EliminarUsuario(idUsuario);
        }

        public List<Usuario> SelecUsuarios()
        {
            return operacionesCRUD.SelectUsuarios();
        }
    }
}
