using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class Login
    {
        // Lista para almacenar usuarios
        private List<Usuario> users = new List<Usuario>();

        // Método para agregar usuarios a la lista
        public void AgregarUsuario(Usuario usuario)
        {
            users.Add(usuario);
        }

        // Método para validar el inicio de sesión
        public bool ValidateLogin(string usuario, string contraseña)
        {
            // Itera sobre la lista de usuarios y verifica si las credenciales coinciden
            foreach (Usuario user in users)
            {
                if (user.nombre == usuario && user.contraseña == contraseña)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
