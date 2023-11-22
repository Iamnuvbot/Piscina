using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datDocente
    {
        #region sigleton
        private static readonly datDocente _instancia = new datDocente();
        public static datDocente Instancia
        {
            get
            {
                return datDocente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        #endregion metodos
    }
}
