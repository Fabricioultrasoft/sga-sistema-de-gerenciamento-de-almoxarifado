using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Delegate;
using SGA.Entity;
using SGA.Properties;

namespace SGA.Telas
{
    public partial class CLogin : Form
    {
        public Funcionario func = new Funcionario();
        public CLogin(Funcionario funcionario)
        {
            
            func = funcionario;
            InitializeComponent();
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            if (tbxSenha.Text == "" || tbxCSenha.Text == "")
            {
                new Mensagem("Campo(s) obrigatório(s) em branco!", "informacao", Resources.erro).ShowDialog();
            }
            else if (tbxSenha.TextLength < 6)
            {
                new Mensagem("A senha deve ter no mínimo\nseis(6) caracteres", "informacao", Resources.erro).ShowDialog();
            }
            else if (tbxSenha.Text == tbxCSenha.Text)
            {
                try
                {
                    func.senha = Criptografia.Encrypt(tbxSenha.Text);
                    FuncionarioDelegate funcionarioDel = new FuncionarioDelegate();
                    funcionarioDel.inserirSenha(func);
                    new Mensagem("Senha cadastrada com sucesso!", "informacao", Resources.ok).ShowDialog();
                    this.Close();
                }
                catch (Exception erro)
                {

                    new Mensagem(erro.Message, "informacao", Resources.erro).ShowDialog();
                }

            }
            else
            {
                new Mensagem("Senhas não conferem!", "informacao", Resources.erro).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem("Deseja cancelar o procedimento\natual?\nO mesmo é obrigatório\npara o acesso ao sistema.","confirma",SGA.Properties.Resources.interrogacao);
            mensagem.ShowDialog();
            if (mensagem.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void CLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
