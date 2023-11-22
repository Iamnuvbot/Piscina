using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAlumnos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cliente = new entCliente();
                    Cliente.idCliente = Convert.ToInt32(dr["ID"]);
                    Cliente.DNI = dr["DNI"].ToString();
                    Cliente.Nombre = dr["Nombre"].ToString();
                   ; Cliente.Correo = dr["Correo"].ToString();
                    Cliente.Telefono = dr["Telefono"].ToString();
                    lista.Add(Cliente);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public entCliente ObtenerCliente(string dni)
        {
            entCliente Cliente = new entCliente();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("spObtenerAlumno", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AlumnoDNI", dni);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Cliente.idCliente = Convert.ToInt32(dr["ID"]);
                            Cliente.DNI = dr["DNI"].ToString();
                            Cliente.Nombre = dr["Nombre"].ToString();
                             Cliente.Correo = dr["Correo"].ToString();
                            Cliente.Telefono = dr["Telefono"].ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Cliente;
        }

        public Boolean InsertarCliente(entCliente Cliente)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarNuevoAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", Cliente.DNI);
                cmd.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", Cliente.Correo);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        #endregion metodos
    }
}

