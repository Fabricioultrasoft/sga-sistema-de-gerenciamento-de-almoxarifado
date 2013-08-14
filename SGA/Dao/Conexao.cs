using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Configuration;


namespace SGA.Dao
{
    class Conexao
    {
        //cria um objeto

        private static SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

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
            if (!System.IO.Directory.Exists(caminho))
            {
                System.IO.Directory.CreateDirectory(caminho);
            }

            var path = caminho + @"\SGA-" + System.DateTime.Now.ToString("dd-MM-yyy") + @".bkp";

            try
            {
                SqlConnection objConexao = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString());
                ServerConnection objServers = new ServerConnection(objConexao);

                Server objServer = new Server(objServers);
                objServer.ConnectionContext.Connect();
                string edition = objServer.Information.Edition;
                Microsoft.SqlServer.Management.Smo.Backup objBackup = new Backup();
                objBackup.Action = BackupActionType.Database;
                objBackup.Database = "sga";
                objBackup.MediaName = "FileSystem";

                BackupDeviceItem objDevice = new BackupDeviceItem();
                objDevice.DeviceType = DeviceType.File;
                objDevice.Name = path;
                objBackup.Checksum = true;
                objBackup.ExpirationDate = DateTime.Now;
                objBackup.Incremental = false;
                objBackup.Devices.Add(objDevice);
                objBackup.Initialize = true;
                objBackup.SqlBackup(objServer);
                objBackup.Devices.Remove(objDevice);

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
    }
}
