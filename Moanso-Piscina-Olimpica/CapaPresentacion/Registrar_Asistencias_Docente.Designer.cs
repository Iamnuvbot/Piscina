
namespace Moanso_Piscina
{
    partial class Registrar_Asistencias_Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Asistencias_Docente));
            this.label_listarAsis = new System.Windows.Forms.Label();
            this.label_dni1 = new System.Windows.Forms.Label();
            this.textBox_dni1 = new System.Windows.Forms.TextBox();
            this.dataGridView_asistencias = new System.Windows.Forms.DataGridView();
            this.label_asistencia = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label_listarAsis
            // 
            this.label_listarAsis.AutoSize = true;
            this.label_listarAsis.Location = new System.Drawing.Point(527, 36);
            this.label_listarAsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listarAsis.Name = "label_listarAsis";
            this.label_listarAsis.Size = new System.Drawing.Size(187, 16);
            this.label_listarAsis.TabIndex = 41;
            this.label_listarAsis.Text = "Listar Asistencias del Docente";
            // 
            // label_dni1
            // 
            this.label_dni1.AutoSize = true;
            this.label_dni1.Location = new System.Drawing.Point(33, 49);
            this.label_dni1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dni1.Name = "label_dni1";
            this.label_dni1.Size = new System.Drawing.Size(84, 16);
            this.label_dni1.TabIndex = 40;
            this.label_dni1.Text = "DNI Docente";
            // 
            // textBox_dni1
            // 
            this.textBox_dni1.Location = new System.Drawing.Point(37, 84);
            this.textBox_dni1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dni1.Name = "textBox_dni1";
            this.textBox_dni1.Size = new System.Drawing.Size(132, 22);
            this.textBox_dni1.TabIndex = 39;
            // 
            // dataGridView_asistencias
            // 
            this.dataGridView_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_asistencias.Location = new System.Drawing.Point(16, 145);
            this.dataGridView_asistencias.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_asistencias.Name = "dataGridView_asistencias";
            this.dataGridView_asistencias.RowHeadersWidth = 51;
            this.dataGridView_asistencias.Size = new System.Drawing.Size(699, 235);
            this.dataGridView_asistencias.TabIndex = 38;
            // 
            // label_asistencia
            // 
            this.label_asistencia.AutoSize = true;
            this.label_asistencia.Location = new System.Drawing.Point(364, 36);
            this.label_asistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_asistencia.Name = "label_asistencia";
            this.label_asistencia.Size = new System.Drawing.Size(69, 16);
            this.label_asistencia.TabIndex = 36;
            this.label_asistencia.Text = "Asistencia";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cornsilk;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(311, 60);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 48);
            this.button8.TabIndex = 54;
            this.button8.Text = "REGISTRAR ASISTENCIA";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cornsilk;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(530, 60);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 48);
            this.button7.TabIndex = 57;
            this.button7.Text = "LISTAR ASISTENCIA";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Registrar_Asistencias_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(741, 407);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label_listarAsis);
            this.Controls.Add(this.label_dni1);
            this.Controls.Add(this.textBox_dni1);
            this.Controls.Add(this.dataGridView_asistencias);
            this.Controls.Add(this.label_asistencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar_Asistencias_Docente";
            this.Text = "Asistencia_Docente";
            this.Load += new System.EventHandler(this.Asistencia_Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_listarAsis;
        private System.Windows.Forms.Label label_dni1;
        private System.Windows.Forms.TextBox textBox_dni1;
        private System.Windows.Forms.DataGridView dataGridView_asistencias;
        private System.Windows.Forms.Label label_asistencia;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}