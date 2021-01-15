using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class D_user
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
       
      
        public DataTable login(string user, string password)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_LOGIN", conexion);
            cmd.Parameters.AddWithValue("@USER", user);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader rows = cmd.ExecuteReader();
            table.Load(rows);
            rows.Close();
            conexion.Close();

            return table;




        }


    }
}
