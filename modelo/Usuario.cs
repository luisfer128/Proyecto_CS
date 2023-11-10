namespace modelo
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string Rol { get; set; }
        public string direccion { get; set; }
        public int id { get; set; }
        public string telefono { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string contraseña, string rol, string direccion, int id, string telefono)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.Rol = rol;
            this.direccion = direccion;
            this.id = id;
            this.telefono = telefono;
        }
    }
}