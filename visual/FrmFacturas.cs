using controlador;
using ModuloFacturacion;

namespace visual
{
    public partial class FrmFacturas : Form
    {
        private readonly IFacturaCRUD facturaCRUD = new FacturaCRUD();
        private readonly ManejadorCRUD manejadorCRUD;
        private string IdUsuario;
        public FrmFacturas(string IdUsuario)
        {
            InitializeComponent();
            manejadorCRUD = new ManejadorCRUD(facturaCRUD);
            this.IdUsuario = IdUsuario;
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manejadorCRUD.ObtenerDetallesFacturaPorUsuario(IdUsuario);
        }
    }
}
