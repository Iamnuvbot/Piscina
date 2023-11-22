using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Moanso_Piscina
{
    public partial class Perfil_Docente : Form
    {
        public Perfil_Docente()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            entDocente docente = new entDocente();
            //docente.Nombre = textBoxNombre.Text;
            //docente.DNI = textBoxDNI.Text;
            //docente.idDocente = 
            //logDocente.Instancia.Insertardocente(docente);
        }
    }
}
