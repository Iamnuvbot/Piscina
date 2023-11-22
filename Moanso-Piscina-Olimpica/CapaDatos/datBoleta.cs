using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datBoleta
    {
        List<entBoleta> boletasLista = new List<entBoleta>();
        #region sigleton
        private static readonly datBoleta _instancia = new datBoleta();
        public static datBoleta Instancia
        {
            get
            {
                return datBoleta._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public void InsertarBoleta(entBoleta boleta)
        {
            ListarBoletas().Add(boleta);
        }
        public List<entBoleta> ListarBoletas()
        {
            return boletasLista;
        }
        public List<entBoleta> BuscarBoletas(string DNI)
        {
            List<entBoleta> boletas = new List<entBoleta>();
            foreach (entBoleta boleta in boletasLista)
            {
                if ( boleta.DNI == DNI)
                {
                    boletas.Add(boleta);
                }
                else
                {

                }
            }
            return boletas;
        }
        public void AnularBoleta(int ID)
        {
            for (int i = boletasLista.Count - 1; i >= 0; i--)
            {
                entBoleta boleta = boletasLista[i];
                if (boleta.idBoleta == ID)
                {
                    boletasLista.RemoveAt(i);
                }
            }
        }

        #endregion metodos
    }
}
