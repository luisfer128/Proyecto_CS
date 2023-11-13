using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad
{
    public interface IGestorLogin
    {
        Usuario Login(string usuario, string contraseña);
    }
}
