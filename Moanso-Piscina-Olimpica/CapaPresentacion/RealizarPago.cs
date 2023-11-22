using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Moanso_Piscina
{
    public partial class RealizarPago : Form
    {
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
        }

        private void btn_BuscarBoletas_Click(object sender, EventArgs e)
        {
            string BuscarDNI = textBox_DNIBuscar.Text;
        }

        private void btn_AnularBoletas_Click(object sender, EventArgs e)
        {

        }
    }
}
