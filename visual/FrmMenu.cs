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

        public FrmMenu(int id_Usuario, string tipoUsuario)
        {
            InitializeComponent();
            HideExtraOptions();
            ShowExtraOptionsForUser(tipoUsuario);
        }

        private void ShowExtraOptionsForUser(string tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case "Admin":
                    personalToolStripMenuItem.Visible = true;
                    automatizacionDeCalculoToolStripMenuItem.Visible = true;
                    seguridadToolStripMenuItem.Visible = true;
                    facturaciónToolStripMenuItem.Visible= true;
                    break;
                case "Supervisor":
                    automatizacionDeCalculoToolStripMenuItem.Visible = true;
                    personalToolStripMenuItem.Visible = true;
                    break;
                case "Trabajador":
                    automatizacionDeCalculoToolStripMenuItem.Visible = true;
                    facturaciónToolStripMenuItem.Visible = true;
                    break;
                default:
                    automatizacionDeCalculoToolStripMenuItem.Visible = true;
                    break;
            }
        }

        private void HideExtraOptions()
        {
            personalToolStripMenuItem.Visible = false;
            automatizacionDeCalculoToolStripMenuItem.Visible = false;
            seguridadToolStripMenuItem.Visible = false;
            facturaciónToolStripMenuItem.Visible = false;
        }

    }
}
