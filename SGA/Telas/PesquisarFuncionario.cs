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
using System.Collections;
using SGA.Properties;

namespace SGA.Telas
{
    public partial class PesquisarFuncionario : Form
    {

        private List<Funcionario> funcionarios = new List<Funcionario>();
        private Funcionario objPesquisaFunc = new Funcionario();
        public Funcionario objFuncionario = null;
        private Funcionario i_usuarioLogado;
        private string tipoTela = "";

        private FuncionarioDelegate funcionarioD = new FuncionarioDelegate();

        public PesquisarFuncionario(Funcionario func, string tipoT)
        {
            InitializeComponent();
            preencherCbxFuncao();
            preencherCbxPermissao();
            usuarioLogado = func;
            tipoTela = tipoT;
        }

        private void montarTela()
        {
            setDtpickers();
            if (tipoTela == "adicionar")
            {
                btnEditar.Visible = false;
                btnNFuncionario.Text = "Salvar seleção";
                btnNFuncionario.Image = SGA.Properties.Resources._1370629123_button_30;
                btnDesativar.Visible = false;
            }
            else if (usuarioLogado.no_permissao != "Administrador")
            {
                btnEditar.Visible = false;
                btnNFuncionario.Visible = false;
                btnDesativar.Visible = false;
            }
        }

