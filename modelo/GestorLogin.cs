using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class GestorLogin
    {
        private readonly GestorUsuario GU = GestorUsuario.Instancia;


        // Método para validar el inicio de sesión
        public bool ValidateLogin(string usuario, string contraseña)
        {
            // Itera sobre la lista de usuarios y verifica si las credenciales coinciden
            foreach (Usuario user in GU.users)
            {
                if (usuario == user.nombre && contraseña == user.contraseña)
                {
                    return true;
                }
            }

            return false;
        }

        public KeyValuePair<int, string> ObtenerDatosUsuario(string usuario, string contraseña)
        {
            int id_usuario = 0;
            string tipoUsuario = "";

            foreach (Usuario user in GU.users)
            {

                if (usuario == user.nombre && contraseña == user.contraseña)
                {
                    id_usuario = user.id;
                    tipoUsuario = user.Rol;
                }
            }

            return new KeyValuePair<int, string>(id_usuario, tipoUsuario);
        }
    }
}
