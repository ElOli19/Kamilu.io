using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace LaPractica.Clases
{
    public class BDCommon
    {
        private static string Conn = @"Data Source=.;Initial Catalog=BDKamilu;Integrated Security=True";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}