namespace Moanso_Piscina
{
    partial class Ingreso_Monetario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_Monetario));
            this.dgvBoletasDiarias = new System.Windows.Forms.DataGridView();
            this.btnMostrarBoletasD = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarObs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletasDiarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoletasDiarias
            // 
            this.dgvBoletasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletasDiarias.Location = new System.Drawing.Point(12, 12);
            this.dgvBoletasDiarias.Name = "dgvBoletasDiarias";
            this.dgvBoletasDiarias.Size = new System.Drawing.Size(398, 441);
            this.dgvBoletasDiarias.TabIndex = 0;
            // 
            // btnMostrarBoletasD
            // 
            this.btnMostrarBoletasD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMostrarBoletasD.Location = new System.Drawing.Point(681, 33);
            this.btnMostrarBoletasD.Name = "btnMostrarBoletasD";
            this.btnMostrarBoletasD.Size = new System.Drawing.Size(171, 76);
            this.btnMostrarBoletasD.TabIndex = 1;
            this.btnMostrarBoletasD.Text = "Registrar Ingreso Monetario";
            this.btnMostrarBoletasD.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(447, 40);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(192, 69);
            this.txtObs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Observaciónes del día";
            // 
            // btnAplicarObs
            // 
            this.btnAplicarObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAplicarObs.Location = new System.Drawing.Point(475, 128);
            this.btnAplicarObs.Name = "btnAplicarObs";
            this.btnAplicarObs.Size = new System.Drawing.Size(125, 49);
            this.btnAplicarObs.TabIndex = 7;
            this.btnAplicarObs.Text = "Aplicar Observación";
            this.btnAplicarObs.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = global::Moanso_Piscina.Properties.Resources.salida;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.Location = new System.Drawing.Point(698, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 53);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(606, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Ingreso_Monetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 471);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAplicarObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarBoletasD);
            this.Controls.Add(this.dgvBoletasDiarias);
            this.Name = "Ingreso_Monetario";
            this.Text = "Ingreso_Monetario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletasDiarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoletasDiarias;
        private System.Windows.Forms.Button btnMostrarBoletasD;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicarObs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}