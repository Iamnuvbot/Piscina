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
            dataGridView_asistencias.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textDNI.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDNI.Text.Length > 0)
            {
                entAsistenciaAlumnos entAsistenciaAlumnos = new entAsistenciaAlumnos();
                entAsistenciaAlumnos.AlumnoDNI = textDNI.Text;
                entAsistenciaAlumnos.HoraEntrada = DateTime.Now.TimeOfDay.ToString();
                entAsistenciaAlumnos.Fecha = DateTime.Today.ToString();
                var entAlumno = logAlumno.Instancia.ObtenerAlumno(textDNI.Text);
                if (entAlumno.EstaDentro != true)
                {
                    logAsistenciaAlumnos.Instancia.InsertarAsistencia(entAsistenciaAlumnos);
                }
                else
                {
                    logAsistenciaAlumnos.Instancia.InsertarSalida(textDNI.Text, DateTime.Now.TimeOfDay.ToString());
                }
                dataGridView_asistencias.DataSource = logAsistenciaAlumnos.Instancia.ListarAsistencias(textDNI.Text);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos en los campos.");
            }

        }

        private void textDNI_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Ignorar la tecla si no es un número o una tecla de control
            }

            // Limitar la longitud del DNI a, por ejemplo, 8 dígitos
            if (textDNI.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignorar la tecla si se alcanzó la longitud máxima
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
    
}
