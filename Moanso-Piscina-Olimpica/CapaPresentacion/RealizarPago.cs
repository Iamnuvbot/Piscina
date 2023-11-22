using CapaEntidad;
using CapaLogica;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Moanso_Piscina
{
    public partial class RealizarPago : Form
    {
        static int idBoleta = 0;
        public RealizarPago()
        {
            InitializeComponent();
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            string MetododePago = cbBMetododePago.SelectedItem.ToString();
            double Monto = (double)monto.Value;
            string Fecha = fechaBox.Value.ToString();
            string TipoServicio = cbBTipoServicio.SelectedItem.ToString();
            string DNI = textBox_DNI.Text;
            entBoleta ultimo = logBoleta.Instancia.ListarBoletas().LastOrDefault();
            if (ultimo != null)
            {
                idBoleta = ultimo.idBoleta;
            }
            idBoleta++;
            entBoleta boleta = new entBoleta();
            boleta.DNI = DNI;
            boleta.MetododePago = MetododePago;
            boleta.Monto = Monto;
            boleta.Fecha = Fecha;
            boleta.TipoServicio = TipoServicio;
            boleta.idBoleta = idBoleta;
            logBoleta.Instancia.InsertarBoleta(boleta);
            SetDtgv();
            richTextBox_MostrarBoleta.Text = $"BOLETA EMITIDA EXITOSAMENTE\n" +
                $"DNI: {boleta.DNI}\n" +
                $"FECHA:{boleta.Fecha}\n" +
                $"METODO DE PAGO: {boleta.MetododePago}\n" +
                $"TIPO DE SERVICIO: {boleta.TipoServicio}\n" +
                $"MONTO TOTAL: {boleta.Monto}";
        }
        private void SetDtgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = logBoleta.Instancia.ListarBoletas();
        }
        private void SetDtgvdni(string DNI)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = logBoleta.Instancia.BuscarBoletas(DNI);
        }
        private void btn_BuscarBoletas_Click(object sender, EventArgs e)
        {
            string BuscarDNI = textBox_DNIBuscar.Text;
            SetDtgvdni(BuscarDNI);

        }
        private void btn_AnularBoletas_Click(object sender, EventArgs e)
        {
            logBoleta.Instancia.AnularBoleta(valorFecha);
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int fila = e.RowIndex;

            // Obtener el valor de la primera columna de la fila seleccionada
            string valor = dataGridView1.Rows[fila].Cells[2].Value.ToString();

            // Mostrar el valor en un MessageBox o hacer lo que quieras con él
            valorFecha = valor;
        }
        private string valorFecha = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Obtener el índice de la fila seleccionada
            int fila = e.RowIndex;

            // Obtener el valor de la primera columna de la fila seleccionada
            string valor = dataGridView1.Rows[fila].Cells[2].Value.ToString();

            // Mostrar el valor en un MessageBox o hacer lo que quieras con él
            valorFecha = valor;
        }
    }
}
