using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_C_Sharp
{
   public class Conectionlogin
    {
        SqlConnection con = new SqlConnection();

        public Conectionlogin()
        {
            con.ConnectionString = @"Data Source=VITOR;Initial Catalog=teste;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
         }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }
    }
}
