using ModuloSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloRegistro
{
    public interface IOperacionesCRUD
    {
        void AgregarUsuario(Usuario nuevoUsuario);
        void ActualizarUsuario(string id_usuario, string nombre, string apellido, string rol, string direccion,char estado, string telefono);
        void EliminarUsuario(string idUsuario);
        List<Usuario> SelectUsuarios();
    }
}
