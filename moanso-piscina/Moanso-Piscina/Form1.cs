using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace Moanso_Piscina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MostrarAlumnos()
        {
            dataGridView1.DataSource = logAlumno.Instancia.ListarAlumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetTextbox();
            MostrarAlumnos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetTextbox();
            dataGridView1.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textBox_dni2.Text);
        }
        public void SetTextbox()
        {
            if(textBox_nombres.Visible == false)
            {
                textBox_nombres.Visible = true;
                textBox_apellidos.Visible = true;
                textBox_categoria.Visible = true;
                textBox_correo.Visible = true;
                textBox_dni1.Visible = true;
                numericUpDown_edad.Visible = true;
                textBox_telefono.Visible = true;
                textBox_horario.Visible = true;
                numericUpDown_asistencias.Visible = true;
                textBox_direccion.Visible = true;

                label_apellidos.Visible = true;
                label_asistencias.Visible = true;
                label_categoria.Visible = true;
                label_correo.Visible = true;
                label_direccion.Visible = true;
                label_dni1.Visible = true;
                label_edad.Visible = true;
                label_horario.Visible = true;
                label_nombre.Visible = true;
                label_telefono.Visible = true;
            }
            else
            {
            textBox_nombres.Visible = false;
            textBox_apellidos.Visible = false;
            textBox_categoria.Visible = false;
            textBox_correo.Visible = false;
            textBox_dni1.Visible = false;
            numericUpDown_edad.Visible = false;
            textBox_telefono.Visible = false;
            textBox_horario.Visible = false;
            numericUpDown_asistencias.Visible = false;
            textBox_direccion.Visible = false;
                label_apellidos.Visible = false;
                label_asistencias.Visible = false;
                label_categoria.Visible = false;
                label_correo.Visible = false;
                label_direccion.Visible = false;
                label_dni1.Visible = false;
                label_edad.Visible = false;
                label_horario.Visible = false;
                label_nombre.Visible = false;
                label_telefono.Visible = false;
            }

        }
        public bool VerificarTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBox_nombres.Text) ||
                string.IsNullOrWhiteSpace(textBox_apellidos.Text) ||
                string.IsNullOrWhiteSpace(textBox_categoria.Text) ||
                string.IsNullOrWhiteSpace(textBox_correo.Text) ||
                string.IsNullOrWhiteSpace(textBox_dni1.Text) ||
                numericUpDown_edad.Value == 0 ||
                string.IsNullOrWhiteSpace(textBox_telefono.Text) ||
                string.IsNullOrWhiteSpace(textBox_horario.Text) ||
                numericUpDown_asistencias.Value == 0 ||
                string.IsNullOrWhiteSpace(textBox_direccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_nombres.Visible != true)
            {
                entAsistenciaAlumnos entAsistenciaAlumnos = new entAsistenciaAlumnos();
            entAsistenciaAlumnos.AlumnoDNI = textBox_dni2.Text;
            entAsistenciaAlumnos.HoraEntrada = DateTime.Now.TimeOfDay.ToString();
            entAsistenciaAlumnos.Fecha = DateTime.Today.ToString();
            var entAlumno = logAlumno.Instancia.ObtenerAlumno(textBox_dni2.Text);
            if (entAlumno.EstaDentro!=true)
            {
                logAsistenciaAlumnos.Instancia.InsertarAsistencia(entAsistenciaAlumnos);
            }
            else
            {
                logAsistenciaAlumnos.Instancia.InsertarSalida(textBox_dni2.Text, DateTime.Now.TimeOfDay.ToString());
               
            }
            dataGridView1.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textBox_dni2.Text);
            }
            else
            {
                SetTextbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox_nombres.Visible == true)
            {
                if (VerificarTextBox())
                {
            entAlumno entAlumno = new entAlumno();
            entAlumno.Nombre = textBox_nombres.Text;
            entAlumno.Apellido = textBox_apellidos.Text;
            entAlumno.Categoria = textBox_categoria.Text;
            entAlumno.Correo = textBox_correo.Text;
            entAlumno.DNI = textBox_dni1.Text;
            entAlumno.Edad = (int)numericUpDown_edad.Value;
            entAlumno.Telefono = textBox_telefono.Text;
            entAlumno.Horario = textBox_horario.Text;
            entAlumno.AsistenciasDisponibles = (int)numericUpDown_asistencias.Value;
            entAlumno.Direccion = textBox_direccion.Text;
            logAlumno.Instancia.InsertarAlumno(entAlumno);
            dataGridView1.DataSource = logAlumno.Instancia.ListarAlumnos();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese todos los datos en los campos.");
                }

            }
            else
            {
                SetTextbox();
            }

        }
    }
}
