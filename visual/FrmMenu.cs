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
        }
    }
}
