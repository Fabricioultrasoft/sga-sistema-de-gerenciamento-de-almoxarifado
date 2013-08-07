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
                Conexao.gravarLog("Cadastro", requisicao.funcionario[0].matricula + "", requisicao.funcionario[1].matricula + "", ferramenta.codFerramenta, "Gravar");
            }
        }

        public List<Requisicao> pesquisarRequisicao(Requisicao objRequisicao)
        {
            string condicoes = "";

            if(objRequisicao.codRequisicao != 0)
            {
                condicoes += " AND nu_seq_requisicao LIKE('%" + objRequisicao.codRequisicao + "%')"; 
            }

            if (objRequisicao.ferramentas[0].codFerramenta != "" )
            {
                condicoes += " AND fk_ferramenta LIKE('%" + objRequisicao.ferramentas[0].codFerramenta + "%')";
            }

            if (objRequisicao.funcionario[0].matricula != 0)
            {
                condicoes += " AND fk_func_saida_ferr LIKE('%" + objRequisicao.funcionario[0].matricula + "%')";
            }

            if (objRequisicao.funcionario[1].matricula != 0)
            {
                condicoes += " AND fk_func_baixa_ferr LIKE('%" + objRequisicao.funcionario[1].matricula + "%')";
            }

            if (objRequisicao.funcionario[2].matricula != 0)
            {
                condicoes += " AND fk_func_requisitante LIKE('%" + objRequisicao.funcionario[2].matricula + "%')";
            }

            if (objRequisicao.situacao + "" != "")
            {
                if (objRequisicao.situacao == "Abertas")
                {
                    condicoes += " AND dt_baixa_requisicao IS NULL";
                }
                else
                {
                    condicoes += " AND dt_baixa_requisicao IS NOT NULL";
                }
            }

            if (objRequisicao.tipoPeriodo + "" != "")
            {
                if (objRequisicao.tipoPeriodo == "Baixa")
                {
                    condicoes += " AND dt_baixa_requisicao between '" + objRequisicao.periodo[0] + "' AND '" + objRequisicao.periodo[1] + "'";
                }
                else
                {
                    condicoes += " AND dt_saida_requisicao between '" + objRequisicao.periodo[0] + "' AND '" + objRequisicao.periodo[1] + "'";
                }
            }

            List<Requisicao> listaRequisicao = new List<Requisicao>();
            Requisicao requisicao;
            Ferramenta ferramenta = new Ferramenta();
            Funcionario funcionario;

            SqlCommand selectRequisicao = new SqlCommand("SELECT nu_seq_requisicao, fk_ferramenta,gr.no_grupo, fa.no_fabricante, de.no_ferramenta, f.imagem , dt_saida_requisicao, dt_baixa_requisicao , fk_func_requisitante" +
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
      "     INNER JOIN tb_fabricante fa ON(fk_fabricante = fa.nu_seq_fabricante)" +
      "      INNER jOIN tb_descricao_ferramenta de ON(fk_descricao_ferramenta = de.nu_seq_descricao) " +
      "     INNER JOIN tb_grupo_ferramenta gr ON(fk_grupo = nu_seq_grupo)" +
      " WHERE 1 = 1" + condicoes, Conexao.con());

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
                ferramenta.codFabricante = linha["no_fabricante"].ToString();
                ferramenta.codGrupo = linha["no_grupo"].ToString();

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

        public string setDateTimerPicker()
        {
            string timer = "";

            SqlCommand selectTimer = new SqlCommand("SELECT MIN([dt_saida_requisicao]) as min FROM tb_requisicao", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectTimer.ExecuteReader();

            if (linha.Read())
                timer = linha["min"].ToString();

            Conexao.con().Close();

            return timer;
        }

        public void finalizarRequisicao(Requisicao requisicao)
        {
            SqlCommand updateFerramenta = new SqlCommand("UPDATE tb_ferramenta SET fk_situacao = 1 WHERE cod_ferramenta = @cod_ferramenta", Conexao.con());

            updateFerramenta.Parameters.AddWithValue("@cod_ferramenta", requisicao.ferramentas[0].codFerramenta);

            SqlCommand updade = new SqlCommand("UPDATE tb_requisicao SET dt_baixa_requisicao = CURRENT_TIMESTAMP,fk_func_baixa_ferr = @mat_func_baixa " +
            "WHERE nu_seq_requisicao = @cod_requisicao", Conexao.con());
            updade.Parameters.AddWithValue(@"mat_func_baixa", requisicao.funcionario[2].matricula);
            updade.Parameters.AddWithValue(@"cod_requisicao", requisicao.codRequisicao);

            Conexao.con().Open();
            updateFerramenta.ExecuteNonQuery();
            updade.ExecuteNonQuery();

            Conexao.con().Close();
            Conexao.gravarLog("Requisição finalizada", requisicao.funcionario[2].matricula + "", requisicao.funcionario[1].matricula + "", requisicao.ferramentas[0].codFerramenta, requisicao.funcionario[2].matricula + "");
        }
    }
}
