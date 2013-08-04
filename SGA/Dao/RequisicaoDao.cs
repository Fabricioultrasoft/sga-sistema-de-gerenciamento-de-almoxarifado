using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGA.Entity;
using System.Drawing;
using System.IO;

namespace SGA.Dao
{
    class RequisicaoDao
    {
        public void gravarRequisicao(Requisicao requisicao)
        {
            foreach (Ferramenta ferramenta in requisicao.ferramentas)
            {
                SqlCommand updateFerramenta = new SqlCommand("UPDATE tb_ferramenta SET fk_situacao = 3 WHERE cod_ferramenta = @cod_ferramenta", Conexao.con());

                updateFerramenta.Parameters.AddWithValue("@cod_ferramenta", ferramenta.codFerramenta);

                SqlCommand insertRequisicao = new SqlCommand("INSERT INTO tb_requisicao(dt_baixa_requisicao" +
                ",dt_saida_requisicao, fk_func_saida_ferr,fk_ferramenta,fk_func_baixa_ferr,fk_func_requisitante)" +
                " VALUES (NULL,CURRENT_TIMESTAMP,@fk_func_saida_ferr,@fk_ferramenta,NULL,@fk_func_requisitante)", Conexao.con());

                insertRequisicao.Parameters.AddWithValue("@fk_func_saida_ferr", requisicao.funcionario[0].matricula);
                insertRequisicao.Parameters.AddWithValue("@fk_ferramenta", ferramenta.codFerramenta);
                insertRequisicao.Parameters.AddWithValue("@fk_func_requisitante", requisicao.funcionario[1].matricula);

                Conexao.con().Open();

                updateFerramenta.ExecuteNonQuery();
                insertRequisicao.ExecuteNonQuery();
                Conexao.con().Close();
            }
        }

        public List<Requisicao> pesquisarRequisicao()
        {
            List<Requisicao> listaRequisicao = new List<Requisicao>();
            Requisicao requisicao;
            Ferramenta ferramenta = new Ferramenta();
            Funcionario funcionario;

            SqlCommand selectRequisicao = new SqlCommand("SELECT nu_seq_requisicao, fk_ferramenta, de.no_ferramenta, f.imagem , dt_saida_requisicao, dt_baixa_requisicao , fk_func_requisitante" +
      ",(SELECT no_funcionario FROM tb_funcionario WHERE mat_funcionario = fk_func_requisitante) as no_func_requisitante" + 
      ",(SELECT no_funcao FROM tb_funcao INNER JOIN tb_funcionario ON(fk_funcao = nu_seq_funcao) WHERE mat_funcionario = fk_func_requisitante) as no_funcao_req " +
      ",fk_func_saida_ferr " +
	  ",(SELECT no_funcionario FROM tb_funcionario WHERE mat_funcionario = fk_func_saida_ferr) as no_func_saida" +
	  ",(SELECT no_funcao FROM tb_funcao INNER JOIN tb_funcionario ON(fk_funcao = nu_seq_funcao) WHERE mat_funcionario = fk_func_saida_ferr) as no_funcao_saida " +
      ",fk_func_baixa_ferr " + 
      ",(SELECT no_funcionario FROM tb_funcionario WHERE mat_funcionario = fk_func_baixa_ferr) as no_func_baixa" + 
      ",(SELECT no_funcao FROM tb_funcao INNER JOIN tb_funcionario ON(fk_funcao = nu_seq_funcao) WHERE mat_funcionario = fk_func_baixa_ferr) as no_funcao_baixa " +
      "      FROM [sga].[dbo].[tb_requisicao] r " + 
      "     INNER JOIN tb_ferramenta f  ON(fk_ferramenta = f.cod_ferramenta)  " +
      "      INNER jOIN tb_descricao_ferramenta de ON(fk_descricao_ferramenta = de.nu_seq_descricao) " +
      " WHERE 1 = 1", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectRequisicao.ExecuteReader();
            while (linha.Read())
            {
                requisicao = new Requisicao();
                ferramenta = new Ferramenta();

                requisicao.codRequisicao = Convert.ToInt32(linha["nu_seq_requisicao"]);
                if (linha["dt_baixa_requisicao"].ToString() != "")
                    requisicao.dtBaixa = Convert.ToDateTime(linha["dt_baixa_requisicao"]);
                requisicao.dtRequisicao = Convert.ToDateTime(linha["dt_saida_requisicao"]);
                ferramenta.codFerramenta = linha["fk_ferramenta"].ToString();

                ferramenta.nomeFerramenta = linha["no_ferramenta"].ToString();
                if (linha["imagem"].ToString() != "")
                    ferramenta.imagem = ConvertByteArrayToImage((Byte[])linha["imagem"]);
                requisicao.ferramentas.Add(ferramenta);

                funcionario = new Funcionario();
                funcionario.matricula = Convert.ToInt32(linha["fk_func_saida_ferr"]);
                funcionario.nome = linha["no_func_saida"].ToString();
                funcionario.no_funcao = linha["no_funcao_saida"].ToString();
                requisicao.funcionario.Add(funcionario);

                funcionario = new Funcionario();
                funcionario.matricula = Convert.ToInt32(linha["fk_func_requisitante"]);
                funcionario.nome = linha["no_func_requisitante"].ToString();
                funcionario.no_funcao = linha["no_funcao_req"].ToString();
                requisicao.funcionario.Add(funcionario);

                funcionario = new Funcionario();
                if (linha["fk_func_baixa_ferr"].ToString() != "" )
                funcionario.matricula = Convert.ToInt32(linha["fk_func_baixa_ferr"]);
                funcionario.nome = linha["no_func_baixa"].ToString();
                funcionario.no_funcao = linha["no_funcao_baixa"].ToString();
                requisicao.funcionario.Add(funcionario);

                listaRequisicao.Add(requisicao);
            }

            Conexao.con().Close();

            return listaRequisicao;
        }
        public static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return (null);
            }

            return (Image.FromStream(new MemoryStream(byteArray)));
        }
    }
}
