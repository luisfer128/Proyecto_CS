using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Rol
    {
        public string nombre { get; set; }
        public string permisos { get; set; }

        public Rol() { }
        
        public Rol(string nombre, string permisos)
        {
            this.nombre = nombre;
            this.permisos = permisos;
        }

    }
}
