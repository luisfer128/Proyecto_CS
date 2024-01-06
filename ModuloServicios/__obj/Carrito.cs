using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios.__obj
{
    public class Carrito
    {
        public string IdUsuario { get; set; }
        public int Cantidad { get; set; }

        public Carrito() { }

        public Carrito(string Idusuario, int Cantidad)
        {
            IdUsuario = Idusuario;
            this.Cantidad = Cantidad;
        }

    }
}
