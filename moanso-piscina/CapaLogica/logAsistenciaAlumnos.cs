using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logAsistenciaAlumnos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAsistenciaAlumnos _instancia = new logAsistenciaAlumnos();
        //privado para evitar la instanciación directa
        public static logAsistenciaAlumnos Instancia
        {
            get
            {
                return logAsistenciaAlumnos._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entAsistenciaAlumnos> ListarAsistencias()
        {
            return datAsistencia.Instancia.ListarAsistencias();
        }
        //insertar
        public void InsertarAsistencia(entAsistenciaAlumnos Asis)
        {
            datAsistencia.Instancia.InsertarAsistencia(Asis);
        }
        #endregion metodos
    }
}

