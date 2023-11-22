namespace Moanso_Piscina
{
    partial class Realiza_Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realiza_Matricula));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHorarios = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoMatricula = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerificarPago = new System.Windows.Forms.Button();
            this.richTextBoxPerfil = new System.Windows.Forms.RichTextBox();
            this.btnCancelarMatricula = new System.Windows.Forms.Button();
            this.btnBuscarPerfil = new System.Windows.Forms.Button();
            this.btnRegistrarMatricula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "HORARIOS";
            // 
            // dataGridViewHorarios
            // 
            this.dataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarios.Location = new System.Drawing.Point(474, 71);
            this.dataGridViewHorarios.Name = "dataGridViewHorarios";
            this.dataGridViewHorarios.RowHeadersWidth = 51;
            this.dataGridViewHorarios.Size = new System.Drawing.Size(730, 135);
            this.dataGridViewHorarios.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(18, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 61);
            this.button3.TabIndex = 9;
            this.button3.Text = "Verificar Disponibilidad de Matricula";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "MOSTRAR PERFIL";
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(62, 336);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(122, 20);
            this.textBox_DNI.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "DNI";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(7, 493);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(330, 26);
            this.dateTimePicker_fecha.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de Consulta:";
            // 
            // comboBoxTipoMatricula
            // 
            this.comboBoxTipoMatricula.FormattingEnabled = true;
            this.comboBoxTipoMatricula.Items.AddRange(new object[] {
            "Acua Bebe",
            "Sincronizado",
            "Water Polo",
            "Estandar"});
            this.comboBoxTipoMatricula.Location = new System.Drawing.Point(263, 58);
            this.comboBoxTipoMatricula.Name = "comboBoxTipoMatricula";
            this.comboBoxTipoMatricula.Size = new System.Drawing.Size(152, 21);
            this.comboBoxTipoMatricula.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Selecciona Tipo de Matricula";
            // 
            // btnVerificarPago
            // 
            this.btnVerificarPago.BackColor = System.Drawing.Color.Cornsilk;
            this.btnVerificarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificarPago.Image")));
            this.btnVerificarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerificarPago.Location = new System.Drawing.Point(18, 185);
            this.btnVerificarPago.Name = "btnVerificarPago";
            this.btnVerificarPago.Size = new System.Drawing.Size(182, 58);
            this.btnVerificarPago.TabIndex = 13;
            this.btnVerificarPago.Text = "VERIFICAR PAGO";
            this.btnVerificarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificarPago.UseVisualStyleBackColor = false;
            // 
            // richTextBoxPerfil
            // 
            this.richTextBoxPerfil.Location = new System.Drawing.Point(474, 274);
            this.richTextBoxPerfil.Name = "richTextBoxPerfil";
            this.richTextBoxPerfil.Size = new System.Drawing.Size(730, 296);
            this.richTextBoxPerfil.TabIndex = 24;
            this.richTextBoxPerfil.Text = "";
            // 
            // btnCancelarMatricula
            // 
            this.btnCancelarMatricula.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCancelarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarMatricula.Image")));
            this.btnCancelarMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarMatricula.Location = new System.Drawing.Point(36, 574);
            this.btnCancelarMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarMatricula.Name = "btnCancelarMatricula";
            this.btnCancelarMatricula.Size = new System.Drawing.Size(220, 40);
            this.btnCancelarMatricula.TabIndex = 25;
            this.btnCancelarMatricula.Text = "CANCELAR MATRICULA";
            this.btnCancelarMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarMatricula.UseVisualStyleBackColor = false;
            this.btnCancelarMatricula.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPerfil.Image")));
            this.btnBuscarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPerfil.Location = new System.Drawing.Point(237, 334);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Size = new System.Drawing.Size(160, 67);
            this.btnBuscarPerfil.TabIndex = 26;
            this.btnBuscarPerfil.Text = "BUSCAR PERFIL";
            this.btnBuscarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPerfil.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarMatricula
            // 
            this.btnRegistrarMatricula.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRegistrarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarMatricula.Image")));
            this.btnRegistrarMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarMatricula.Location = new System.Drawing.Point(18, 248);
            this.btnRegistrarMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarMatricula.Name = "btnRegistrarMatricula";
            this.btnRegistrarMatricula.Size = new System.Drawing.Size(227, 71);
            this.btnRegistrarMatricula.TabIndex = 56;
            this.btnRegistrarMatricula.Text = "REGISTRAR MATRICULA";
            this.btnRegistrarMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarMatricula.UseVisualStyleBackColor = false;
            // 
            // Realiza_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1203, 640);
            this.Controls.Add(this.btnRegistrarMatricula);
            this.Controls.Add(this.btnBuscarPerfil);
            this.Controls.Add(this.btnCancelarMatricula);
            this.Controls.Add(this.richTextBoxPerfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_DNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipoMatricula);
            this.Controls.Add(this.btnVerificarPago);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewHorarios);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Realiza_Matricula";
            this.Text = "Realiza_Matricula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHorarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVerificarPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipoMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxPerfil;
        private System.Windows.Forms.Button btnCancelarMatricula;
        private System.Windows.Forms.Button btnBuscarPerfil;
        private System.Windows.Forms.Button btnRegistrarMatricula;
    }
}