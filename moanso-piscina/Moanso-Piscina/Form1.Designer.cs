namespace Moanso_Piscina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_LISTAR = new System.Windows.Forms.Label();
            this.label_asistencia = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_registrarA = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_dni1 = new System.Windows.Forms.TextBox();
            this.label_dni1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label_listarAsis = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.textBox_nombres = new System.Windows.Forms.TextBox();
            this.textBox_apellidos = new System.Windows.Forms.TextBox();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.textBox_horario = new System.Windows.Forms.TextBox();
            this.label_horario = new System.Windows.Forms.Label();
            this.label_asistencias = new System.Windows.Forms.Label();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label_correo = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_edad = new System.Windows.Forms.Label();
            this.numericUpDown_edad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_asistencias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_asistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar Alumnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_LISTAR
            // 
            this.label_LISTAR.AutoSize = true;
            this.label_LISTAR.Location = new System.Drawing.Point(18, 256);
            this.label_LISTAR.Name = "label_LISTAR";
            this.label_LISTAR.Size = new System.Drawing.Size(75, 13);
            this.label_LISTAR.TabIndex = 2;
            this.label_LISTAR.Text = "Listar Alumnos";
            // 
            // label_asistencia
            // 
            this.label_asistencia.AutoSize = true;
            this.label_asistencia.Location = new System.Drawing.Point(160, 256);
            this.label_asistencia.Name = "label_asistencia";
            this.label_asistencia.Size = new System.Drawing.Size(55, 13);
            this.label_asistencia.TabIndex = 3;
            this.label_asistencia.Text = "Asistencia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrar Asistencia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_registrarA
            // 
            this.label_registrarA.AutoSize = true;
            this.label_registrarA.Location = new System.Drawing.Point(302, 256);
            this.label_registrarA.Name = "label_registrarA";
            this.label_registrarA.Size = new System.Drawing.Size(87, 13);
            this.label_registrarA.TabIndex = 5;
            this.label_registrarA.Text = "Registrar Alumno";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Registrar Alumno";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_dni1
            // 
            this.textBox_dni1.Location = new System.Drawing.Point(209, 355);
            this.textBox_dni1.Name = "textBox_dni1";
            this.textBox_dni1.Size = new System.Drawing.Size(122, 20);
            this.textBox_dni1.TabIndex = 8;
            // 
            // label_dni1
            // 
            this.label_dni1.AutoSize = true;
            this.label_dni1.Location = new System.Drawing.Point(206, 339);
            this.label_dni1.Name = "label_dni1";
            this.label_dni1.Size = new System.Drawing.Size(64, 13);
            this.label_dni1.TabIndex = 9;
            this.label_dni1.Text = "DNI Alumno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 271);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Listar Asistencias";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_listarAsis
            // 
            this.label_listarAsis.AutoSize = true;
            this.label_listarAsis.Location = new System.Drawing.Point(444, 256);
            this.label_listarAsis.Name = "label_listarAsis";
            this.label_listarAsis.Size = new System.Drawing.Size(143, 13);
            this.label_listarAsis.TabIndex = 10;
            this.label_listarAsis.Text = "Listar Asistencias del Alumno";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(18, 339);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(49, 13);
            this.label_nombre.TabIndex = 12;
            this.label_nombre.Text = "Nombres";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Location = new System.Drawing.Point(18, 394);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(49, 13);
            this.label_apellidos.TabIndex = 13;
            this.label_apellidos.Text = "Apellidos";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(332, 338);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 14;
            this.label_categoria.Text = "Categoria";
            // 
            // textBox_nombres
            // 
            this.textBox_nombres.Location = new System.Drawing.Point(21, 355);
            this.textBox_nombres.Name = "textBox_nombres";
            this.textBox_nombres.Size = new System.Drawing.Size(182, 20);
            this.textBox_nombres.TabIndex = 15;
            // 
            // textBox_apellidos
            // 
            this.textBox_apellidos.Location = new System.Drawing.Point(20, 410);
            this.textBox_apellidos.Name = "textBox_apellidos";
            this.textBox_apellidos.Size = new System.Drawing.Size(183, 20);
            this.textBox_apellidos.TabIndex = 16;
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.Location = new System.Drawing.Point(335, 355);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(149, 20);
            this.textBox_categoria.TabIndex = 17;
            // 
            // textBox_horario
            // 
            this.textBox_horario.Location = new System.Drawing.Point(335, 411);
            this.textBox_horario.Name = "textBox_horario";
            this.textBox_horario.Size = new System.Drawing.Size(149, 20);
            this.textBox_horario.TabIndex = 18;
            // 
            // label_horario
            // 
            this.label_horario.AutoSize = true;
            this.label_horario.Location = new System.Drawing.Point(332, 393);
            this.label_horario.Name = "label_horario";
            this.label_horario.Size = new System.Drawing.Size(41, 13);
            this.label_horario.TabIndex = 19;
            this.label_horario.Text = "Horario";
            // 
            // label_asistencias
            // 
            this.label_asistencias.AutoSize = true;
            this.label_asistencias.Location = new System.Drawing.Point(489, 338);
            this.label_asistencias.Name = "label_asistencias";
            this.label_asistencias.Size = new System.Drawing.Size(60, 13);
            this.label_asistencias.TabIndex = 20;
            this.label_asistencias.Text = "Asistencias";
            // 
            // textBox_correo
            // 
            this.textBox_correo.Location = new System.Drawing.Point(490, 411);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(149, 20);
            this.textBox_correo.TabIndex = 22;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(618, 354);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(149, 20);
            this.textBox_telefono.TabIndex = 23;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(645, 411);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(149, 20);
            this.textBox_direccion.TabIndex = 24;
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Location = new System.Drawing.Point(489, 393);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(38, 13);
            this.label_correo.TabIndex = 25;
            this.label_correo.Text = "Correo";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(618, 339);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 26;
            this.label_telefono.Text = "Telefono";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(642, 394);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 27;
            this.label_direccion.Text = "Dirección";
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(206, 395);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(32, 13);
            this.label_edad.TabIndex = 28;
            this.label_edad.Text = "Edad";
            // 
            // numericUpDown_edad
            // 
            this.numericUpDown_edad.Location = new System.Drawing.Point(209, 411);
            this.numericUpDown_edad.Name = "numericUpDown_edad";
            this.numericUpDown_edad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_edad.TabIndex = 29;
            // 
            // numericUpDown_asistencias
            // 
            this.numericUpDown_asistencias.Location = new System.Drawing.Point(492, 354);
            this.numericUpDown_asistencias.Name = "numericUpDown_asistencias";
            this.numericUpDown_asistencias.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_asistencias.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 479);
            this.Controls.Add(this.numericUpDown_asistencias);
            this.Controls.Add(this.numericUpDown_edad);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_correo);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_correo);
            this.Controls.Add(this.label_asistencias);
            this.Controls.Add(this.label_horario);
            this.Controls.Add(this.textBox_horario);
            this.Controls.Add(this.textBox_categoria);
            this.Controls.Add(this.textBox_apellidos);
            this.Controls.Add(this.textBox_nombres);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label_listarAsis);
            this.Controls.Add(this.label_dni1);
            this.Controls.Add(this.textBox_dni1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_registrarA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_asistencia);
            this.Controls.Add(this.label_LISTAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_asistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_LISTAR;
        private System.Windows.Forms.Label label_asistencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_registrarA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_dni1;
        private System.Windows.Forms.Label label_dni1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_listarAsis;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.TextBox textBox_nombres;
        private System.Windows.Forms.TextBox textBox_apellidos;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.TextBox textBox_horario;
        private System.Windows.Forms.Label label_horario;
        private System.Windows.Forms.Label label_asistencias;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.NumericUpDown numericUpDown_edad;
        private System.Windows.Forms.NumericUpDown numericUpDown_asistencias;
    }
}

