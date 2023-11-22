using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoMatricula
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<string> Horarios { get; set; }
        public string Cupos { get; set; }
    }
}
