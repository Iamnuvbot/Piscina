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
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarObs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnMostrarBoletasD.Location = new System.Drawing.Point(706, 40);
            this.btnMostrarBoletasD.Name = "btnMostrarBoletasD";
            this.btnMostrarBoletasD.Size = new System.Drawing.Size(138, 75);
            this.btnMostrarBoletasD.TabIndex = 1;
            this.btnMostrarBoletasD.Text = "Mostrar y Sumar Boletas Diarias";
            this.btnMostrarBoletasD.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(698, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 77);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Guardar y Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 69);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Observaciónes del día";
            // 
            // btnAplicarObs
            // 
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
            this.pictureBox1.Location = new System.Drawing.Point(427, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Ingreso_Monetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAplicarObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicarObs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}