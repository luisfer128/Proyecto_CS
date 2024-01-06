using System.Globalization;

namespace ModuloServicios.__obj
{
    public class Productos
    {
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public string Descripcion { get; set; }

        public Productos() { }

        public Productos(string Nombre, decimal Valor, string Descripcion)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
            this.Descripcion = Descripcion;
        }

    }
}
