using controlador;

namespace visual
{
    public partial class FrmLogin : Form
    {
        private readonly Manejador manejador = new Manejador(); 
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Replace(" ", "");
            string contraseña = txtPass.Text.Replace(" ", "");


            if (manejador.ValidateLogin(usuario, contraseña))
            {
                this.Hide();
                int id_usuario = manejador.ObtenerDatosUsuario(usuario, contraseña).Key;
                string tipoUsuario = manejador.ObtenerDatosUsuario(usuario, contraseña).Value;

                FrmMenu menu = new(id_usuario, tipoUsuario);

                MessageBox.Show("Logeo exitoso \nUsted ingresó como: " + tipoUsuario);

                menu.ShowDialog();
                txtUser.Text = "";
                txtPass.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            manejador.AggAdmin();
        }
    }
}