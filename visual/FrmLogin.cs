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
            string contrase�a = txtPass.Text.Replace(" ", "");


            if (manejador.ValidateLogin(usuario, contrase�a))
            {
                this.Hide();
                int id_usuario = manejador.ObtenerDatosUsuario(usuario, contrase�a).Key;
                string tipoUsuario = manejador.ObtenerDatosUsuario(usuario, contrase�a).Value;

                FrmMenu menu = new(id_usuario, tipoUsuario);

                MessageBox.Show("Logeo exitoso \nUsted ingres� como: " + tipoUsuario);

                menu.ShowDialog();
                txtUser.Text = "";
                txtPass.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrase�a incorrectos.");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            manejador.AggAdmin();
        }
    }
}