using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; //Se agrega las librerias .Data 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moanso_Piscina
{
    public partial class Registrar_Asistencias_Docente : Form
    {
        public Registrar_Asistencias_Docente()
        {
            InitializeComponent();
        }

        private void Asistencia_Docente_Load(object sender, EventArgs e)
        {

        }

        private void textBox_dni1_TextChanged(object sender, KeyPressEventArgs e)
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

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
