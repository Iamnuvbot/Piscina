
namespace Moanso_Piscina
{
    partial class Registrar_Asistencias_Alumnos
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
            this.button2 = new System.Windows.Forms.Button();
            this.label_asistencia = new System.Windows.Forms.Label();
            this.dataGridView_asistencias = new System.Windows.Forms.DataGridView();
            this.label_dni1 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label_listarAsis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrar Asistencia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_asistencia
            // 
            this.label_asistencia.AutoSize = true;
            this.label_asistencia.Location = new System.Drawing.Point(364, 43);
            this.label_asistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_asistencia.Name = "label_asistencia";
            this.label_asistencia.Size = new System.Drawing.Size(69, 16);
            this.label_asistencia.TabIndex = 5;
            this.label_asistencia.Text = "Asistencia";
            // 
            // dataGridView_asistencias
            // 
            this.dataGridView_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_asistencias.Location = new System.Drawing.Point(16, 153);
            this.dataGridView_asistencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_asistencias.Name = "dataGridView_asistencias";
            this.dataGridView_asistencias.RowHeadersWidth = 51;
            this.dataGridView_asistencias.Size = new System.Drawing.Size(699, 235);
            this.dataGridView_asistencias.TabIndex = 7;
            // 
            // label_dni1
            // 
            this.label_dni1.AutoSize = true;
            this.label_dni1.Location = new System.Drawing.Point(52, 43);
            this.label_dni1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dni1.Name = "label_dni1";
            this.label_dni1.Size = new System.Drawing.Size(78, 16);
            this.label_dni1.TabIndex = 33;
            this.label_dni1.Text = "DNI Alumno";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(56, 78);
            this.textDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(132, 22);
            this.textDNI.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 62);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 54);
            this.button4.TabIndex = 35;
            this.button4.Text = "Listar Asistencias";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_listarAsis
            // 
            this.label_listarAsis.AutoSize = true;
            this.label_listarAsis.Location = new System.Drawing.Point(527, 43);
            this.label_listarAsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listarAsis.Name = "label_listarAsis";
            this.label_listarAsis.Size = new System.Drawing.Size(181, 16);
            this.label_listarAsis.TabIndex = 34;
            this.label_listarAsis.Text = "Listar Asistencias del Alumno";
            // 
            // Registrar_Asistencias_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(745, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label_listarAsis);
            this.Controls.Add(this.label_dni1);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.dataGridView_asistencias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_asistencia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrar_Asistencias_Alumnos";
            this.Text = "Registrar Asistencia Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_asistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_asistencia;
        private System.Windows.Forms.DataGridView dataGridView_asistencias;
        private System.Windows.Forms.Label label_dni1;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_listarAsis;
    }
}