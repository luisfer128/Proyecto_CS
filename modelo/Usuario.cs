namespace ModuloSeguridad
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contraseña { get; set; }
        public string Rol { get; set; }
        public string direccion { get; set; }
        public string id { get; set; }
        public string telefono { get; set; }
        public char estado { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string apellido, string contraseña, string rol, string direccion, string id, string telefono, char estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.Rol = rol;
            this.direccion = direccion;
            this.id = id;
            this.telefono = telefono;
            this.estado = estado;
        }
    }
}