using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using SGA.Entity;

namespace SGA.Dao
{
    public class FerramentaDao
    {
        public void gravarFerramenta(Ferramenta ferramenta)
        {

            int codDesc = 0;

            for (int i = 0; i < 2; i++)
            {
                SqlCommand selecDesc = new SqlCommand("SELECT nu_seq_descricao from tb_descricao_ferramenta WHERE no_ferramenta = @noFerramenta", Conexao.con());

                selecDesc.Parameters.AddWithValue("@noFerramenta", ferramenta.nomeFerramenta);

                Conexao.con().Open();

                SqlDataReader linhaCodDesc = selecDesc.ExecuteReader();

                while (linhaCodDesc.Read())
                {
                    codDesc = Convert.ToInt32(linhaCodDesc["nu_seq_descricao"]);
                }

                Conexao.con().Close();

                if (codDesc == 0)
                {
                    SqlCommand insertDesc = new SqlCommand("INSERT INTO tb_descricao_ferramenta (no_ferramenta, fk_grupo) VALUES (@noFerramenta, @grupo)", Conexao.con());
                    SqlCommand selectGrupo = new SqlCommand("SELECT nu_seq_grupo FROM tb_grupo_ferramenta WHERE no_grupo = @grupo", Conexao.con());

                    selectGrupo.Parameters.AddWithValue("@grupo", ferramenta.codGrupo);
                    int codGrupo = 0;

                    Conexao.con().Open();

                    SqlDataReader linhaG = selectGrupo.ExecuteReader();

                    while (linhaG.Read())
                    {
                        codGrupo = Convert.ToInt32(linhaG["nu_seq_grupo"]);
                    }

                    Conexao.con().Close();

                    insertDesc.Parameters.AddWithValue("@noFerramenta", ferramenta.nomeFerramenta);
                    insertDesc.Parameters.AddWithValue("@grupo", codGrupo);

                    Conexao.con().Open();

                    insertDesc.ExecuteNonQuery();

                    Conexao.con().Close();
                    Conexao.gravarLog("Cadastro", ferramenta.chaveUsuario, "", ferramenta.codFerramenta);

                }
                else
                {
                    break;
                }
            }

            
            if (ferramenta.codFerramenta + "" != "")
            {
                SqlCommand update = new SqlCommand("UPDATE tb_ferramenta SET fk_descricao_ferramenta = @fk_descricao ,fk_fabricante = (SELECT nu_seq_fabricante FROM tb_fabricante WHERE no_fabricante = @fabricante),imagem = @imagem" +
                ",fk_situacao = (SELECT nu_seq_situacao FROM tb_situacao_ferramenta WHERE no_situacao = @situacao), nu_serie = @nu_serie WHERE cod_ferramenta = @cod_ferramenta", Conexao.con());

                SqlCommand uodateCategoria = new SqlCommand("UPDATE tb_descricao_ferramenta SET [fk_grupo] = (SELECT [nu_seq_grupo]FROM tb_grupo_ferramenta "+
                "WHERE no_grupo = @no_grupo) WHERE nu_seq_descricao= @nu_seq_descricao", Conexao.con());

                uodateCategoria.Parameters.AddWithValue(@"no_grupo", ferramenta.codGrupo);
                uodateCategoria.Parameters.AddWithValue(@"nu_seq_descricao", codDesc);

                update.Parameters.AddWithValue("@cod_ferramenta", ferramenta.codFerramenta);
                update.Parameters.AddWithValue("@fk_descricao", codDesc);
                update.Parameters.AddWithValue("@fabricante", ferramenta.codFabricante);

                update.Parameters.AddWithValue("@nu_serie", ferramenta.nu_serie);

                try
                {
                    string teste = ferramenta.imagem.ToString();
                    update.Parameters.AddWithValue("@imagem", ConvertImageToByteArray(ferramenta.imagem, System.Drawing.Imaging.ImageFormat.Jpeg));
                }
                catch
                {
                    update.Parameters.AddWithValue("@imagem", ConvertImageToByteArray(SGA.Properties.Resources.no_image, System.Drawing.Imaging.ImageFormat.Png));
                }
                update.Parameters.AddWithValue("@situacao", ferramenta.codSituacao);
                Conexao.con().Open();

                uodateCategoria.ExecuteNonQuery();
                update.ExecuteNonQuery();

                Conexao.con().Close();
            }
            else
            {
                for (int i = 0; i < ferramenta.quantidade; i++)
                {
                    SqlCommand insertFerr = new SqlCommand("INSERT INTO tb_ferramenta(cod_ferramenta, dt_aquisicao, dt_desativacao,fk_descricao_ferramenta, fk_fabricante, imagem, nu_serie, fk_situacao)" +
                    "VALUES ( @codigo, current_timestamp, null, @codDesc, (SELECT nu_seq_fabricante FROM tb_fabricante WHERE no_fabricante = @fabricante), @imagem, @nuserie, @situacao)", Conexao.con());

                    insertFerr.Parameters.AddWithValue("@codigo", geraCodigo());
                    insertFerr.Parameters.AddWithValue("@codDesc", codDesc);
                    insertFerr.Parameters.AddWithValue("@fabricante", ferramenta.codFabricante);
                    insertFerr.Parameters.AddWithValue("@nuserie", ferramenta.nu_serie);
                    try
                    {
                        string teste = ferramenta.imagem.ToString();
                        insertFerr.Parameters.AddWithValue("@imagem", ConvertImageToByteArray(ferramenta.imagem, System.Drawing.Imaging.ImageFormat.Jpeg));
                    }
                    catch
                    {
                        insertFerr.Parameters.AddWithValue("@imagem", ConvertImageToByteArray(SGA.Properties.Resources.no_image, System.Drawing.Imaging.ImageFormat.Png));
                    }
                    insertFerr.Parameters.AddWithValue("@situacao", 1);

                    Conexao.con().Open();

                    insertFerr.ExecuteNonQuery();

                    Conexao.con().Close();

                }

            }

        }

