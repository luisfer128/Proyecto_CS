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
    public partial class FrmMenu : Form
    {
        readonly string id_Usuario;
        private Form form = null;

        public FrmMenu(string id_Usuario, string tipoUsuario)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            HideExtraOptions();
            ShowExtraOptionsForUser(tipoUsuario);
        }

        private void ShowExtraOptionsForUser(string tipoUsuario)
        {
            personalToolStripMenuItem.Visible = (tipoUsuario == "Admin");
            automatizacionDeCalculoToolStripMenuItem.Visible = (tipoUsuario == "Admin" || tipoUsuario == "Supervisor" || tipoUsuario == "Trabajador");
            facturaciónToolStripMenuItem.Visible = (tipoUsuario == "Admin" || tipoUsuario == "Trabajador");
        }

        private void HideExtraOptions()
        {
            personalToolStripMenuItem.Visible = false;
            automatizacionDeCalculoToolStripMenuItem.Visible = false;
            facturaciónToolStripMenuItem.Visible = false;
        }

        private void CambiarContenido(Form nuevoFormulario)
        {
            // Verifica si ya hay un formulario mostrándose y ciérralo
            if (this.panel.Controls.Count > 0)
            {
                this.panel.Controls.Clear();
            }

            // Ajusta el tamaño y la ubicación del formulario secundario para que encaje en el Panel
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;

            // Agrega el formulario secundario al Panel
            this.panel.Controls.Add(nuevoFormulario);

            // Muestra el nuevo formulario
            nuevoFormulario.Show();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContenido(new EliminarRegistro());
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContenido(new ActualizarRegistro());
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContenido(new NuevoRegistro());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
