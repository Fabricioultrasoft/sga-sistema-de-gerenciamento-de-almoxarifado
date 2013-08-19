using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGA.Entity;
using System.Windows.Forms;
using System.Collections;

namespace SGA.Dao
{
    class FuncionarioDao
    {
        public void inserirFuncionario(Funcionario func)
        {
            SqlCommand insertFuncionario = new SqlCommand("INSERT INTO tb_funcionario" +
                                                    "(mat_funcionario, no_funcionario, dt_ins_funcionario, fk_funcao, ativo)" +
                                                    "VALUES (@matricula, @nome, current_timestamp, (SELECT nu_seq_funcao FROM tb_funcao WHERE no_funcao = @no_funcao), '1')", Conexao.con());


            SqlCommand insertUsuario = new SqlCommand("INSERT INTO tb_usuario (senha_usuario, fk_funcionario, fk_permissao) VALUES" +
                                                   "('', @fk_funcionario, (SELECT nu_seq_permissao FROM tb_permissao WHERE no_permissao = @no_permissao))", Conexao.con());

            //Alterar pois isso dará origem a uma outro processo!

            insertFuncionario.Parameters.AddWithValue("@matricula", func.matricula);
            insertFuncionario.Parameters.AddWithValue("@nome", func.nome);
            insertFuncionario.Parameters.AddWithValue(@"no_funcao", func.no_funcao);
            insertUsuario.Parameters.AddWithValue("@fk_funcionario", func.matricula);
            insertUsuario.Parameters.AddWithValue(@"no_permissao", func.no_permissao);


            Conexao.con().Open();
            insertFuncionario.ExecuteNonQuery();
            insertUsuario.ExecuteNonQuery();
            Conexao.con().Close();
            Conexao.gravarLog("Cadastro", func.chaveUsuario, func.matricula + "", "", "");
        }

        public void inserirSenha(Funcionario func)
        {
            SqlCommand insertUsuario = new SqlCommand("UPDATE tb_usuario SET senha_usuario = @senha WHERE fk_funcionario = @fk_funcionario", Conexao.con());

            insertUsuario.Parameters.AddWithValue("@fk_funcionario", func.matricula);
            insertUsuario.Parameters.AddWithValue("@senha", func.senha);

            Conexao.con().Open();
            insertUsuario.ExecuteNonQuery();
            Conexao.con().Close();
        }

        public void redefinirSenha(Funcionario func)
        {
            SqlCommand updateSenha = new SqlCommand("UPDATE tb_usuario SET senha_usuario = '' WHERE fk_funcionario = @fk_funcionario", Conexao.con());

            updateSenha.Parameters.AddWithValue("@fk_funcionario", func.matricula);

            Conexao.con().Open();
            updateSenha.ExecuteNonQuery();
            Conexao.con().Close();
            Conexao.gravarLog("Redefinição de senha", func.chaveUsuario, func.matricula + "", "", "");
        }

        public void editarFuncionario(Funcionario edFuncionario)
        {
            SqlCommand updateFuncionario = new SqlCommand("UPDATE tb_funcionario SET no_funcionario = @no_funcionario, fk_funcao = (SELECT nu_seq_funcao FROM tb_funcao WHERE no_funcao = @no_funcao) WHERE mat_funcionario = @matricula", Conexao.con());

            SqlCommand updateUsuario = new SqlCommand("UPDATE tb_usuario SET fk_permissao = (SELECT nu_seq_permissao FROM tb_permissao WHERE no_permissao = @no_permissao) WHERE fk_funcionario = @matricula", Conexao.con());

            updateFuncionario.Parameters.AddWithValue("@matricula", edFuncionario.matricula);
            updateFuncionario.Parameters.AddWithValue("@no_funcionario", edFuncionario.nome);
            updateFuncionario.Parameters.AddWithValue("@no_funcao", edFuncionario.no_funcao);
            updateUsuario.Parameters.AddWithValue("@matricula", edFuncionario.matricula);
            updateUsuario.Parameters.AddWithValue("@no_permissao", edFuncionario.no_permissao);

            Conexao.con().Open();
            updateFuncionario.ExecuteNonQuery();
            updateUsuario.ExecuteNonQuery();
            Conexao.con().Close();
            Conexao.gravarLog("Atualização", edFuncionario.chaveUsuario, edFuncionario.matricula + "", "", "");

        }

