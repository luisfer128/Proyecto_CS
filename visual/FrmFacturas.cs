using controlador;
using ModuloFacturacion;
using System.Drawing.Printing;

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
            dgvver.DataSource = manejadorCRUD.ObtenerDetallesFacturaPorUsuario(IdUsuario);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true; // Configurar la orientación a horizontal
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 25; // Reducir el alto de las filas
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                // Encabezados
                foreach (DataGridViewColumn col in dgvver.Columns)
                {
                    // Calcular el ancho del encabezado considerando el ancho de la columna
                    float headerWidth = ep.Graphics.MeasureString(col.HeaderText, new Font("Segoe UI", 9, FontStyle.Bold)).Width;

                    // Ajustar el ancho de la columna si es necesario
                    float adjustedColumnWidth = Math.Max(col.Width, headerWidth) + 5; // Agregar un espacio adicional

                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += (int)adjustedColumnWidth;

                    if (col.Index < dgvver.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 2, top, left - 2, top + DGV_ALTO);
                }

                left = ep.MarginBounds.Left;
                top += DGV_ALTO;

                // Línea horizontal después de encabezados
                ep.Graphics.FillRectangle(Brushes.Black, left, top, left + left + ep.MarginBounds.Right, 3);
                top += 4;

                // Contenido
                foreach (DataGridViewRow row in dgvver.Rows)
                {
                    if (row.Index == dgvver.RowCount - 1) break;

                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Ajuste de tamaño de fuente para que quepa en la celda
                        float fontSize = 6; // Reducir el tamaño de la fuente

                        // Alineación de datos centrada verticalmente
                        float y = top + (DGV_ALTO - ep.Graphics.MeasureString(Convert.ToString(cell.Value), new Font("Segoe UI", fontSize)).Height) / 2;

                        // Ajustar la altura de la fila si es necesario
                        float cellHeight = Math.Max(DGV_ALTO, ep.Graphics.MeasureString(Convert.ToString(cell.Value), new Font("Segoe UI", fontSize)).Height);

                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", fontSize), Brushes.Black, left, y);

                        left += cell.OwningColumn.Width;
                    }

                    top += (int)DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, left + ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }




    }
}
