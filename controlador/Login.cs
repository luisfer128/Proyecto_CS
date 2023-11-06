using modelo;

namespace controlador
{
    public class Login
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

        public string PRUEBA()
        {
            string lista = string.Join(", ", GU.users);
            return lista;
        }

        public KeyValuePair<int, string> ObtenerDatosUsuario(string usuario, string contraseña)
        {
            int id_usuario = 0;
            string tipoUsuario = null;

            foreach (Usuario user in GU.users)
            {

                if (usuario == user.nombre && contraseña == user.contraseña)
                {
                    id_usuario = user.id;
                    tipoUsuario = user.Rol.nombre;
                }
            }

            return new KeyValuePair<int, string>(id_usuario, tipoUsuario);
        }
    }
}
