using controlador;
using Microsoft.VisualBasic.ApplicationServices;
using ModuloRegistro;
using ModuloSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual
{
    public partial class ActualizarRegistro : Form
    {
        private readonly IOperacionesCRUD operacionesCRUD = new OperacionesCRUD();
        private readonly ManejadorCRUD manejadorCRUD;

        public ActualizarRegistro()
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(operacionesCRUD);
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarRegistro ar = new ActualizarRegistro();
            ar.ShowDialog();
            this.Show();
        }

        private void ActualizarRegistro_Load(object sender, EventArgs e)
        {
            LlenarCB();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                manejadorCRUD.ActualizarUsuario(cmbUsuario.SelectedValue.ToString(), txtNombre.Text, txtApellido.Text, cmbRol.Text, txtCorreo.Text, Estado(), txtNumero.Text);
                if (manejadorCRUD != null)
                {
                    MessageBox.Show("Usuario actualizado correctamente");
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void LlenarCB()
        {
            List<Usuario> selectuser = operacionesCRUD.SelectUsuarios();

            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.ValueMember = "id";
            cmbUsuario.DataSource = selectuser;

            if (selectuser.Count > 0)
            {
                cmbUsuario.SelectedIndex = 0;
            }
        }

        private void LlenarDatos()
        {
            List<Usuario> selectuser = operacionesCRUD.SelectUsuarios();

            foreach (Usuario usuario in selectuser)
            {
                if (usuario.id == cmbUsuario.SelectedValue.ToString())
                {
                    txtNombre.Text = usuario.nombre;
                    txtApellido.Text = usuario.apellido;
                    txtCorreo.Text = usuario.direccion;
                    txtNumero.Text = usuario.telefono;
                    cmbRol.Text = usuario.rol;
                    if (usuario.estado == 'A')
                    {
                        chbEstado.Checked = true;
                    }
                    else
                    {
                        chbEstado.Checked = false;
                    }
                }
            }

        }

        private char Estado()
        {
            if (chbEstado.Checked == true)
            {
                return 'A';
            }
            else
            {
                return 'I';
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //VALIDACIONES
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verificar si la longitud del texto supera el límite de 10 caracteres
            if (textBox.Text.Length > 10)
            {
                textBox.Text = textBox.Text.Substring(0, 10);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
