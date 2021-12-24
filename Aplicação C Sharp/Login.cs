using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_C_Sharp
{
   public class Login
    {
        public bool tem; 
        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificalogin(String email, String senha) 
        {
            cmd.CommandText = "select * from aplicacao where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
   

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException) {

                this.mensagem = "erro com banco de dados";
            }
            return tem;
        }
    }
}
