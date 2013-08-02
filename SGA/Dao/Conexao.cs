using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SGA.Dao
{
     class Conexao
    {
        //cria um objeto
         private static SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = sga; Integrated Security = false; User ID = sa ; Password = root");
        //cria um metodo para passar o objeto
        public static SqlConnection con()
        {
            return conexao;
        }

        public static void gravarLog(string descLog, string  chaveAtor, string funcionario , string ferramenta)
        {
            string cFuncionario = "null";
            string cFerramenta = "null";

            if (funcionario == "")
            {
                cFerramenta = "'" + ferramenta + "'";
            }
            else
            {
                cFuncionario = funcionario;
            }


                SqlCommand insertLog = new SqlCommand(
               "INSERT INTO tb_logOperacoesCriticas" +
               " (descricao_log, matricula_ator, dt_log, mat_funcionario, cod_ferramenta)" +
               " VALUES " +
               "('" + descLog + "', " +
               chaveAtor +
               ", current_timestamp," +
               cFuncionario + ", " +
               cFerramenta + ")", Conexao.con());

                Conexao.con().Open();

                insertLog.ExecuteNonQuery();

                Conexao.con().Close();
        }
    }
}
