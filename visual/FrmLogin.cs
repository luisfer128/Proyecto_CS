using controlador;

namespace visual
{
    public partial class FrmLogin : Form
    {
        private readonly Login login = new Login();
        private readonly GestorUsuario gestorUsuario = GestorUsuario.Instancia; 
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrase�a = txtPass.Text;


            if (login.ValidateLogin(usuario, contrase�a))
            {
                this.Hide();
                int id_usuario = login.ObtenerDatosUsuario(usuario, contrase�a).Key;
                string tipoUsuario = login.ObtenerDatosUsuario(usuario, contrase�a).Value;

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
                MessageBox.Show(login.PRUEBA());
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            gestorUsuario.AggAdmin();
        }
    }
}