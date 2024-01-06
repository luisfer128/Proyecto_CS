using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios.__obj
{
    public class OrdenPago
    {
        public string IdUsuario { get; set; }
        public int IdDomicilio { get; set; }
        public int IdPago { get; set; }
        public decimal Total { get; set; }
        public int IdFactura { get; set; }

        public OrdenPago() { }

        public OrdenPago(string IdUsuario, int IdDomicilio, int IdPago, decimal Total, int IdFactura)
        {
            this.IdUsuario = IdUsuario;
            this.IdDomicilio = IdDomicilio;
            this.IdPago = IdPago;
            this.Total = Total;
            this.IdFactura = IdFactura;
        }
    }
}
