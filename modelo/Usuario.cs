namespace modelo
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public Rol Rol { get; set; }
        public string direccion { get; set; }
        public int id { get; set; }
        public string telefono { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string contraseña, Rol rol, string direccion, int id, string telefono)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            Rol = rol;
            this.direccion = direccion;
            this.id = id;
            this.telefono = telefono;
        }
    }
}