﻿using controlador;
using ModuloServicios;
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
    public partial class FrmCarrito : Form
    {
        private readonly ICarritoCRUD carritoCRUD = new CarritoCRUD();
        private readonly ManejadorCRUD manejadorCRUD;
        private string IdUsuario;

        public FrmCarrito(string IdUsuario)
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(carritoCRUD);
            this.IdUsuario = IdUsuario;
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manejadorCRUD.ObtenerProductosDelCarrito(IdUsuario);
            label3.Text = manejadorCRUD.ObtenerValorTotalCarrito(IdUsuario).ToString() + "$";
            if (dataGridView1.Rows.Count == 0)
            {
                BtnPagar.Enabled = false;
            }
        }

        private void BtnVaciarCarrito_Click(object sender, EventArgs e)
        {
            manejadorCRUD.VaciarCarrito(IdUsuario);
            dataGridView1.DataSource = manejadorCRUD.ObtenerProductosDelCarrito(IdUsuario);
            label3.Text = manejadorCRUD.ObtenerValorTotalCarrito(IdUsuario).ToString() + "$";
            if (dataGridView1.Rows.Count == 0)
            {
                BtnPagar.Enabled = false;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            decimal total = manejadorCRUD.ObtenerValorTotalCarrito(IdUsuario);
            int IdMetodoPago = 1;

            if (radioButton1.Checked)
            {
                IdMetodoPago = 1;
            }else if (radioButton2.Checked)
            {
                IdMetodoPago = 2;
            }

            FrmPago pago = new(IdUsuario, IdMetodoPago, total);
            pago.ShowDialog();
            pago.Close();
            manejadorCRUD.VaciarCarrito(IdUsuario);
            dataGridView1.DataSource = manejadorCRUD.ObtenerProductosDelCarrito(IdUsuario);
            label3.Text = manejadorCRUD.ObtenerValorTotalCarrito(IdUsuario).ToString() + "$";
        }
    }
}
