using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entBoleta
    {
        public int idBoleta { get; set; }
        public string DNI { get; set; }
        public string Fecha { get; set; }
        public string TipoServicio { get; set; }
        public double Monto { get; set; }
    }
}
