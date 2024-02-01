using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class Conexion
    {

        public static string conexion = @"Data source=DESKTOP-RU7PF9O\SQLEXPRESS; Initial Catalog=BASECURSO; Integrated Security=true;";
        
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open) 
            {
                conectar.Close();
            }
        }


    }
}
