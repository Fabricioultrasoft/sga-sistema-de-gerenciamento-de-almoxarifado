using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Entity;
using SGA.Delegate;
using SGA.Telas;
using SGA.Properties;
using SGA.Dao;
using System.Windows.Threading;

namespace SGA
{
    public partial class Login : Form
    {
        private ToolTip i_toolTip = new ToolTip();
        private Funcionario i_funcionario;

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogar;
            //this.btnLogar.DialogResult = DialogResult.OK;
        }

        public ToolTip toolTip
        {
            get { return i_toolTip; }
            set { i_toolTip = value; }
        }

        public Funcionario funcionario
        {
            get { return i_funcionario; }
            set { i_funcionario = value; }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem("Deseja sair do aplicativo?", "confirma", SGA.Properties.Resources.atencao);
            mensagem.ShowDialog();
            if (mensagem.DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        
        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos(""))
                {
                    Funcionario objfuncionario = new Funcionario();
                    objfuncionario.matricula = Convert.ToInt16(tbxMatricula.Text);
                    objfuncionario.senha = Criptografia.Encrypt(tbxSenha.Text);

                    FuncionarioDelegate funcionarioDelegate = new FuncionarioDelegate();
                    funcionario = funcionarioDelegate.Logar(objfuncionario);
                                                        
                        if (String.IsNullOrEmpty(funcionario.senha))
                        {
                            new Mensagem("Por favor!\n Cadastre uma senha!", "informacao", Resources.erro).ShowDialog();
                            CLogin CadLogin = new CLogin(funcionario);
                            CadLogin.ShowDialog();
                            tbxSenha.Clear();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }                        
                    
                }
            }
            catch (Exception erro)
            {
                Mensagem mensagem = new Mensagem(erro.Message, "informacao", Resources.erro);
                mensagem.ShowDialog();
            }

        }

        private bool validarCampos(string campo)
        {
            bool retorno = true;

            if (campo != "senha")
            {
                pictBErroMat.Visible = false;
                if (tbxMatricula.Text == "")
                {
                    exibirErro(pictBErroMat, "Campos obrigatórios em branco! Por favor preencha!");
                    retorno = false;
                }
                else
                {
                    try
                    {
                        int matricula = Convert.ToInt32(tbxMatricula.Text);
                    }
                    catch
                    {
                        exibirErro(pictBErroMat, "Insira no campo matrícula apenas números!");
                    }

                }

            }
            if (campo != "matricula")
                if (tbxSenha.Text == "")
                {
                    exibirErro(pictBErroSenha, "Campos obrigatórios em branco! Por favor preencha!");
                    retorno = false;
                }
                else if (tbxSenha.TextLength < 6)
                {
                    exibirErro(pictBErroSenha, "Tamanho de senha inválido! Insira uma senha com o mínimo de seis caracteres!");
                    retorno = false;
                }
                else
                {
                    pictBErroSenha.Visible = false;
                }
            return retorno;
        }

        private void tbxMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e, tbxMatricula.Text.Length);
        }

        public static void apenasNumeros(KeyPressEventArgs e, int tamanho)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
            {
                e.Handled = true;//Não permitir
            }
            //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..
        }

        private void tbxMatricula_Leave(object sender, EventArgs e)
        {
            validarCampos("matricula");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictBErroMat.Visible = false;
            pictBErroSenha.Visible = false;
            this.ControlBox = false;
        }
        public void exibirErro(Control control, string texto)
        {
            control.Visible = true;
            int contador = 0;
            toolTip.SetToolTip(control, texto);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();

            dispatcherTimer.Tick += (sender, e) =>
            {
                if (contador >= 3)
                    ((DispatcherTimer)sender).Stop();
                contador++;
                if (!control.Visible)
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 450);
            dispatcherTimer.Start();

        }

        private void tbxSenha_Leave(object sender, EventArgs e)
        {
            validarCampos("senha");
        }

        private void tbxMatricula_Enter(object sender, EventArgs e)
        {
            pictBErroMat.Visible = false;
        }

        private void tbxSenha_Enter(object sender, EventArgs e)
        {
            pictBErroSenha.Visible = false;
        }

        private void tbxMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
