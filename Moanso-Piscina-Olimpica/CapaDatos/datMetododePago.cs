using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datMetododePago
    {
        List<entMetododePago> metodoslista = new List<entMetododePago>();
        #region sigleton
        private static readonly datMetododePago _instancia = new datMetododePago();
        public static datMetododePago Instancia
        {
            get
            {
                return datMetododePago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public void InsertarMetododePago(entMetododePago MetododePago)
        {
            ListarMetodos().Add(MetododePago);
        }
        public List<entMetododePago> ListarMetodos()
        {
            return metodoslista;
        }
        
        
        public void InhabilitarMetodo(int ID)
        {
            foreach (entMetododePago metodo in metodoslista)
            {
                if (metodo.ID == ID)
                {
                    metodoslista.Remove(metodo);
                }
            }
        }
        #endregion metodos
    }
}

