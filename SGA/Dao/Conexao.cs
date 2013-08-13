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
        private static SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = sga; Integrated Security = false; User ID = sa ; Password = 123456");
        //cria um metodo para passar o objeto
        public static SqlConnection con()
        {
            return conexao;
        }

        public static void gravarLog(string descLog, string chaveAtor, string funcionario, string ferramenta, string requisicao)
        {
            string cFuncionario = "null";
            string cFerramenta = "null";
            string cRequisicao = "null";

            if (requisicao != "")
            {
                cRequisicao = "'" + requisicao + "'";
                cFerramenta = "'" + ferramenta + "'";
                cFuncionario = funcionario;
            }
            else if (ferramenta != "")
            {
                cFerramenta = "'" + ferramenta + "'";
            }
            else if (funcionario != "")
            {
                cFuncionario = funcionario;
            }





            SqlCommand insertLog = new SqlCommand(
           "INSERT INTO tb_logOperacoesCriticas" +
           " (descricao_log, matricula_ator, dt_log, mat_funcionario, cod_ferramenta, cod_requisicao)" +
           " VALUES " +
           "('" + descLog + "', " +
           chaveAtor +
           ", current_timestamp," +
           cFuncionario + ", " +
           cFerramenta +
           ", " + cRequisicao + ")", Conexao.con());

            Conexao.con().Open();

            insertLog.ExecuteNonQuery();

            Conexao.con().Close();
        }

        public static void backup()
        {
           
            string caminho = System.IO.Directory.GetCurrentDirectory();

            caminho = caminho + @"\Backup";

            var caminho2 = caminho + @"\SGA-" + System.DateTime.Now.ToString("dd-MM-yyy") + @".bkp";

            try
            {
                SqlCommand backup = new SqlCommand("BACKUP DATABASE sga " +
                                           "TO  DISK = '" + @"C:\Backup.bkp " + "'" +
                                                "WITH " +
                                           "NOINIT," +
                                           "NAME = N'northwind-Full Database Backup'," +
                                           "SKIP,  STATS = 10", Conexao.con());
                ;
                Conexao.con().Open();
                backup.ExecuteNonQuery();
                Conexao.con().Close();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
