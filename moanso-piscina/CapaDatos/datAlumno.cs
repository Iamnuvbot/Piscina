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
    public class datAlumno
    {
        #region sigleton
        private static readonly datAlumno _instancia = new datAlumno();
        public static datAlumno Instancia
        {
            get
            {
                return datAlumno._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAlumno> ListarAlumnos()
        {
            SqlCommand cmd = null;
            List<entAlumno> lista = new List<entAlumno>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAlumnos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAlumno Alumno = new entAlumno();
                    Alumno.idAlumno = Convert.ToInt32(dr["ID"]);
                    Alumno.Nombre = dr["Nombre"].ToString();
                    Alumno.Apellido = dr["Apellido"].ToString();
                    Alumno.Categoria = dr["fecRegCliente"].ToString();
                    Alumno.Horario = dr["Horario"].ToString();
                    Alumno.AsistenciasDisponibles = Convert.ToInt32(dr["AsistenciasDisponibles"]);
                    Alumno.Correo = dr["Correo"].ToString();
                    Alumno.Telefono = dr["Telefono"].ToString();
                    Alumno.Direccion = dr["Direccion"].ToString();
                    Alumno.Edad = Convert.ToInt32(dr["Edad"]);
                    Alumno.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Alumno);
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
