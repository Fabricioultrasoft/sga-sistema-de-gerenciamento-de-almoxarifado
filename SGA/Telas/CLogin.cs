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
            if (tbxSenha.Text == tbxCSenha.Text)
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
    }
}
