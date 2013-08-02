using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGA.Entity
{
    public class Funcionario
    {
        private int i_matricula;
        private string i_nome;
        private DateTime i_dt_ins_funcionario;
        private string i_senha;
        private string i_ativo;
        private string i_no_permissao;
        private string i_no_funcao;
        private int i_nu_seq_funcao;
        private int i_nu_seq_permissao;
        private int i_nu_seq_usuario;
        private string[] i_periodo = { "", "" };
        private string i_chaveUsuario;
        
        public int matricula
        {
            get { return i_matricula; }
            set { i_matricula = value; }
        }

        public string nome
        {
            get { return i_nome; }
            set { i_nome = value; }
        }

        public DateTime dt_ins_funcionario
        {
            get { return i_dt_ins_funcionario; }
            set { i_dt_ins_funcionario = value; }
        }
        
        public string senha
        {
            get { return i_senha; }
            set { i_senha = value; }
        }

        public string ativo
        {
            get { return i_ativo; }
            set { i_ativo = value; }
        }
        
        public string no_permissao
        {
            get { return i_no_permissao; }
            set { i_no_permissao = value; }
        }

        public string no_funcao
        {
            get { return i_no_funcao; }
            set { i_no_funcao = value; }
        }

        public int nu_seq_funcao
        {
            get { return i_nu_seq_funcao; }
            set { i_nu_seq_funcao = value; }
        }

        public int nu_seq_permissao
        {
            get { return i_nu_seq_permissao; }
            set { i_nu_seq_permissao = value; }
        }

        public int nu_seq_usuario
        {
            get { return i_nu_seq_usuario; }
            set { i_nu_seq_usuario = value; }
        }

        public string[] periodo
        {
            get { return i_periodo; }
            set { i_periodo = value; }
        }

        public string chaveUsuario
        {
            get { return i_chaveUsuario; }
            set { i_chaveUsuario = value; }
        }
    }
}
