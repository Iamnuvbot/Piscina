﻿
namespace Moanso_Piscina
{
    partial class RealizarPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPago));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.btnGenerarBoleta = new System.Windows.Forms.Button();
            this.cbBMetododePago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaBox = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBTipoServicio = new System.Windows.Forms.ComboBox();
            this.richTextBox_MostrarBoleta = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_DNIBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarBoletas = new System.Windows.Forms.Button();
            this.btn_AnularBoletas = new System.Windows.Forms.Button();
            this.monto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI";
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(44, 270);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(139, 20);
            this.textBox_DNI.TabIndex = 19;
            // 
            // btnGenerarBoleta
            // 
            this.btnGenerarBoleta.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGenerarBoleta.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarBoleta.Image")));
            this.btnGenerarBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarBoleta.Location = new System.Drawing.Point(9, 311);
            this.btnGenerarBoleta.Name = "btnGenerarBoleta";
            this.btnGenerarBoleta.Size = new System.Drawing.Size(174, 42);
            this.btnGenerarBoleta.TabIndex = 2;
            this.btnGenerarBoleta.Text = "GENERAR BOLETA";
            this.btnGenerarBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarBoleta.UseVisualStyleBackColor = false;
            this.btnGenerarBoleta.Click += new System.EventHandler(this.btnGenerarBoleta_Click);
            // 
            // cbBMetododePago
            // 
            this.cbBMetododePago.FormattingEnabled = true;
            this.cbBMetododePago.Items.AddRange(new object[] {
            "Yape",
            "Efectivo"});
            this.cbBMetododePago.Location = new System.Drawing.Point(4, 63);
            this.cbBMetododePago.Name = "cbBMetododePago";
            this.cbBMetododePago.Size = new System.Drawing.Size(121, 21);
            this.cbBMetododePago.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metodo de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Servicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Monto";
            // 
            // fechaBox
            // 
            this.fechaBox.Location = new System.Drawing.Point(4, 173);
            this.fechaBox.Margin = new System.Windows.Forms.Padding(2);
            this.fechaBox.Name = "fechaBox";
            this.fechaBox.Size = new System.Drawing.Size(198, 20);
            this.fechaBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Fecha";
            // 
            // cbBTipoServicio
            // 
            this.cbBTipoServicio.FormattingEnabled = true;
            this.cbBTipoServicio.Items.AddRange(new object[] {
            "Matricula",
            "Alquiler"});
            this.cbBTipoServicio.Location = new System.Drawing.Point(106, 217);
            this.cbBTipoServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbBTipoServicio.Name = "cbBTipoServicio";
            this.cbBTipoServicio.Size = new System.Drawing.Size(77, 21);
            this.cbBTipoServicio.TabIndex = 37;
            // 
            // richTextBox_MostrarBoleta
            // 
            this.richTextBox_MostrarBoleta.Location = new System.Drawing.Point(223, 47);
            this.richTextBox_MostrarBoleta.Name = "richTextBox_MostrarBoleta";
            this.richTextBox_MostrarBoleta.Size = new System.Drawing.Size(193, 323);
            this.richTextBox_MostrarBoleta.TabIndex = 38;
            this.richTextBox_MostrarBoleta.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(390, 161);
            this.dataGridView1.TabIndex = 39;
            // 
            // textBox_DNIBuscar
            // 
            this.textBox_DNIBuscar.Location = new System.Drawing.Point(575, 214);
            this.textBox_DNIBuscar.Name = "textBox_DNIBuscar";
            this.textBox_DNIBuscar.Size = new System.Drawing.Size(126, 20);
            this.textBox_DNIBuscar.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "DNI";
            // 
            // btn_BuscarBoletas
            // 
            this.btn_BuscarBoletas.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_BuscarBoletas.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarBoletas.Image")));
            this.btn_BuscarBoletas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscarBoletas.Location = new System.Drawing.Point(466, 253);
            this.btn_BuscarBoletas.Name = "btn_BuscarBoletas";
            this.btn_BuscarBoletas.Size = new System.Drawing.Size(136, 37);
            this.btn_BuscarBoletas.TabIndex = 43;
            this.btn_BuscarBoletas.Text = "BUSCAR BOLETAS";
            this.btn_BuscarBoletas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarBoletas.UseVisualStyleBackColor = false;
            this.btn_BuscarBoletas.Click += new System.EventHandler(this.btn_BuscarBoletas_Click);
            // 
            // btn_AnularBoletas
            // 
            this.btn_AnularBoletas.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_AnularBoletas.Image = ((System.Drawing.Image)(resources.GetObject("btn_AnularBoletas.Image")));
            this.btn_AnularBoletas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AnularBoletas.Location = new System.Drawing.Point(648, 255);
            this.btn_AnularBoletas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AnularBoletas.Name = "btn_AnularBoletas";
            this.btn_AnularBoletas.Size = new System.Drawing.Size(142, 35);
            this.btn_AnularBoletas.TabIndex = 44;
            this.btn_AnularBoletas.Text = "ANULAR BOLETAS";
            this.btn_AnularBoletas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AnularBoletas.UseVisualStyleBackColor = false;
            this.btn_AnularBoletas.Click += new System.EventHandler(this.btn_AnularBoletas_Click);
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(63, 109);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(120, 20);
            this.monto.TabIndex = 45;
            // 
            // RealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(835, 404);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.btn_AnularBoletas);
            this.Controls.Add(this.btn_BuscarBoletas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DNIBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox_MostrarBoleta);
            this.Controls.Add(this.cbBTipoServicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechaBox);
            this.Controls.Add(this.textBox_DNI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarBoleta);
            this.Controls.Add(this.cbBMetododePago);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RealizarPago";
            this.Text = "Boleta de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarBoleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.ComboBox cbBMetododePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechaBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBTipoServicio;
        private System.Windows.Forms.RichTextBox richTextBox_MostrarBoleta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_DNIBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarBoletas;
        private System.Windows.Forms.Button btn_AnularBoletas;
        private System.Windows.Forms.NumericUpDown monto;
    }
}