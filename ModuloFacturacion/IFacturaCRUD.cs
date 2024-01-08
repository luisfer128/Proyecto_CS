using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacion
{
    public interface IFacturaCRUD
    {
        public DataTable ObtenerDetallesFacturaPorUsuario(string IdUsuario);
    }
}
