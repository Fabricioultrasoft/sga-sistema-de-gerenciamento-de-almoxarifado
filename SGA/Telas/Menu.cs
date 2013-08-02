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

        public Funcionario funcionario
        {
            get { return i_funcionario; }
            set { i_funcionario = value; }
        }

        #region Registro de Eventos

        #region Itens do Menu
        private void MenuItmSair_Click(object sender, EventArgs e)
        {
            Mensagem mensagen = new Mensagem("Deseja Realmente sair?", "confirma", Resources.interrogacao);
            if (mensagen.ShowDialog() == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MenuItmLogoff_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void menuItemNFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            ManterFuncionario cadastrofunc = new ManterFuncionario("Cadastro", objFuncionario, funcionario);
            cadastrofunc.ShowDialog();
        }

        private void MenuItemNFerramenta_Click(object sender, EventArgs e)
        {
            Ferramenta objFerramenta = new Ferramenta();
            ManterFerramenta cadastroF = new ManterFerramenta("", objFerramenta);
            cadastroF.ShowDialog();
        }

        private void menuItemNRequisição_Click(object sender, EventArgs e)
        {
            while (1 == 1)
            {
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
                        ManterRequisicao cRequisicao = new ManterRequisicao(funcionario);
                        cRequisicao.arrayFerramentas = pFerramenta.arrayFerramentasRequsicao;
                        cRequisicao.i_funcionarioRequisitante = pFuncionario.objFuncionario;
                        cRequisicao.ShowDialog();
                        if (cRequisicao.DialogResult == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void menuItemlFuncionario_Click(object sender, EventArgs e)
        {
            PesquisarFuncionario pesquisaFunc = new PesquisarFuncionario(funcionario, "");
            pesquisaFunc.ShowDialog();
        }

        private void menuItemlFerramenta_Click(object sender, EventArgs e)
        {
            PesquisarFerramenta pFerramenta = new PesquisarFerramenta(funcionario, "pesquisa");
            pFerramenta.ShowDialog();
        }

        #endregion



        #region Teclas de Atalho
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                PesquisarFuncionario pesquisaFunc = new PesquisarFuncionario(funcionario, "adicionar");
                pesquisaFunc.ShowDialog();
            }

            if (e.KeyCode == Keys.F5)
            {
                PesquisarFerramenta pFerramenta = new PesquisarFerramenta(funcionario, "pesquisa");
                pFerramenta.ShowDialog();
            }

        }
        #endregion

        public void montarTea()
        {
            menuItemlFuncionario.Enabled = false;
        }

        #endregion

        private void menuItemLRequisicao_Click(object sender, EventArgs e)
        {
            PesquisarRequisicao pRequisicao = new PesquisarRequisicao();
            pRequisicao.ShowDialog();
        }

    }
}
