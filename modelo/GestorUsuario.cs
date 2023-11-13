using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad
{
    public class GestorUsuario
    {
        public GestorLogs log = new GestorLogs();

        // Lista para almacenar usuarios
        private static GestorUsuario instancia;
        public List<Usuario> users = new List<Usuario>();
        

        private GestorUsuario() { }

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
            if (nombreRol == "Admin")
            {
                usuario.Rol = "Admin";
            }
            else if (nombreRol == "Supervisor")
            {
                usuario.Rol = "Supervisor";
            }
            else if (nombreRol == "Trabajador")
            {
                usuario.Rol = "Trabajador";
            }
            else if (nombreRol == "Estudiante")
            {
                usuario.Rol = "Estudiante";
            }

            log.RegistrarLog(mod, $"Cambio de rol al usuario:{usuario.nombre} a rol: {nombreRol}");
        }

        public void AgregarUsuario(Usuario usuario)
        {
            users.Add(usuario);
        }


        //------------Dato de prueba------------//
        public void AggAdmin()
        {
            Usuario admin = new("admin", "admin", "admin", "Admin", "Guayaquil", "0923671937", "0959998165", 'A');
            AgregarUsuario(admin);
        }
    }
}
