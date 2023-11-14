using controlador;
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
    public partial class EliminarRegistro : Form
    {
        private readonly IOperacionesCRUD operacionesCRUD = new OperacionesCRUD();
        private readonly ManejadorCRUD manejadorCRUD;

        public EliminarRegistro()
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(operacionesCRUD);
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarRegistro er = new EliminarRegistro();
            er.ShowDialog();
            this.Show();
        }

        private void LlenarCB()
        {
            List<Usuario> selectuser = operacionesCRUD.SelectUsuarios();

            cmbPerfil.DisplayMember = "usuario";
            cmbPerfil.ValueMember = "id";
            cmbPerfil.DataSource = selectuser;

            if (selectuser.Count > 0)
            {
                cmbPerfil.SelectedIndex = 0;
            }
        }

        private void EliminarRegistro_Load(object sender, EventArgs e)
        {
            LlenarCB();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnEliminar.Enabled = true;

            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                manejadorCRUD.EliminarUsuario(cmbPerfil.SelectedValue.ToString());
                if (manejadorCRUD != null)
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
