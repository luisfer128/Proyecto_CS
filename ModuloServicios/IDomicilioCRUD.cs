using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios
{
    public interface IDomicilioCRUD
    {
        public int AgregarDomicilio(string Idusuario, string Calle, string Estado, string Ciudad, string Pais, string CodigoPostal);
    }
}
