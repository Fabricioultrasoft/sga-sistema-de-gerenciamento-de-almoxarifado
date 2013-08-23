using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Entity;
using SGA.Dao;
using System.Collections;

namespace SGA.AplicationService
{
    class FuncionarioAS
    {
        private FuncionarioDao i_funcionarioDao = new FuncionarioDao();

        internal FuncionarioDao funcionarioDao
        {
            get { return i_funcionarioDao; }
            set { i_funcionarioDao = value; }
        }

        public Funcionario Logar(Funcionario func)
        {
            Funcionario funcionario = funcionarioDao.Logar(func);

            if (funcionario.nome == "cadastrar senha")
            {
                //
            }
            else
            {
                if (funcionario.matricula == 0 || funcionario.matricula != 0 && funcionario.senha == "invalida")
                {
                    throw new System.ArgumentException("Matrícula e/ou Senha inválidos! \n Entre novamente com os dados!");
                }

                if (funcionario.ativo == "0")
                {
                    throw new System.ArgumentException("Usuário desativado! \n Contate o departamento \n  de Recursos Humanos!");
                }
            }
            
            return funcionario;
        }

        public void inserirSenha(Funcionario func) 
        {
            funcionarioDao.inserirSenha(func);
        }

        public void redefinirSenha(Funcionario func)
        {
            funcionarioDao.redefinirSenha(func);
        }

        public void inserirFuncionario(Funcionario func)
        {
            if (i_funcionarioDao.testFuncionarioMatricula(func))
            {
                funcionarioDao.inserirFuncionario(func);
            }
            else
            {
                throw new System.ArgumentException("A matrícula ja existe no banco!");
            }
        }

        public void editarFuncionario(Funcionario edFuncionario)
        {
            funcionarioDao.editarFuncionario(edFuncionario);
        }

        public void manterFuncao(string comando, string valorAntigo, string novoValor)
        {
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            funcionarioDao.manterFuncao(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxFuncao()
        {
            return i_funcionarioDao.preencherCbxFuncao();
        }

        public Queue preencherCbxpermissao()
        {
            return i_funcionarioDao.preencherCbxPermissao();
        }

          public Queue pesquisaFuncionario(Funcionario func)
        {
            return funcionarioDao.pesquisaFuncionario(func);
        }

          public void desativaFuncionario(Funcionario funcionario)
          {
              if (funcionarioDao.testFuncionarioPendencia(funcionario))
              {
                  funcionarioDao.desativaFuncionario(funcionario);
              }
              else
              {
                  throw new Exception("Funcionário com pendência\nimpossível excluir!");
              }
          }

          public string setDateTimerPicker()
          {
              return funcionarioDao.setDateTimerPicker();
          }
    }
}
