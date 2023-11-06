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
            string contraseña = txtPass.Text;


            if (login.ValidateLogin(usuario, contraseña))
            {
                this.Hide();
                int id_usuario = login.ObtenerDatosUsuario(usuario, contraseña).Key;
                string tipoUsuario = login.ObtenerDatosUsuario(usuario, contraseña).Value;

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
                MessageBox.Show(login.PRUEBA());
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            gestorUsuario.AggAdmin();
        }
    }
}