﻿using System;
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
        public ActualizarRegistro()
        {
            InitializeComponent();
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarRegistro ar = new ActualizarRegistro();
            ar.ShowDialog();
            this.Show();
        }
    }
}
