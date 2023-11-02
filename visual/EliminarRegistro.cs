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
        public EliminarRegistro()
        {
            InitializeComponent();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarRegistro er = new EliminarRegistro();
            er.ShowDialog();
            this.Show();
        }
    }
}
