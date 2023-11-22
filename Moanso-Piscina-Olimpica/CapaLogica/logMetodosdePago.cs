using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodosdePago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMetodosdePago _instancia = new logMetodosdePago();
        //privado para evitar la instanciación directa
        public static logMetodosdePago Instancia
        {
            get
            {
                return logMetodosdePago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public void InsertarMetodosdePago(entMetododePago metodo)
        {
            datMetododePago.Instancia.InsertarMetododePago(metodo);
        }
        public List<entMetododePago> ListarMetodos()
        {
            return datMetododePago.Instancia.ListarMetodos();
        }
        
        public void InhabilitarMetodo(int ID)
        {
            datMetododePago.Instancia.InhabilitarMetodo(ID);
        }

        #endregion metodos
    }
}

