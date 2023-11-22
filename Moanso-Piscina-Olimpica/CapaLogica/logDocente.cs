using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDocente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDocente _instancia = new logDocente();
        //privado para evitar la instanciación directa
        public static logDocente Instancia
        {
            get
            {
                return logDocente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public void Insertardocente(entDocente docente)
        {
            datDocente.Instancia.InsertarDocente(docente);
        }
        public List<entDocente> ListasDocentes()
        {
            return datDocente.Instancia.ListarDocentes();
        }
        //public List<entDocente> Buscardocentes(string DNI)
        //{
        //    return datDocente.Instancia.Buscardocentes(DNI);
        //}
        //public void Anulardocente(string fecha)
        //{
        //    datDocente.Instancia.Anulardocente(fecha);
        //}

        #endregion metodos
    }
}
