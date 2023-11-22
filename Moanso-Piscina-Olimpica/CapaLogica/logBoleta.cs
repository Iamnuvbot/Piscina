using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logBoleta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logBoleta _instancia = new logBoleta();
        //privado para evitar la instanciación directa
        public static logBoleta Instancia
        {
            get
            {
                return logBoleta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public void InsertarBoleta(entBoleta boleta)
        {
            datBoleta.Instancia.InsertarBoleta(boleta);
        }
        public List<entBoleta> ListarBoletas()
        {
            return datBoleta.Instancia.ListarBoletas();
        }
        public List<entBoleta> BuscarBoletas(string DNI)
        {
            return datBoleta.Instancia.BuscarBoletas(DNI);
        }
        public void AnularBoleta(string fecha)
        {
            datBoleta.Instancia.AnularBoleta(fecha);
        }

        #endregion metodos
    }
}
