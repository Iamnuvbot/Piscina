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
            MostrarAlumnos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textBox_dni2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
