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
            this.dgvBoletasDiarias = new System.Windows.Forms.DataGridView();
            this.btnMostrarBoletasD = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarObs = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletasDiarias)).BeginInit();
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
            this.btnMostrarBoletasD.Location = new System.Drawing.Point(431, 193);
            this.btnMostrarBoletasD.Name = "btnMostrarBoletasD";
            this.btnMostrarBoletasD.Size = new System.Drawing.Size(171, 76);
            this.btnMostrarBoletasD.TabIndex = 1;
            this.btnMostrarBoletasD.Text = "Registrar ";
            this.btnMostrarBoletasD.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(660, 172);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(192, 69);
            this.txtObs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(656, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Observaciónes del día";
            // 
            // btnAplicarObs
            // 
            this.btnAplicarObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAplicarObs.Location = new System.Drawing.Point(688, 260);
            this.btnAplicarObs.Name = "btnAplicarObs";
            this.btnAplicarObs.Size = new System.Drawing.Size(125, 49);
            this.btnAplicarObs.TabIndex = 7;
            this.btnAplicarObs.Text = "Aplicar Observación";
            this.btnAplicarObs.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = global::Moanso_Piscina.Properties.Resources.salida;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.Location = new System.Drawing.Point(721, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 53);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(431, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Boletas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Ingreso_Monetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 471);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAplicarObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarBoletasD);
            this.Controls.Add(this.dgvBoletasDiarias);
            this.Name = "Ingreso_Monetario";
            this.Text = "Ingreso_Monetario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletasDiarias)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}