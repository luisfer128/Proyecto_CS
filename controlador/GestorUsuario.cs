using modelo;

namespace controlador
{
    public class GestorUsuario
    {

        // Lista para almacenar usuarios
        private static GestorUsuario instancia;
        public List<Usuario> users = new List<Usuario>();
        private GestorLogs gestorLogs = new GestorLogs();

        private GestorUsuario(){}

        public static GestorUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorUsuario();
                }
                return instancia;
            }
        }

        //Asigna un Rol y se guarda un log de quien asigno el rol o lo modifico
        public void AsignarRol(Usuario usuario, string nombreRol, string mod)
        {
            if (nombreRol == "admin")
            {
                usuario.Rol = new Rol("admin", "permisos_admin");
            }
            else if (nombreRol == "supervisor")
            {
                usuario.Rol = new Rol("supervisor", "permisos_supervisor");
            }
            else if (nombreRol == "trabajador")
            {
                usuario.Rol = new Rol("trabajador", "permisos_trabajador");
            }
            else if (nombreRol == "estudiante")
            {
                usuario.Rol = new Rol("estudiante", "permisos_estudiante");
            }

            gestorLogs.RegistrarLog(mod, $"Asignó el rol {nombreRol} al usuario {usuario}");
        }

        public void AgregarUsuario(Usuario usuario)
        {
            users.Add(usuario);
        }


        //------------Dato de prueba------------//
        public void AggAdmin()
        {
            Usuario admin = new("admin", "admin", new Rol("admin", "permisos_admin"), "Guayaquil", 00001, "0959998165");
            AgregarUsuario(admin);
        }
    }
}