        public Funcionario Logar(Funcionario funcionario)
        {
            string senha = "";
            Funcionario func = new Funcionario();

            SqlCommand select = new SqlCommand("SELECT f.mat_funcionario, u.senha_usuario FROM tb_funcionario f INNER JOIN tb_usuario u ON (f.mat_funcionario = u.fk_funcionario) WHERE f.mat_funcionario = @matricula", Conexao.con());

            select.Parameters.AddWithValue("@matricula", funcionario.matricula);

            Conexao.con().Open();
            SqlDataReader ler = select.ExecuteReader();

            while (ler.Read())
            {
                func = new Funcionario();
                func.matricula = Convert.ToInt16(ler["mat_funcionario"]);
                func.senha = ler["senha_usuario"].ToString();
                senha = func.senha;
            }
            if (func.senha == "")
            {
                func.senha = "invalida";
            }
	
            ler.Close();
            Conexao.con().Close();

            if (!String.IsNullOrEmpty(senha))
            {
                SqlCommand select2 = new SqlCommand("SELECT f.mat_funcionario,f.no_funcionario," +
                                      "f.dt_ins_funcionario,f.fk_funcao,f.ativo," +
                                      "u.senha_usuario,u.fk_permissao,p.no_permissao,fu.no_funcao " +
                                      "FROM 	tb_funcionario f " +
                                           "INNER JOIN tb_usuario u ON(f.mat_funcionario = u.fk_funcionario) " +
                                           "INNER JOIN tb_permissao p ON(u.fk_permissao = p.nu_seq_permissao) " +
                                           "INNER JOIN tb_funcao fu ON(fu.nu_seq_funcao = f.fk_funcao)" +
                                           " WHERE f.mat_funcionario = @matricula AND u.senha_usuario = @senha", Conexao.con());

                select2.Parameters.AddWithValue("@matricula", funcionario.matricula);
                select2.Parameters.AddWithValue("@senha", funcionario.senha);
                
                Conexao.con().Open();
                SqlDataReader ler2 = select2.ExecuteReader();

                if (ler2.HasRows)
                {
                    while (ler2.Read())
                    {
                        func = new Funcionario();
                        func.matricula = Convert.ToInt16(ler2["mat_funcionario"]);
                        func.nome = ler2["no_funcionario"].ToString();
                        func.dt_ins_funcionario = Convert.ToDateTime(ler2["dt_ins_funcionario"]);
                        func.ativo = ler2["ativo"].ToString();
                        func.senha = ler2["senha_usuario"].ToString();
                        func.no_permissao = ler2["no_permissao"].ToString();
                        func.no_funcao = ler2["no_funcao"].ToString();
                    }
                    ler2.Close();
                    
                }
                else
                {
                    func.senha = "invalida";
                }
                Conexao.con().Close();
               
            }
            

            return func;
        }

