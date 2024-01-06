using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios.__obj
{
    public class Factura
    {
        public int IdOrdenPago { get; set; }
        public DateTime FechaEmision { get; set; }
        public string EstadoPago { get; set; }

        public Factura() { }

        public Factura(int IdOrdenPago, DateTime FechaEmision, string EstadoPago)
        {
            this.IdOrdenPago = IdOrdenPago;
            this.FechaEmision = FechaEmision;
            this.EstadoPago = EstadoPago;
        }
    }
}
