using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datDocente
    {
        List<entDocente> Docentes = new List<entDocente>();
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
        public void InsertarDocente(entDocente docente)
        {
            ListarDocentes().Add(docente);
        }
        public List<entDocente> ListarDocentes()
        {
            return Docentes;
        }
        public List<entDocente> BuscarBoletas(string DNI)
        {
            List<entDocente> boletas = new List<entDocente>();
            foreach (entDocente boleta in Docentes)
            {
                if (boleta.DNI == DNI)
                {
                    boletas.Add(boleta);
                }
                else
                {

                }
            }
            return boletas;
        }
        //public void AnularBoleta(string Fecha)
        //{
        //    foreach (entDocente boleta in boletasLista)
        //    {
        //        if (boleta.Fecha == Fecha)
        //        {
        //            boletasLista.Remove(boleta);
        //        }
        //    }
        //}
        #endregion metodos
    }
}
