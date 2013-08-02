using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGA.Entity;

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

            SqlCommand selectRequisicao = new SqlCommand("SELECT [nu_seq_requisicao], [dt_baixa_requisicao], [dt_saida_requisicao], [fk_func_saida_ferr], [fk_ferramenta]" +
            ",[fk_func_baixa_ferr], [fk_func_requisitante], de.no_ferramenta, f.imagem  FROM [sga].[dbo].[tb_requisicao] r INNER JOIN tb_ferramenta f " +
            "ON(fk_ferramenta = f.cod_ferramenta) INNER jOIN tb_descricao_ferramenta de ON(fk_descricao_ferramenta = de.nu_seq_descricao)", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectRequisicao.ExecuteReader();
            while (linha.Read())
            {
                requisicao = new Requisicao();

                requisicao.codRequisicao = Convert.ToInt32(linha["nu_seq_requisicao"]);
                if (linha["dt_baixa_requisicao"].ToString() != "")
                    requisicao.dtBaixa = Convert.ToDateTime(linha["dt_baixa_requisicao"]);
                requisicao.dtRequisicao = Convert.ToDateTime(linha["dt_saida_requisicao"]);
                ferramenta.codFerramenta = linha["cod_requisicao"].ToString();
            }

            Conexao.con().Close();

            return listaRequisicao;
        }
    }
}
