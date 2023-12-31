﻿using CapaEntidad;
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
                return datAsistencia._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAsistencia> ListarAsistencias(string dni)
        {
            SqlCommand cmd = null;
            List<entAsistencia> lista = new List<entAsistencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAsistenciaAlumno", cn);

                cmd.CommandType = CommandType.StoredProcedure;           
                cmd.Parameters.AddWithValue("@DNI", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAsistencia Asist = new entAsistencia();
                    Asist.DNI = dr["AlumnoDNI"].ToString();
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
        public Boolean InsertarAsistencia(entAsistencia Alumno)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarAsistenciaAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", Alumno.DNI);
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
        public Boolean InsertarSalida(string dni,string horaSalida)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarSalidaAlumno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoraSalida",horaSalida);
                cmd.Parameters.AddWithValue("@DNI", dni);
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

