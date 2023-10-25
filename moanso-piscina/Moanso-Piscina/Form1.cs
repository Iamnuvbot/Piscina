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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListarAlumnos();
        }
        public void ListarAlumnos()
        {
            dataGridView1.DataSource = CapaLogica.logAlumno.Instancia.ListarAlumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
