using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moanso_Piscina
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario

            // Mostrar el nuevo formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar_Asistencias_Alumnos frm = new Registrar_Asistencias_Alumnos();
            frm.Show();
        }
    }
}
