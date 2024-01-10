using controlador;
using ModuloRegistro;
using ModuloSeguridad.__obj;
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
    public partial class NuevoRegistro : Form
    {
        private readonly IOperacionesCRUD operacionesCRUD = new OperacionesCRUD();
        private readonly ManejadorCRUD manejadorCRUD;

        public NuevoRegistro()
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(operacionesCRUD);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cedula;

            try
            {
                if (manejadorCRUD.ValidarCedula(txtCedula.Text))
                {
                    cedula = txtCedula.Text;
                }
                else
                {
                    throw new Exception();
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                        string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                        string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) ||
                        string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    throw new SystemException();
                }

                manejadorCRUD.AgregarUsuario(new Usuario(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, cmbRol.Text, txtCorreo.Text, txtCedula.Text, txtNumero.Text, 'A'));
                if (manejadorCRUD != null)
                {
                    MessageBox.Show("Usuario registrado exitosamente");
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Cedula o usuario ya registrado");
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show("No puede contener campos vacíos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese una cédula valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verificar si la longitud del texto supera el límite de 10 caracteres
            if (textBox.Text.Length > 10)
            {
                textBox.Text = textBox.Text.Substring(0, 10);
                textBox.SelectionStart = textBox.Text.Length;
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
