using controlador;
using ModuloRegistro;
using ModuloSeguridad.__obj;
using ModuloServicios;

namespace visual
{
    public partial class FrmServicios : Form
    {
        private readonly ICarritoCRUD carritoCRUD = new CarritoCRUD();
        private readonly ManejadorCRUD manejadorCRUD;
        private string IdUsuario;

        public FrmServicios(string IdUsuario)
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(carritoCRUD);
            this.IdUsuario = IdUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(manejadorCRUD.ObtenerCantidadProductoEnCarrito(IdUsuario, 1) == 0)
                {
                    manejadorCRUD.AgregarServicio(IdUsuario, 1, 1);
                    MessageBox.Show("Se agrego al carrito!");
                }
                else
                {
                    MessageBox.Show("Este producto ya se encuentra en el carrito!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (manejadorCRUD.ObtenerCantidadProductoEnCarrito(IdUsuario, 2) == 0)
                {
                    manejadorCRUD.AgregarServicio(IdUsuario, 2, 1);
                    MessageBox.Show("Se agrego al carrito!");
                }
                else
                {
                    MessageBox.Show("Este producto ya se encuentra en el carrito!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (manejadorCRUD.ObtenerCantidadProductoEnCarrito(IdUsuario, 3) == 0)
                {
                    manejadorCRUD.AgregarServicio(IdUsuario, 3, 1);
                    MessageBox.Show("Se agrego al carrito!");
                }
                else
                {
                    MessageBox.Show("Este producto ya se encuentra en el carrito!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
