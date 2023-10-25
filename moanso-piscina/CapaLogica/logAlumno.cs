using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logAlumno
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAlumno _instancia = new logAlumno();
        //privado para evitar la instanciación directa
        public static logAlumno Instancia
        {
            get
            {
                return logAlumno.Instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entAlumno> ListarAlumnos()
        {
            return logAlumno.Instancia.ListarAlumnos();
        }
        //insertar

        #endregion metodos
    }
}
