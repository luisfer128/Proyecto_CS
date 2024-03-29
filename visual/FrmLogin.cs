using controlador;
using ModuloSeguridad;
using ModuloSeguridad.__obj;

namespace visual
{
    public partial class FrmLogin : Form
    {
        private readonly IGestorLogin gestorLogin = new GestorLogin();
        private readonly Manejador manejador;

        public FrmLogin()
        {
            InitializeComponent();
            manejador = new Manejador(gestorLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Replace(" ", "");
            string contraseña = txtPass.Text.Replace(" ", "");

            Usuario usuarioAutenticado = manejador.Login(usuario, contraseña);

            if (usuarioAutenticado != null)
            {
                this.Hide();
                string id_usuario = usuarioAutenticado.id;
                string tipoUsuario = usuarioAutenticado.rol;

                FrmMenu menu = new FrmMenu(id_usuario, tipoUsuario);

                MessageBox.Show("Logeo exitoso \nUsted ingresa como: " + tipoUsuario);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarCliente frmRegistrarCliente = new FrmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();
            frmRegistrarCliente.Close();
            frmRegistrarCliente.Dispose();
            GC.Collect();
        }

        private void llRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarContraseña frmRecuperarContraseña = new FrmRecuperarContraseña();
            frmRecuperarContraseña.ShowDialog();
            frmRecuperarContraseña.Close();
            frmRecuperarContraseña.Dispose();
            GC.Collect();
        }
    }
}