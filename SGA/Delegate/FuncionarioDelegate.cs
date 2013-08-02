using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Entity;
using SGA.Facade;
using System.Collections;

namespace SGA.Delegate
{
    class FuncionarioDelegate
    {

        FuncionarioFacade i_funcionarioFacade = new FuncionarioFacade();

        internal FuncionarioFacade funcionarioFacade
        {
            get { return i_funcionarioFacade; }
            set { i_funcionarioFacade = value; }
        }

        public Funcionario Logar(Funcionario func)
        {
            FuncionarioFacade funcionarioFacade = new FuncionarioFacade();

            return funcionarioFacade.Logar(func);
        }

        public void inserirFuncionario(Funcionario func)
        {
            funcionarioFacade.inserirFuncionario(func);
        }

        public void inserirSenha(Funcionario func) 
        {
            funcionarioFacade.inserirSenha(func);
        }

        public void redefinirSenha(Funcionario func)
        {
            funcionarioFacade.redefinirSenha(func);
        }

        public void editarFuncionario(Funcionario edFuncionario)
        {
            funcionarioFacade.editarFuncionario(edFuncionario);
        }

        public void manterFuncao(string comando, string valorAntigo, string novoValor)
        {
            funcionarioFacade.manterFuncao(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxFuncao()
        {
            return funcionarioFacade.preencherCbxFuncao();
        }

        public Queue preencherCbxPermissao()
        {
            return funcionarioFacade.preencherCbxPermissao();
        }

        public Queue pesquisaFuncionario(Funcionario func)
        {
            return funcionarioFacade.pesquisaFuncionario(func);
        }


        public void desativaFuncionario(Funcionario funcionario)
        {
            funcionarioFacade.desativaFuncionario(funcionario);
        }

        public string setDateTimerPicker()
        {
            return funcionarioFacade.setDateTimerPicker();
        }
    }
}
