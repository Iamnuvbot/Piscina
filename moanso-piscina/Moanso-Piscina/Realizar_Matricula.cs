using CapaEntidad;
using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace Moanso_Piscina
{
    public partial class Realizar_Matricula : Form
    {
        public Realizar_Matricula()
        {
            InitializeComponent();
            dataGridView_matriculas.DataSource = logAlumno.Instancia.ListarAlumnos();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public bool VerificarTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBox_nombres.Text) ||
                string.IsNullOrWhiteSpace(textBox_apellidos.Text) ||
                string.IsNullOrWhiteSpace(textBox_categoria.Text) ||
                string.IsNullOrWhiteSpace(textBox_correo.Text) ||
                string.IsNullOrWhiteSpace(textBox_dni.Text) ||
                string.IsNullOrWhiteSpace(textBox_edad.Text) ||
                string.IsNullOrWhiteSpace(textBox_telefono.Text) ||
                string.IsNullOrWhiteSpace(textBox_horario.Text) ||
                string.IsNullOrWhiteSpace(textBox_asistencias.Text) ||
                string.IsNullOrWhiteSpace(textBox_direccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_registrar_matricula_Click(object sender, EventArgs e)
        {
            if (VerificarTextBox())
            {
                entAlumno entAlumno = new entAlumno();
                entAlumno.Nombre = textBox_nombres.Text;
                entAlumno.Apellido = textBox_apellidos.Text;
                entAlumno.Categoria = textBox_categoria.Text;
                entAlumno.DNI = textBox_dni.Text;
                entAlumno.Horario = textBox_horario.Text;
                entAlumno.AsistenciasDisponibles = int.Parse(textBox_asistencias.Text);
                entAlumno.Telefono = textBox_telefono.Text;
                entAlumno.Direccion = textBox_direccion.Text;
                entAlumno.Correo = textBox_correo.Text;
                entAlumno.Edad = int.Parse(textBox_edad.Text);
                entAlumno.Nivel = textBox_nivel.Text;
                logAlumno.Instancia.InsertarAlumno(entAlumno);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos en los campos.");
            }
            dataGridView_matriculas.DataSource = logAlumno.Instancia.ListarAlumnos();
        }
    }
}
