using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        //+"User ID=AdminOlimpica;Password = admin123"
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=ADRIANPC; Initial Catalog = PiscinaOlimpica;"+"Integrated Security=true";

            return cn;

        }
    }
    
}


