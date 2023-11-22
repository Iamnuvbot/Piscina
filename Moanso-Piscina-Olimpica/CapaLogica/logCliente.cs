using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    internal class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        //insertar
        public void InsertarCliente(entCliente cliente)
        {
            datCliente.Instancia.InsertarCliente(cliente);
        }
        //obtener
        public entCliente ObtenerCliente(string dni)
        {
            return datCliente.Instancia.ObtenerCliente(dni);
        }
        #endregion metodos
    }
}

