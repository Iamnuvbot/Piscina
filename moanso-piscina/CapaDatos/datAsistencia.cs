using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class datAsistencia
    {
        #region sigleton
        private static readonly datAsistencia _instancia = new datAsistencia();
        //privado para evitar la instanciación directa
        public static datAsistencia Instancia
        {
            get
            {
                return datAsistencia.Instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAsistenciaAlumnos> ListarAsistencias()
        {
            SqlCommand cmd = null;
            List<entAsistenciaAlumnos> lista = new List<entAsistenciaAlumnos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarAsistenciaAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAsistenciaAlumnos Asist = new entAsistenciaAlumnos();
                    Asist.AlumnoID = Convert.ToInt32(dr["AlumnoID"]);
                    Asist.Fecha = dr["Fecha"].ToString();
                    Asist.HoraEntrada = dr["HoraEntrada"].ToString();
                    Asist.HoraSalida= dr["HoraSalida"].ToString();
                    lista.Add(Asist);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        #endregion metodos
    }
}

