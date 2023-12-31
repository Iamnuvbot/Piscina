﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                    Alumno.DNI = dr["DNI"].ToString();
                    Alumno.Nombre = dr["Nombre"].ToString();
                    Alumno.TipoMatricula = dr["Categoria"].ToString();
                    Alumno.Horario = dr["Horario"].ToString();
                    Alumno.AsistenciasDisponibles = Convert.ToInt32(dr["AsistenciasDisponibles"]);
                    Alumno.Telefono = dr["Telefono"].ToString();
                    Alumno.Edad = Convert.ToInt32(dr["Edad"]);
                    Alumno.Estado = Convert.ToBoolean(dr["Estado"]);
                    Alumno.Nivel = dr["Nivel"].ToString();
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
        public entAlumno ObtenerAlumno(string dni)
        {
            entAlumno Alumno = new entAlumno();
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
                           
                            Alumno.DNI = dr["DNI"].ToString();
                            Alumno.Nombre = dr["Nombre"].ToString();
                            Alumno.TipoMatricula = dr["Categoria"].ToString();
                            Alumno.Horario = dr["Horario"].ToString();
                            Alumno.AsistenciasDisponibles = Convert.ToInt32(dr["AsistenciasDisponibles"]);
                            Alumno.Telefono = dr["Telefono"].ToString();
                            Alumno.Edad = Convert.ToInt32(dr["Edad"]);
                            Alumno.Estado = Convert.ToBoolean(dr["Estado"]);
                            Alumno.Nivel = dr["Nivel"].ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Alumno;
        }

        public Boolean InsertarAlumno(entAlumno Alumno)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarNuevoAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", Alumno.DNI);
                cmd.Parameters.AddWithValue("@Nombre", Alumno.Nombre);
                cmd.Parameters.AddWithValue("@Categoria", Alumno.TipoMatricula);
                cmd.Parameters.AddWithValue("@Horario", Alumno.Horario);
                cmd.Parameters.AddWithValue("@AsistenciasDisponibles", Alumno.AsistenciasDisponibles);
                cmd.Parameters.AddWithValue("@Telefono", Alumno.Telefono);
                cmd.Parameters.AddWithValue("@Edad", Alumno.Edad);
                cmd.Parameters.AddWithValue("@Nivel", Alumno.Nivel);
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
