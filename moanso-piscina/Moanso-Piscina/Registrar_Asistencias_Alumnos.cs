using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace Moanso_Piscina
{
    public partial class Registrar_Asistencias_Alumnos : Form
    {
        public Registrar_Asistencias_Alumnos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView_asistencias.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textBox_dni1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_dni1.Text.Length > 0)
            {
                entAsistenciaAlumnos entAsistenciaAlumnos = new entAsistenciaAlumnos();
                entAsistenciaAlumnos.AlumnoDNI = textBox_dni1.Text;
                entAsistenciaAlumnos.HoraEntrada = DateTime.Now.TimeOfDay.ToString();
                entAsistenciaAlumnos.Fecha = DateTime.Today.ToString();
                var entAlumno = logAlumno.Instancia.ObtenerAlumno(textBox_dni1.Text);
                if (entAlumno.EstaDentro != true)
                {
                    logAsistenciaAlumnos.Instancia.InsertarAsistencia(entAsistenciaAlumnos);
                }
                else
                {
                    logAsistenciaAlumnos.Instancia.InsertarSalida(textBox_dni1.Text, DateTime.Now.TimeOfDay.ToString());
                }
                dataGridView_asistencias.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textBox_dni1.Text);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos en los campos.");
            }

        }
    }
    
}