        public Funcionario usuarioLogado
        {
            get { return i_usuarioLogado; }
            set { i_usuarioLogado = value; }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (tipoTela == "adicionar")
            {
                Mensagem mensagem = new Mensagem("Deseja cancelar \no procedimento atual?", "confirma", SGA.Properties.Resources.interrogacao);
                mensagem.ShowDialog();
                if (mensagem.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (objFuncionario == null)
            {
                new Mensagem("Selecione um item primeiro.", "informacao", Resources.atencao).ShowDialog();
            }
            else
            {
                ManterFuncionario telaEdicao = new ManterFuncionario("Edicao", objFuncionario, usuarioLogado);
                telaEdicao.ShowDialog();
                usuarioLogado = telaEdicao.funcionarioLogado;
                preencherListView();
                objFuncionario = null;
            }
        }

        private void btnNFuncionario_Click(object sender, EventArgs e)
        {
            if (tipoTela != "adicionar")
            {
                Funcionario func = new Funcionario();

                ManterFuncionario telaEdicao = new ManterFuncionario("Cadastro", func, usuarioLogado);
                telaEdicao.ShowDialog();
                usuarioLogado = telaEdicao.funcionarioLogado;
                preencherListView();
                objFuncionario = null;

            }
            else
            {
                if (objFuncionario == null)
                {
                    new Mensagem("Selecione um funcionário para prosseguir!", "informacao", Resources.atencao).ShowDialog();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (objFuncionario == null)
            {
                if (tipoTela != "adicionar")
                {
                    new Mensagem("Selecione um funcionário!", "informacao", Resources.atencao).ShowDialog();
                }
                else
                {
                    new Mensagem("Selecione um funcionário!", "informacao", Resources.atencao).ShowDialog();
                }

            }
            else
            {
                if (tipoTela != "adicionar")
                {
                    ManterFuncionario telaDetalhes = new ManterFuncionario("Detalhes", objFuncionario, usuarioLogado);
                    telaDetalhes.ShowDialog();
                    preencherListView();
                    objFuncionario = null;
                }
                else
                {
                    ManterFuncionario telaDetalhes = new ManterFuncionario("adicionar", objFuncionario, usuarioLogado);
                    telaDetalhes.ShowDialog();
                }
            }
        }

        private void manterFuncionario(string tipo)
        {
            ManterFuncionario mFunc = new ManterFuncionario(tipo, objFuncionario, usuarioLogado);
            mFunc.ShowDialog();
        }

        private void pesquisarFuncionario()
        {
            FuncionarioDelegate funcionarioDelegate = new FuncionarioDelegate();
            Queue arrayFuncionario = funcionarioDelegate.pesquisaFuncionario(objPesquisaFunc);
            funcionarios.Clear();

            while (arrayFuncionario.Count != 0)
            {
                funcionarios.Add((Funcionario)arrayFuncionario.Dequeue());
            }

        }

        private void preencherListView()
        {
            listVFuncionario.Items.Clear();
            pesquisarFuncionario();

            foreach (Funcionario fu in funcionarios)
            {
                var item = new ListViewItem(new[] { Convert.ToString(fu.matricula), fu.nome, fu.no_funcao, fu.no_permissao });
                listVFuncionario.Items.Add(item);
            }
        }

        private void listVFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVFuncionario.SelectedItems.Count != 0)
            {
                if (listVFuncionario.SelectedItems[0].Selected)
                {
                    foreach (Funcionario fu in funcionarios)
                    {
                        if (fu.matricula == Convert.ToInt32(listVFuncionario.SelectedItems[0].Text))
                        {
                            objFuncionario = fu;
                            break;
                        }
                    }
                }
            }

        }

        private void PesquisarFuncionario_Load(object sender, EventArgs e)
        {
            preencherListView();
            montarTela();
            this.ControlBox = false;
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (objFuncionario == null)
            {
                new Mensagem("Selecione um funcionário \n primeiro!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
            }
            else
            {
                Mensagem mensagem = new Mensagem("Desesa realmente excluir \no registro?", "senha", SGA.Properties.Resources.key);
                while (1 == 1)
                {
                    mensagem.tbxSenha.Text = "";
                    mensagem.ShowDialog();
                    try
                    {

                        if (mensagem.DialogResult == DialogResult.OK)
                        {
                            FuncionarioDelegate funcionarioDel = new FuncionarioDelegate();

                            Funcionario funcionario = usuarioLogado;

                            funcionario.senha = Criptografia.Encrypt(mensagem.texto);

                            funcionarioDel.Logar(funcionario);
                            objFuncionario.chaveUsuario = usuarioLogado.matricula + "";
                            FuncionarioDelegate funcionarioD = new FuncionarioDelegate();
                            funcionarioD.desativaFuncionario(objFuncionario);
                            new Mensagem("Funcionário desativado com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
                            usuarioLogado.alteracao = true;
                            break;

                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception erro)
                    {
                        if (erro.Message == "Matrícula e/ou Senha inválidos! \n Entre novamente com os dados!")
                        {
                            new Mensagem("Senha inválida!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
                        }
                        else
                        {
                            new Mensagem(erro.Message, "informacao", SGA.Properties.Resources.erro).ShowDialog();
                            break;
                        }

                    }
                }
            }
            objFuncionario = null;
            montarTela();
            preencherListView();
        }

        private void preencherCbxFuncao()
        {
            Queue funcao = funcionarioD.preencherCbxFuncao();
            cbxFuncao.Items.Clear();
            cbxFuncao.Items.Add("");
            while (funcao.Count != 0)
            {
                cbxFuncao.Items.Add(funcao.Dequeue().ToString());
            }
        }

        private void preencherCbxPermissao()
        {
            Queue permissao = funcionarioD.preencherCbxPermissao();
            cbxPermissao.Items.Clear();
            cbxPermissao.Items.Add("");
            while (permissao.Count != 0)
            {
                cbxPermissao.Items.Add(permissao.Dequeue().ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxMatricula.Text.Length > 0)
            {
                objPesquisaFunc.matricula = Convert.ToInt32(tbxMatricula.Text);
                preencherListView();
            }
            else
            {
                objPesquisaFunc.matricula = 0;
                preencherListView();
            }
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            objPesquisaFunc.nome = tbxNome.Text;
            preencherListView();
        }

        private void cbxFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaFunc.no_funcao = cbxFuncao.SelectedItem.ToString();
            preencherListView();
        }

        private void cbxPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaFunc.no_permissao = cbxPermissao.SelectedItem.ToString();
            preencherListView();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxMatricula.Clear();
            tbxNome.Clear();
            cbxFuncao.Text = "";
            cbxPermissao.Text = "";
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

        private void dtpickerInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerInicio.Value > dtpickerFinal.Value)
            {
                new Mensagem("A data inicial deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerFinal.Value = dtpickerInicio.Value.AddDays(1);
            }
            objPesquisaFunc.periodo[0] = dtpickerInicio.Value.ToString();
            objPesquisaFunc.periodo[1] = dtpickerFinal.Value.ToString();
            preencherListView();
        }

        private void dtpickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerFinal.Value < dtpickerInicio.Value)
            {
                new Mensagem("A data final deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerInicio.Value = dtpickerFinal.Value.AddDays(-1);
            }
            objPesquisaFunc.periodo[0] = dtpickerInicio.Value.ToString();
            objPesquisaFunc.periodo[1] = dtpickerFinal.Value.ToString();
            preencherListView();
        }

        private void setDtpickers()
        {
            if (funcionarioD.setDateTimerPicker() != "")
            {
                dtpickerInicio.Enabled = true;
                dtpickerFinal.Enabled = true;
                dtpickerInicio.MinDate = Convert.ToDateTime(funcionarioD.setDateTimerPicker());
                dtpickerInicio.Value = dtpickerInicio.MinDate;
                dtpickerFinal.MinDate = dtpickerInicio.MinDate.AddDays(1);
                
                DateTime data = Convert.ToDateTime(System.DateTime.Now);

                if (dtpickerInicio.MinDate.ToString("yyyy-MM-dd") == data.ToString("yyyy-MM-dd"))
                {
                    dtpickerFinal.MaxDate = dtpickerFinal.MinDate.AddDays(1);
                }
                else
                {
                   dtpickerFinal.MaxDate = data;
                }

                dtpickerInicio.MaxDate = dtpickerFinal.MaxDate.AddDays(-1);
                dtpickerFinal.Value = dtpickerFinal.MaxDate;
            }
            else
            {
                dtpickerFinal.Enabled = false;
                dtpickerInicio.Enabled = false;
            }
        }

        private void btnRedPeriodo_Click(object sender, EventArgs e)
        {
            setDtpickers();
        }
    }
}
