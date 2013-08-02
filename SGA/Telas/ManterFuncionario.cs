using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SGA.Delegate;
using SGA.Properties;
using SGA.Entity;

namespace SGA.Telas
{
    public partial class ManterFuncionario : Form
    {
        private string i_tipoTela;
        private ToolTip toolTip = new ToolTip();
        Funcionario objFuncionario = new Funcionario();

        private FuncionarioDelegate funcionarioD = new FuncionarioDelegate();

        public ManterFuncionario(string tipo, Funcionario func)
        {
            tipoTela = tipo;
            objFuncionario = func;
            InitializeComponent();
            //montarTela();
        }

        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }


        #region Montar Tela

        public void montarTela()
        {
            if (objFuncionario != null)
            {
                if (objFuncionario.matricula == 0)
                {
                    tbxMatricula.Text = "";
                }
                else
                {
                    tbxMatricula.Text = objFuncionario.matricula + "";
                }
                tbxNome.Text = objFuncionario.nome;
                cbxFuncao.Text = objFuncionario.no_funcao;
                cbxPermissao.Text = objFuncionario.no_permissao;
            }
            preencherCbxFuncao();
            preencherPermissao();

            setarToolTip();

            if (tipoTela == "Edicao")
            {
                this.tbxNome.Enabled = true;
                this.cbxFuncao.Enabled = true;
                this.cbxPermissao.Enabled = true;
                this.btnSalvar.Text = "Salvar";
                this.btnSalvar.Image = SGA.Properties.Resources._1370629123_button_30;
                gbxFuncionario.Text = "Editar Funcionário";
                tbxMatricula.Enabled = false;
            }
            else if (tipoTela == "adicionar")
            {
                btnRedefinirSenha.Visible = false;
                btnSalvar.Enabled = false;
                btnSalvar.Text = "Editar";
                btnSalvar.Image = SGA.Properties.Resources._1370637407_user_male_edit;
                btnAddFuncao.Visible = false;
                gbxFuncionario.Text = "Detalhes";
                tbxMatricula.Enabled = false;
                tbxNome.Enabled = false;
                cbxFuncao.Enabled = false;
                cbxPermissao.Enabled = false;
                
            }
            else if (tipoTela == "Detalhes")
            {
                btnSalvar.Text = "Editar";
                btnSalvar.Image = SGA.Properties.Resources._1370637407_user_male_edit;
                btnAddFuncao.Visible = false;
                gbxFuncionario.Text = "Detalhes";
                tbxMatricula.Enabled = false;
                tbxNome.Enabled = false;
                cbxFuncao.Enabled = false;
                cbxPermissao.Enabled = false;
            }
            
        }

        private void setarToolTip()
        {
            toolTip.SetToolTip(tbxMatricula, "Mátricula!");
            toolTip.SetToolTip(tbxNome, "Nome!");
            toolTip.SetToolTip(cbxFuncao, "Função!");
            toolTip.SetToolTip(cbxPermissao, "Permissão!");
            toolTip.SetToolTip(btnAddFuncao, "Opções!");
            toolTip.SetToolTip(btnCancelar, "Cancelar!");
            toolTip.SetToolTip(btnSalvar, "Salvar Funcionario!");
        }

        #endregion
        #region Registro de Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbxMatricula.Text != "" || tbxNome.Text != "")
            {
                Mensagem mensagem = new Mensagem("Deseja descartar as informações?", "confirma", SGA.Properties.Resources.atencao);
                mensagem.ShowDialog();
                if (mensagem.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (tipoTela == "Edicao")
            {
                if (MessageBox.Show("Deseja desativar permanentemente o funcionário?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoTela == "Detalhes")
            {
                tipoTela = "Edicao";
                montarTela();
            }
            else
                if (tbxMatricula.Text == "" || tbxNome.Text == "" || cbxFuncao.Text == "" || cbxPermissao.Text == "")
                {
                    new Mensagem("Campos obrigatórios em branco! \n Por favor preencha!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                }
                else
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.matricula = Convert.ToInt32(tbxMatricula.Text);
                    funcionario.nome = tbxNome.Text;
                    funcionario.no_funcao = cbxFuncao.Text;
                    funcionario.no_permissao = cbxPermissao.Text;
                    if (tipoTela != "Edicao")
                    {


                        {
                            try
                            {

                                funcionarioD.inserirFuncionario(funcionario);
                                new Mensagem("Registro salvo com sucesso!", "informacao", Resources.ok).ShowDialog();
                                objFuncionario = new Funcionario();
                                montarTela();
                            }
                            catch (Exception erro)
                            {
                                new Mensagem(erro.Message, "informacao", SGA.Properties.Resources.erro).ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        funcionarioD.editarFuncionario(funcionario);
                        new Mensagem("Registro alterado com sucesso!", "informacao", Resources.ok).ShowDialog();
                        this.Close();
                    }
                }
        }


        private void btnAddFuncao_Click(object sender, EventArgs e)
        {

        }

        private void tbxMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void btnOpcaoFuncao_Click(object sender, EventArgs e)
        {
            EditarComboBox telaEditar = new EditarComboBox("funcao");
            telaEditar.ShowDialog();
            preencherCbxFuncao();
        }
        #endregion

        #region Métodos

        public static void apenasNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir
            //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..
        }

        #endregion

        public void preencherCbxFuncao()
        {
            Queue funcoes = funcionarioD.preencherCbxFuncao();
            cbxFuncao.Items.Clear();
            while (funcoes.Count != 0)
            {
                cbxFuncao.Items.Add(funcoes.Dequeue().ToString());
            } if (tipoTela == "Edicao")
            {
                this.cbxFuncao.SelectedIndex = cbxFuncao.Items.IndexOf(objFuncionario.no_funcao);
            }
            else
            {
                cbxFuncao.SelectedIndex = 0;
            }
        }

        private void ManterFuncionario_Load(object sender, EventArgs e)
        {
            montarTela();
        }

        private void preencherPermissao()
        {
            Queue permissao = funcionarioD.preencherCbxPermissao();
            cbxPermissao.Items.Clear();
            while (permissao.Count != 0)
            {
                cbxPermissao.Items.Add(permissao.Dequeue().ToString());
            } if (tipoTela != "Edicao")
            {
                cbxPermissao.SelectedIndex = 0;

            }
            else
            {
                this.cbxPermissao.SelectedIndex = cbxPermissao.Items.IndexOf(objFuncionario.no_permissao);

            }
        }

        private void ManterFuncionario_Load_1(object sender, EventArgs e)
        {
            montarTela();
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            FuncionarioDelegate funcionarioDel = new FuncionarioDelegate();
            funcionarioDel.redefinirSenha(objFuncionario);
            new Mensagem("Senha redefinida!", "informacao", Resources.ok).ShowDialog();
            this.Close();
        }
    }
}
