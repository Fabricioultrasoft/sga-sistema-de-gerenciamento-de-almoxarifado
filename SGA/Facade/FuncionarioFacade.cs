using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Entity;
using SGA.AplicationService;
using System.Collections;

namespace SGA.Facade
{
    class FuncionarioFacade
    {
        FuncionarioAS i_funcionarioAs = new FuncionarioAS();

        internal FuncionarioAS funcionarioAs
        {
            get { return i_funcionarioAs; }
            set { i_funcionarioAs = value; }
        }

        public Funcionario Logar(Funcionario func)
        {
            FuncionarioAS funcionarioAs = new FuncionarioAS();

            return funcionarioAs.Logar(func);
        }

        public void inserirFuncionario(Funcionario func)
        {
            funcionarioAs.inserirFuncionario(func);
        }

        public void inserirSenha(Funcionario func) 
        {
            funcionarioAs.inserirSenha(func);
        }

        public void redefinirSenha(Funcionario func)
        {
            funcionarioAs.redefinirSenha(func);
        }

        public void editarFuncionario(Funcionario edFuncionario)
        {
            funcionarioAs.editarFuncionario(edFuncionario);
        }

        public void manterFuncao(string comando, string valorAntigo, string novoValor)
        {
            funcionarioAs.manterFuncao(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxFuncao()
        {
            return funcionarioAs.preencherCbxFuncao();
        }

        public Queue preencherCbxPermissao()
        {
            return funcionarioAs.preencherCbxpermissao();
        }

        public Queue pesquisaFuncionario(Funcionario func)
        {
            return funcionarioAs.pesquisaFuncionario(func);
        }

        public void desativaFuncionario(Funcionario funcionario)
        {
            funcionarioAs.desativaFuncionario(funcionario);
        }

        public string setDateTimerPicker()
        {
            return funcionarioAs.setDateTimerPicker();
        }
    }
}
