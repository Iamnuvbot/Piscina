using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logAsistencia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAsistencia _instancia = new logAsistencia();
        //privado para evitar la instanciación directa
        public static logAsistencia Instancia
        {
            get
            {
                return logAsistencia._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entAsistencia> ListarAsistencias(string dni)
        {
            return datAsistencia.Instancia.ListarAsistencias(dni);
        }
        //insertar
        public void InsertarAsistencia(entAsistencia Asis)
        {
            datAsistencia.Instancia.InsertarAsistencia(Asis);
        }
        public void InsertarSalida(string dni,string horaSalida)
        {
            datAsistencia.Instancia.InsertarSalida(dni,horaSalida);
        }
        #endregion metodos
    }
}

