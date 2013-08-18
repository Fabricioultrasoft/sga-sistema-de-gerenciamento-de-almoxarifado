using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Telas;
using SGA.Properties;
using SGA.Entity;
using SGA.Dao;

namespace SGA
{
    public partial class Menu : Form
    {
        private Funcionario i_funcionario;

        public Menu(Funcionario func)
        {
            InitializeComponent();
            funcionario = func;
        }

        private void montarTela()
        {
            if (funcionario.no_permissao == "Atendente")
            {
                menuItemNFuncionario.Visible = false;
                menuItemNFerramenta.Visible = false;
                MenuItmRelatorios.Visible = false;
               
            } if (funcionario.no_permissao == "Usuario_comum")
            {
                menuItemNFuncionario.Visible = false;
                menuItemNFerramenta.Visible = false;
                menuItemlFuncionario.Text = "Detalhes";
                MenuItmRelatorios.Visible = false;
                menuItmNRequisição.Visible = false;
            }
        }

        public Funcionario funcionario
        {
            get { return i_funcionario; }
            set { i_funcionario = value; }
        }

        #region Registro de Eventos

        #region Itens do Menu
        private void MenuItmSair_Click(object sender, EventArgs e)
        {
            Mensagem mensagen = new Mensagem("Deseja sair do aplicativo?", "confirma", Resources.interrogacao);
            
            if (mensagen.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MenuItmLogoff_Click(object sender, EventArgs e)
        {
            Mensagem mensagen = new Mensagem("Deseja continuar?", "confirma", Resources.interrogacao);
            if (mensagen.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void menuItemNFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            ManterFuncionario cadastrofunc = new ManterFuncionario("Cadastro", objFuncionario, funcionario);
            cadastrofunc.ShowDialog();
            funcionario = cadastrofunc.funcionarioLogado;
        }

        private void MenuItemNFerramenta_Click(object sender, EventArgs e)
        {
            Ferramenta objFerramenta = new Ferramenta();
            ManterFerramenta cadastroF = new ManterFerramenta("", objFerramenta, funcionario);
            cadastroF.ShowDialog();
            funcionario = cadastroF.usuarioLogado;
        }

        private void menuItemNRequisição_Click(object sender, EventArgs e)
        {
            while (1 == 1)
            {
                ManterRequisicao cRequisicao = new ManterRequisicao(funcionario, "nova", new Requisicao());

                PesquisarFerramenta pFerramenta = new PesquisarFerramenta(funcionario, "adicionar");
                pFerramenta.ShowDialog();
                if (pFerramenta.DialogResult == DialogResult.Cancel)
                {
                    break;
                }
                else
                {
                    PesquisarFuncionario pFuncionario = new PesquisarFuncionario(funcionario, "adicionar");
                    pFuncionario.ShowDialog();
                    if (pFuncionario.DialogResult == DialogResult.Cancel)
                    {
                        break;
                    }
                    else
                    {
                        cRequisicao.arrayFerramentas = pFerramenta.arrayFerramentasRequsicao;
                        cRequisicao.funcionarioRequisitante = pFuncionario.objFuncionario;
                        cRequisicao.ShowDialog();
                        if (cRequisicao.DialogResult == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }
                funcionario = cRequisicao.usuarioLogado;
            }
        }

        private void menuItemlFuncionario_Click(object sender, EventArgs e)
        {
            if (funcionario.no_permissao == "Usuario_comum")
            {
                ManterFuncionario telaDetalhes = new ManterFuncionario("adicionar", funcionario, funcionario);
                telaDetalhes.ShowDialog();
            }
            else
            {
                PesquisarFuncionario pesquisaFunc = new PesquisarFuncionario(funcionario, "");
                pesquisaFunc.ShowDialog();
                funcionario = pesquisaFunc.usuarioLogado;
            }
        }

        private void menuItemlFerramenta_Click(object sender, EventArgs e)
        {
            PesquisarFerramenta pFerramenta = new PesquisarFerramenta(funcionario, "pesquisa");
            pFerramenta.ShowDialog();
            funcionario = pFerramenta.usuarioLogado;
        }

        #endregion



        #region Teclas de Atalho
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && funcionario.no_permissao == "Administrador")
            {
                menuItemNFuncionario_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F3 && funcionario.no_permissao != "Usuário comum")
            {
                menuItemlFuncionario_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F5 && funcionario.no_permissao == "Administrador")
            {
                MenuItemNFerramenta_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F6)
            {
                menuItemlFerramenta_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F7 && funcionario.no_permissao != "Usuário comum")
            {
                menuItemNRequisição_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F8 && funcionario.no_permissao != "Usuário comum")
            {
                menuItemLRequisicao_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F9 && funcionario.no_permissao == "Administrador")
            {
                MenuItmRelatorios_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F10)
            {
                MenuItmLogoff_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F11)
            {
                MenuItmSair_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F1)
            {
                MenuItmAjuda_Click(new object(), new EventArgs());
            }

        }
        #endregion

        #endregion

        private void menuItemLRequisicao_Click(object sender, EventArgs e)
        {
            PesquisarRequisicao pRequisicao = new PesquisarRequisicao(funcionario);
            pRequisicao.ShowDialog();
            funcionario = pRequisicao.usuarioLogado;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            montarTela();
        }

        private void MenuItmRelatorios_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.ShowDialog();
        }

        private void MenuItmAjuda_Click(object sender, EventArgs e)
        {
            var diretorio = System.IO.Directory.GetCurrentDirectory();
            var diretorio2 = diretorio + @"\SGA.chm";

            Help.ShowHelp(this, diretorio2);
        }

    }
}
