using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_C_Sharp
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Cadastro(String nome, String email, String senha)
        {
            //Comando Sql
            cmd.CommandText = "insert into aplicacao (nome , email, senha) values (@nome, @email, @senha)";
            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                //Conectar com banco
                cmd.Connection = conexao.conectar();
                //Executar Comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Cadastrado com successo";
                }
            catch (SqlException e)
            {
                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }

            
         
            

        }
    }
}
