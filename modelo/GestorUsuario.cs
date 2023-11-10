using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class GestorUsuario
    {
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
            if (nombreRol == "admin")
            {
                usuario.Rol = "Admin";
            }
            else if (nombreRol == "supervisor")
            {
                usuario.Rol = "Supervisor";
            }
            else if (nombreRol == "trabajador")
            {
                usuario.Rol = "Trabajador";
            }
            else if (nombreRol == "estudiante")
            {
                usuario.Rol = "Estudiante";
            }

        }

        public void AgregarUsuario(Usuario usuario)
        {
            users.Add(usuario);
        }


        //------------Dato de prueba------------//
        public void AggAdmin()
        {
            Usuario admin = new("admin", "admin", "Admin", "Guayaquil", 00001, "0959998165");
            AgregarUsuario(admin);
        }
    }
}
