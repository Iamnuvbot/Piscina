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
    public class datAsistencia
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
                    Asist.AlumnoDNI = dr["AlumnoDNI"].ToString();
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
        public Boolean InsertarAsistencia(entAsistenciaAlumnos Alumno)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarAsistenciaAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", Alumno.AlumnoDNI);
                cmd.Parameters.AddWithValue("@Fecha", Alumno.Fecha);
                cmd.Parameters.AddWithValue("@HoraEntrada", Alumno.HoraEntrada);
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
        public Boolean InsertarSalida(entAsistenciaAlumnos Alumno)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarSalidaAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", Alumno.AlumnoDNI);
                cmd.Parameters.AddWithValue("@HoraSalida", Alumno.HoraSalida);
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

