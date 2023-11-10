using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class Manejador
    {
        private readonly GestorLogin login = new GestorLogin();
        private readonly GestorUsuario gestorUsuario = GestorUsuario.Instancia;

        public bool ValidateLogin(string usuario, string contraseña)
        {
            return login.ValidateLogin(usuario, contraseña);
        }

        public KeyValuePair<int, string> ObtenerDatosUsuario(string usuario, string contraseña)
        {
            return login.ObtenerDatosUsuario(usuario, contraseña);
        }

        public void AggAdmin()
        {
            gestorUsuario.AggAdmin();
        }
    }  
}
