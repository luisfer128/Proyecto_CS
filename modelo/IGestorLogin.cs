using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloSeguridad.__obj;

namespace ModuloSeguridad
{
    public interface IGestorLogin
    {
        Usuario Login(string usuario, string contraseña);
    }
}