        public void manterFuncao(string comando, string valorAntigo, string novoValor)
        {
            string comandoSQL = "";
            switch (comando)
            {
                case "insert":
                    {

                        comandoSQL = "INSERT INTO tb_funcao(no_funcao) VALUES('" + novoValor + "')";
                    }
                    break;
                case "delete":
                    {
                        comandoSQL = "DELETE FROM tb_funcao WHERE no_funcao = '" + valorAntigo + "'";
                    }
                    break;
                default:
                    {
                        comandoSQL = "UPDATE tb_funcao SET no_funcao = '" + novoValor + "' WHERE no_funcao = '" + valorAntigo + "'";
                    }
                    break;
            }

            if (comando == "delete")
            {
                SqlCommand select = new SqlCommand("SELECT f.mat_funcionario FROM tb_funcionario f INNER JOIN tb_funcao fu ON(f.fk_funcao = fu.nu_seq_funcao) WHERE fu.no_funcao = '" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                int matricula = 0;
                while (linha.Read())
                {
                    matricula = Convert.ToInt32(linha["mat_funcionario"]);
                }

                Conexao.con().Close();

                if (matricula != 0)
                {
                    throw new System.ArgumentException("           Operação cancelada!\n          O registro está em uso.");
                }
            }
            else
            {
                SqlCommand select = new SqlCommand("SELECT no_funcao FROM tb_funcao WHERE no_funcao = '" + novoValor + "' AND no_funcao <>'" + valorAntigo + "'", Conexao.con());

                Conexao.con().Open();

                SqlDataReader linha = select.ExecuteReader();

                string no_funcao = "0";
                while (linha.Read())
                {
                    no_funcao = linha["no_funcao"].ToString();
                }

                Conexao.con().Close();

                if (no_funcao != "0" && novoValor != valorAntigo)
                {
                    throw new System.ArgumentException("Funcao já existe!");
                }
            }

            SqlCommand comm = new SqlCommand(comandoSQL, Conexao.con());

            Conexao.con().Open();

            comm.ExecuteNonQuery();

            Conexao.con().Close();

        }

        public Queue preencherCbxFuncao()
        {
            Queue cbxFuncao = new Queue();

            SqlCommand selectFuncao = new SqlCommand("SELECT no_funcao FROM tb_funcao", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectFuncao.ExecuteReader();

            while (linha.Read())
            {
                cbxFuncao.Enqueue(linha["no_funcao"].ToString());
            }

            Conexao.con().Close();

            return cbxFuncao;
        }

        public Queue preencherCbxPermissao()
        {
            Queue cbxPermissao = new Queue();

            SqlCommand selectPermissao = new SqlCommand("SELECT no_permissao FROM tb_permissao", Conexao.con());

            Conexao.con().Open();

            SqlDataReader lerLinha = selectPermissao.ExecuteReader();

            while (lerLinha.Read())
            {
                cbxPermissao.Enqueue(lerLinha["no_permissao"].ToString());
            }

            Conexao.con().Close();
            return cbxPermissao;
        }

        public Queue pesquisaFuncionario(Funcionario func)
        {
            string codigo = "";

            if (func.matricula + "" != "0")
            {
                codigo = codigo + " AND f.mat_funcionario LIKE('%" + func.matricula + "%')";
            }

            if (func.nome + "" != "")
            {
                codigo = codigo + " AND f.no_funcionario LIKE('%" + func.nome + "%')";
            }

            if (func.no_funcao + "" != "")
            {
                codigo = codigo + " AND fu.no_funcao LIKE('%" + func.no_funcao + "%')";
            }

            if (func.no_permissao + "" != "")
            {
                codigo = codigo + " AND p.no_permissao LIKE('%" + func.no_permissao + "%')";
            }

            if (func.periodo[0] + "" != "")
            {
                codigo = codigo + " AND dt_ins_funcionario BETWEEN '" + Convert.ToDateTime(func.periodo[0]) + "' AND '" + Convert.ToDateTime(func.periodo[1]) + "'";
            }

            Queue arrayFuncionario = new Queue();

            SqlCommand selectFuncionario = new SqlCommand("SELECT f.mat_funcionario ,f.no_funcionario ,f.dt_ins_funcionario ,f.ativo" +
      ",fu.nu_seq_funcao,fu.no_funcao,u.nu_seq_usuario,p.nu_seq_permissao,p.no_permissao FROM tb_funcionario f INNER JOIN tb_funcao " +
      "fu ON(f.fk_funcao = fu.nu_seq_funcao) INNER JOIN tb_usuario u ON(f.mat_funcionario = u.fk_funcionario) INNER JOIN tb_permissao p" +
      " ON(u.fk_permissao = p.nu_seq_permissao) WHERE f.ativo <> '0' " + codigo, Conexao.con());


            Conexao.con().Open();
            SqlDataReader ler = selectFuncionario.ExecuteReader();


            while (ler.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.matricula = Convert.ToInt32(ler["mat_funcionario"]);
                funcionario.nome = ler["no_funcionario"].ToString();
                funcionario.dt_ins_funcionario = Convert.ToDateTime(ler["dt_ins_funcionario"]);
                funcionario.ativo = ler["ativo"].ToString();
                funcionario.nu_seq_funcao = Convert.ToInt16(ler["nu_seq_funcao"]);
                funcionario.no_funcao = Convert.ToString(ler["no_funcao"]);
                funcionario.nu_seq_usuario = Convert.ToInt16(ler["nu_seq_usuario"]);
                funcionario.nu_seq_permissao = Convert.ToInt16(ler["nu_seq_permissao"]);
                funcionario.no_permissao = ler["no_permissao"].ToString();

                arrayFuncionario.Enqueue(funcionario);
            }

            Conexao.con().Close();
            return arrayFuncionario;
        }

        public bool testFuncionarioPendencia(Funcionario funcionario)
        {
            bool retorno = true;

            SqlCommand select = new SqlCommand("SELECT mat_funcionario FROM tb_funcionario f INNER JOIN tb_requisicao r ON(f.mat_funcionario = r.fk_func_requisitante) WHERE f.mat_funcionario = @mat_funcionario AND fk_func_baixa_ferr is NULL", Conexao.con());

            select.Parameters.AddWithValue(@"mat_funcionario", funcionario.matricula);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["mat_funcionario"].ToString();
            }

            Conexao.con().Close();

            if (codigo != "")
            {
                retorno = false;
            }

            return retorno;
        }

        public void desativaFuncionario(Funcionario funcionario)
        {
            SqlCommand select = new SqlCommand("SELECT mat_funcionario FROM tb_funcionario f INNER JOIN tb_requisicao r ON(f.mat_funcionario = r.fk_func_requisitante) WHERE f.mat_funcionario = @mat_funcionario", Conexao.con());

            select.Parameters.AddWithValue(@"mat_funcionario", funcionario.matricula);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["mat_funcionario"].ToString();
            }

            Conexao.con().Close();

            if (codigo == "")
            {
                SqlCommand delete = new SqlCommand("DELETE FROM tb_funcionario WHERE mat_funcionario = @mat_funcionario", Conexao.con());

                SqlCommand deleteUsuario = new SqlCommand("DELETE FROM tb_usuario WHERE fk_funcionario = @fk_funcionario", Conexao.con());

                delete.Parameters.AddWithValue(@"mat_funcionario", funcionario.matricula);
                deleteUsuario.Parameters.AddWithValue("@fk_funcionario", funcionario.matricula);

                Conexao.con().Open();
                deleteUsuario.ExecuteNonQuery();
                delete.ExecuteNonQuery();

                Conexao.con().Close();
                Conexao.gravarLog("Exclusao", funcionario.chaveUsuario, funcionario.matricula + "", "", "");

            }
            else
            {
                SqlCommand desativa = new SqlCommand("UPDATE tb_funcionario SET ativo = '0' WHERE mat_funcionario = @mat_funcionario", Conexao.con());

                desativa.Parameters.AddWithValue(@"mat_funcionario", funcionario.matricula);

                Conexao.con().Open();

                desativa.ExecuteNonQuery();

                Conexao.con().Close();
                Conexao.gravarLog("Desativacao", funcionario.chaveUsuario, funcionario.matricula + "", "", "");

            }

        }

        public string setDateTimerPicker()
        {
            string timer = "";

            SqlCommand selectTimer = new SqlCommand("SELECT MIN([dt_ins_funcionario]) as min FROM tb_funcionario", Conexao.con());

            Conexao.con().Open();

            SqlDataReader linha = selectTimer.ExecuteReader();

            if (linha.Read())
                timer = linha["min"].ToString();

            Conexao.con().Close();

            return timer;
        }

        public bool testFuncionarioMatricula(Funcionario func)
        {
            bool retorno = true;

            SqlCommand select = new SqlCommand("SELECT mat_funcionario FROM tb_funcionario WHERE mat_funcionario = @matricula ", Conexao.con());

            select.Parameters.AddWithValue(@"matricula", func.matricula);

            string codigo = "";

            Conexao.con().Open();

            SqlDataReader linha = select.ExecuteReader();

            if (linha.Read())
            {
                codigo = linha["mat_funcionario"].ToString();
            }

            Conexao.con().Close();

            if (codigo != "")
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
