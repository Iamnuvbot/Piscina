﻿using System;
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
            entBoleta boleta = new entBoleta();
            boleta.DNI = DNI;
            boleta.MetododePago = MetododePago;
            boleta.Monto = Monto;
            boleta.Fecha = Fecha;
            boleta.TipoServicio = TipoServicio;
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
        public int valorid;
        private void btn_AnularBoletas_Click(object sender, EventArgs e)
        {

                logBoleta.Instancia.AnularBoleta(valorid);
            SetDtgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                int valorID=Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());
                valorid = valorID;
            }
        }
    }
}
