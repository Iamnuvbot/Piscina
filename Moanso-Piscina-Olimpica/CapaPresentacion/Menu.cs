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
            Realiza_Matricula frm = new Realiza_Matricula();
            frm.Show();
            // Mostrar el nuevo formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar_Asistencias_Alumnos frm = new Registrar_Asistencias_Alumnos();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrar_Asistencias_Docente frm = new Registrar_Asistencias_Docente();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingreso_Monetario frm = new Ingreso_Monetario();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListaCliente frm = new ListaCliente();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Devolución_Pago frm = new Devolución_Pago();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Perfil_Alumno frm = new Perfil_Alumno();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Perfil_Docente frm = new Perfil_Docente();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Metodo_De_Pago frm = new Metodo_De_Pago();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RealizarPago frm = new RealizarPago();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mantenedor_Clientes frm = new Mantenedor_Clientes();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tipo_Matricula_Registrado frm = new Tipo_Matricula_Registrado();
            frm.Show();
        }
    }
}
