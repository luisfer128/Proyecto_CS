using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios.__obj
{
    public class Domicilio
    {
        public string IdUsuario { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }

        public Domicilio() { }

        public Domicilio(string IdUsuario, string Calle, string Estado, string Ciudad, string Pais, string CodigoPostal)
        {
            this.IdUsuario = IdUsuario;
            this.Calle = Calle;
            this.Estado = Estado;
            this.Ciudad = Ciudad;
            this.Pais = Pais;
            this.CodigoPostal = CodigoPostal;
        }
    }
}