        public bool testFerramentaPendencia(Ferramenta ferramenta)
        {
            bool retorno = true;

            SqlCommand select = new SqlCommand("SELECT cod_ferramenta FROM tb_ferramenta f INNER JOIN tb_requisicao r ON(f.cod_ferramenta = r.fk_ferramenta) WHERE f.cod_ferramenta = @cod_ferramenta AND fk_func_baixa_ferr is NULL", Conexao.con());

            select.Parameters.AddWithValue(@"cod_ferramenta", ferramenta.codFerramenta);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["cod_ferramenta"].ToString();
            }

            Conexao.con().Close();

            if (codigo != "")
            {
                retorno = false;
            }

            return retorno;
        }

        public bool testFerramentaNSerie(Ferramenta ferramenta)
        {
            bool retorno = true;

            SqlCommand select = new SqlCommand("SELECT cod_ferramenta FROM tb_ferramenta f WHERE f.nu_serie = @nu_serie ", Conexao.con());

            select.Parameters.AddWithValue(@"nu_serie", ferramenta.nu_serie);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["cod_ferramenta"].ToString();
            }

            Conexao.con().Close();

            if (codigo != "")
            {
                retorno = false;
            }

            return retorno;
        }

        public void desativaFerramenta(Ferramenta ferramenta)
        {
            SqlCommand select = new SqlCommand("SELECT cod_ferramenta FROM tb_ferramenta f INNER JOIN tb_requisicao r ON(f.cod_ferramenta = r.fk_ferramenta) WHERE f.cod_ferramenta = @cod_ferramenta", Conexao.con());

            select.Parameters.AddWithValue(@"cod_ferramenta", ferramenta.codFerramenta);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["cod_ferramenta"].ToString();
            }

            Conexao.con().Close();

            if (codigo == "")
            {
                SqlCommand delete = new SqlCommand("DELETE FROM tb_ferramenta WHERE cod_ferramenta = @cod_ferramenta", Conexao.con());

                delete.Parameters.AddWithValue(@"cod_ferramenta", ferramenta.codFerramenta);

                Conexao.con().Open();

                delete.ExecuteNonQuery();

                Conexao.con().Close();
                Conexao.gravarLog("Exclusao", ferramenta.chaveUsuario, "", ferramenta.codFerramenta);

            }
            else
            {
                SqlCommand desativa = new SqlCommand("UPDATE tb_ferramenta SET fk_situacao = 4 WHERE cod_ferramenta = @cod_ferramenta", Conexao.con());

                desativa.Parameters.AddWithValue(@"cod_ferramenta", ferramenta.codFerramenta);

                Conexao.con().Open();

                desativa.ExecuteNonQuery();

                Conexao.con().Close();
                Conexao.gravarLog("Desativacao", ferramenta.chaveUsuario, "", ferramenta.codFerramenta);

            }

        }

        private string geraCodigo()
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            SqlCommand selectCod = new SqlCommand("SELECT MAX(cod_ferramenta) as cod_ferramenta FROM tb_ferramenta ", Conexao.con());

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader ultimoCodigo = selectCod.ExecuteReader();

            while (ultimoCodigo.Read())
            {
                codigo = ultimoCodigo["cod_ferramenta"].ToString();
            }

            Conexao.con().Close();
            if (codigo != "")
            {
                for (int i = 4; i >= 0; i--)
                {
                    string letra = codigo.ElementAt(i).ToString();
                    if (letra == "Z")
                    {
                        codigo = codigo.Remove(i, 1);
                        codigo = codigo.Insert(i, "A");
                    }
                    else
                    {
                        codigo = codigo.Remove(i, 1);
                        codigo = codigo.Insert(i, alfabeto.ElementAt(alfabeto.IndexOf(letra) + 1).ToString());
                        break;
                    }
                }
            }
            else
            {
                codigo = "AAAAA";
            }
            return codigo;
        }

        public void manterFabricante(string comando, string valorAntigo, string novoValor)
        {
            string comandoSQL = "";
            switch (comando)
            {
                case "insert":
                    {

                        comandoSQL = "INSERT INTO tb_fabricante(no_fabricante) VALUES('" + novoValor + "')";
                    }
                    break;
                case "delete":
                    {
                        comandoSQL = "DELETE FROM tb_fabricante WHERE no_fabricante = '" + valorAntigo + "'";
                    }
                    break;
                default:
                    {
                        comandoSQL = "UPDATE tb_fabricante SET no_fabricante = '" + novoValor + "' WHERE no_fabricante = '" + valorAntigo + "'";
                    }
                    break;
            }

            if (comando == "delete")
            {
                SqlCommand select = new SqlCommand("SELECT cod_ferramenta FROM tb_ferramenta f INNER JOIN tb_fabricante fa ON(f.fk_fabricante = fa.nu_seq_fabricante) WHERE fa.no_fabricante = '" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                string codFerramenta = "";
                while (linha.Read())
                {
                    codFerramenta = linha["cod_ferramenta"].ToString();
                }

                Conexao.con().Close();

                if (codFerramenta != "")
                {
                    throw new System.ArgumentException("O fabricante está sendo utilizado!\n Ação não permitida!");
                }
            }
            else
            {
                SqlCommand select = new SqlCommand("SELECT no_fabricante FROM tb_fabricante WHERE no_fabricante = '" + novoValor + "' AND  no_fabricante <> '" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                string no_fabricante = "0";
                while (linha.Read())
                {
                    no_fabricante = linha["no_fabricante"].ToString();
                }

                Conexao.con().Close();

                if (no_fabricante != "0" && valorAntigo != novoValor)
                {
                    throw new System.ArgumentException("Fabricante já cadastrado!");
                }
            }

            SqlCommand comm = new SqlCommand(comandoSQL, Conexao.con());

            Conexao.con().Open();

            comm.ExecuteNonQuery();

            Conexao.con().Close();

        }

        public void manterGrupo(string comando, string valorAntigo, string novoValor)
        {
            string comandoSQL = "";
            switch (comando)
            {
                case "insert":
                    {

                        comandoSQL = "INSERT INTO tb_grupo_ferramenta(no_grupo) VALUES('" + novoValor + "')";
                    }
                    break;
                case "delete":
                    {
                        comandoSQL = "DELETE FROM tb_grupo_ferramenta WHERE no_grupo = '" + valorAntigo + "'";
                    }
                    break;
                default:
                    {
                        comandoSQL = "UPDATE tb_grupo_ferramenta SET no_grupo = '" + novoValor + "' WHERE no_grupo = '" + valorAntigo + "'";
                    }
                    break;
            }

            if (comando == "delete")
            {
                SqlCommand select = new SqlCommand("SELECT f.nu_seq_descricao FROM tb_descricao_ferramenta f INNER JOIN tb_grupo_ferramenta g ON(f.fk_grupo = g.nu_seq_grupo) WHERE g.no_grupo = '" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                int codFerramenta = 0;
                while (linha.Read())
                {
                    codFerramenta = Convert.ToInt32(linha["nu_seq_descricao"]);
                }

                Conexao.con().Close();

                if (codFerramenta != 0)
                {
                    throw new System.ArgumentException("A categoria está sendo utilizada!\n Ação não permitida!");
                }
            }
            else
            {
                SqlCommand select = new SqlCommand("SELECT no_grupo FROM tb_grupo_ferramenta WHERE no_grupo = '" + novoValor + "'AND no_grupo <> '" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                string no_fabricante = "0";
                while (linha.Read())
                {
                    no_fabricante = linha["no_grupo"].ToString();
                }

                Conexao.con().Close();

                if (no_fabricante != "0" && novoValor != valorAntigo)
                {
                    throw new System.ArgumentException("Categoria já cadastrada!");
                }
            }

            SqlCommand comm = new SqlCommand(comandoSQL, Conexao.con());

            Conexao.con().Open();

            comm.ExecuteNonQuery();

            Conexao.con().Close();

        }

        public Queue preencherCbxFabricante()
        {
            Queue cbxFabricante = new Queue();

            SqlCommand selectFuncao = new SqlCommand("SELECT no_fabricante FROM tb_fabricante", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectFuncao.ExecuteReader();

            while (linha.Read())
            {
                cbxFabricante.Enqueue(linha["no_fabricante"].ToString());
            }

            Conexao.con().Close();

            return cbxFabricante;
        }

        public Queue preencherCbxGrupo()
        {
            Queue cbxGrupo = new Queue();

            SqlCommand selectGrupo = new SqlCommand("SELECT no_grupo FROM tb_grupo_ferramenta", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectGrupo.ExecuteReader();

            while (linha.Read())
            {
                cbxGrupo.Enqueue(linha["no_grupo"].ToString());
            }

            Conexao.con().Close();

            return cbxGrupo;
        }

        public Queue preencherCbxSituacao()
        {
            Queue cbxSituacao = new Queue();

            SqlCommand selectFuncao = new SqlCommand("SELECT no_situacao FROM tb_situacao_ferramenta", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectFuncao.ExecuteReader();

            while (linha.Read())
            {
                if (linha["no_situacao"].ToString() != "Desativada")
                    cbxSituacao.Enqueue(linha["no_situacao"].ToString());
            }

            Conexao.con().Close();

            return cbxSituacao;
        }

        public Queue pesquisaFerramenta(Ferramenta objFerramenta)
        {
            Queue arrayFerramentas = new Queue();

            string comando = "";

            if (objFerramenta.codFerramenta + "" != "")
            {
                comando = comando + " AND fe.cod_ferramenta LIKE '%" + objFerramenta.codFerramenta + "%'";
            }
            if (objFerramenta.periodo[0] + "" != "")
            {
                if (objFerramenta.periodo[0] == "Aquisicao")
                {
                    comando = comando + " AND dt_aquisicao between '" + objFerramenta.periodo[1] + "' AND '" + objFerramenta.periodo[2] + "'";
                }
            }
            if (objFerramenta.codSituacao + "" != "")
            {
                comando = comando + " AND sf.no_situacao = '" + objFerramenta.codSituacao + "'";
            }
            if (objFerramenta.nomeFerramenta + "" != "")
            {
                comando = comando + " AND d.no_ferramenta LIKE '%" + objFerramenta.nomeFerramenta + "%'";
            }
            if (objFerramenta.codFabricante + "" != "")
            {
                comando = comando + " AND fa.no_fabricante = '" + objFerramenta.codFabricante + "'";
            }
            if (objFerramenta.codGrupo + "" != "")
            {
                comando = comando + " AND g.no_grupo = '" + objFerramenta.codGrupo + "'";
            }

            if (objFerramenta.excluivel + "" != "")
            {
                comando = comando + " AND cod_ferramenta NOT IN(SELECT cod_ferramenta FROM tb_ferramenta INNER JOIN tb_requisicao ON(cod_ferramenta = fk_ferramenta))";
            }

            SqlCommand selectFerr = new SqlCommand("SELECT fe.cod_ferramenta, fe.dt_aquisicao, fe.nu_serie, fe.dt_desativacao, fe.imagem, sf.no_situacao, d.no_ferramenta," +
            " fa.no_fabricante, g.no_grupo FROM tb_ferramenta fe INNER JOIN tb_descricao_ferramenta d ON(fe.fk_descricao_ferramenta = d.nu_seq_descricao)" +
            " INNER JOIN tb_fabricante fa ON(fe.fk_fabricante = fa.nu_seq_fabricante)INNER JOIN tb_grupo_ferramenta g" +
            " ON (d.fk_grupo = g.nu_seq_grupo) INNER JOIN tb_situacao_ferramenta sf ON(fe.fk_situacao = sf.nu_seq_situacao) WHERE sf.no_situacao <> 'Desativada' " + comando, Conexao.con());

            Conexao.con().Open();
            SqlDataReader linha = selectFerr.ExecuteReader();

            while (linha.Read())
            {
                Ferramenta ferramenta = new Ferramenta();
                ferramenta.codFerramenta = linha["cod_ferramenta"].ToString();
                ferramenta.nomeFerramenta = linha["no_ferramenta"].ToString();
                ferramenta.dtAquisicao = Convert.ToDateTime(linha["dt_aquisicao"]);
                if (linha["dt_desativacao"].ToString() != "")
                    ferramenta.dtDesativacao = Convert.ToDateTime(linha["dt_desativacao"]);
                ferramenta.codFabricante = linha["no_fabricante"].ToString();
                ferramenta.codGrupo = linha["no_grupo"].ToString();
                ferramenta.nu_serie = linha["nu_serie"].ToString();
                ferramenta.codSituacao = linha["no_situacao"].ToString();
                if (linha["imagem"].ToString() != "")
                    ferramenta.imagem = ConvertByteArrayToImage((Byte[])linha["imagem"]);

                arrayFerramentas.Enqueue(ferramenta);
            }

            Conexao.con().Close();
            return arrayFerramentas;
        }

        public static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return (null);
            }

            return (Image.FromStream(new MemoryStream(byteArray)));
        }

        public static byte[] ConvertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            if (image == null)
                return null;

            MemoryStream ms = new MemoryStream();
            image.Save(ms, imageFormat);
            return ms.ToArray();
        }

        public string setDateTimerPicker()
        {
            string timer = "";

            SqlCommand selectTimer = new SqlCommand("SELECT MIN([dt_aquisicao]) as min FROM tb_ferramenta", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectTimer.ExecuteReader();

            if (linha.Read())
                timer = linha["min"].ToString();

            Conexao.con().Close();

            return timer;
        }
    }
}
