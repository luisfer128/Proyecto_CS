using controlador;
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
    public partial class FrmPago : Form
    {
        private readonly ICarritoCRUD carritoCRUD = new CarritoCRUD();
        private readonly IDomicilioCRUD domicilioCRUD = new DomicilioCRUD();
        private readonly ManejadorCRUD manejadorCRUD;
        private readonly ManejadorCRUD manejador2CRUD;
        string IdUsuario;
        int IdMetodoPago;
        decimal total;

        public FrmPago(string IdUsuario, int IdMetodoPago, decimal total)
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(carritoCRUD);
            manejador2CRUD = new ManejadorCRUD(domicilioCRUD);
            this.IdUsuario = IdUsuario;
            this.IdMetodoPago = IdMetodoPago;
            this.total = total;
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            int Id_domicilio = manejador2CRUD.AgregarDomicilio(IdUsuario, TxtCalle.Text, TxtEstado.Text, TxtCiudad.Text, CmbPais.Text, TxtCP.Text);
            int Id_OrdePago = manejadorCRUD.InsertarOrdenPago(IdUsuario, Id_domicilio, IdMetodoPago, total);
            DataTable dt = manejadorCRUD.ObtenerProductosDelCarrito(IdUsuario);

            try 
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int Id_Producto, Cantidad;

                    if (int.TryParse(dt.Rows[i]["Id_Producto"].ToString(), out Id_Producto) &&
                        int.TryParse(dt.Rows[i]["Cantidad"].ToString(), out Cantidad))
                    {
                        // Procede con la inserción en la orden de pago
                        int Id_detallePago = manejadorCRUD.InsertarDetalleOrdenPago(Id_OrdePago, Id_Producto, Cantidad);
                        manejadorCRUD.InsertarFactura(Id_detallePago, DateTime.UtcNow, "Pagado");
                    }
                    else
                    {
                        // Manejar el caso en que la conversión no fue exitosa
                        MessageBox.Show("Error al convertir valores para Id_Producto o Cantidad en la fila " + i);
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("No puede contener campos vacíos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Compra exitosa");
            this.Close();
        }

        //VALIDACIONES
        private void TxtNombreTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void TxtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || TxtNumeroTarjeta.Text.Length >= 16 && e.KeyChar != 8)
            {
                MessageBox.Show("Escriba solo hasta 16 números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void TxtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || TxtCVV.Text.Length >= 3 && e.KeyChar != 8)
            {
                MessageBox.Show("Escriba solo tres números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

    }
}
