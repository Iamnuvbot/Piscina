
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
            this.button4 = new System.Windows.Forms.Button();
            this.label_listarAsis = new System.Windows.Forms.Label();
            this.label_dni1 = new System.Windows.Forms.Label();
            this.textBox_dni1 = new System.Windows.Forms.TextBox();
            this.dataGridView_asistencias = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label_asistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 44);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 44);
            this.button4.TabIndex = 42;
            this.button4.Text = "Listar Asistencias";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_listarAsis
            // 
            this.label_listarAsis.AutoSize = true;
            this.label_listarAsis.Location = new System.Drawing.Point(395, 29);
            this.label_listarAsis.Name = "label_listarAsis";
            this.label_listarAsis.Size = new System.Drawing.Size(149, 13);
            this.label_listarAsis.TabIndex = 41;
            this.label_listarAsis.Text = "Listar Asistencias del Docente";
            // 
            // label_dni1
            // 
            this.label_dni1.AutoSize = true;
            this.label_dni1.Location = new System.Drawing.Point(25, 40);
            this.label_dni1.Name = "label_dni1";
            this.label_dni1.Size = new System.Drawing.Size(70, 13);
            this.label_dni1.TabIndex = 40;
            this.label_dni1.Text = "DNI Docente";
            // 
            // textBox_dni1
            // 
            this.textBox_dni1.Location = new System.Drawing.Point(28, 68);
            this.textBox_dni1.Name = "textBox_dni1";
            this.textBox_dni1.Size = new System.Drawing.Size(100, 20);
            this.textBox_dni1.TabIndex = 39;
            // 
            // dataGridView_asistencias
            // 
            this.dataGridView_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_asistencias.Location = new System.Drawing.Point(12, 118);
            this.dataGridView_asistencias.Name = "dataGridView_asistencias";
            this.dataGridView_asistencias.Size = new System.Drawing.Size(524, 191);
            this.dataGridView_asistencias.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 44);
            this.button2.TabIndex = 37;
            this.button2.Text = "Registrar Asistencia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_asistencia
            // 
            this.label_asistencia.AutoSize = true;
            this.label_asistencia.Location = new System.Drawing.Point(273, 29);
            this.label_asistencia.Name = "label_asistencia";
            this.label_asistencia.Size = new System.Drawing.Size(55, 13);
            this.label_asistencia.TabIndex = 36;
            this.label_asistencia.Text = "Asistencia";
            // 
            // Registrar_Asistencias_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 331);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label_listarAsis);
            this.Controls.Add(this.label_dni1);
            this.Controls.Add(this.textBox_dni1);
            this.Controls.Add(this.dataGridView_asistencias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_asistencia);
            this.Name = "Registrar_Asistencias_Docente";
            this.Text = "Asistencia_Docente";
            this.Load += new System.EventHandler(this.Asistencia_Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_listarAsis;
        private System.Windows.Forms.Label label_dni1;
        private System.Windows.Forms.TextBox textBox_dni1;
        private System.Windows.Forms.DataGridView dataGridView_asistencias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_asistencia;
    }
}