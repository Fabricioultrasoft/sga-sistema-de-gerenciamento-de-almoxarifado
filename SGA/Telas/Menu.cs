﻿using System;
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
                Application.Exit();
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
                        ManterRequisicao cRequisicao = new ManterRequisicao(funcionario, "nova",new Requisicao());
                        cRequisicao.arrayFerramentas = pFerramenta.arrayFerramentasRequsicao;
                        cRequisicao.funcionarioRequisitante = pFuncionario.objFuncionario;
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
            if (funcionario.no_permissao == "Usuario_comum")
            {
                ManterFuncionario telaDetalhes = new ManterFuncionario("adicionar", funcionario, funcionario);
                telaDetalhes.ShowDialog();
            }
            else
            {
                PesquisarFuncionario pesquisaFunc = new PesquisarFuncionario(funcionario, "");
                pesquisaFunc.ShowDialog();
            }
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
            if (e.KeyCode == Keys.F2)
            {
                menuItemNFuncionario_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F3)
            {
                menuItemlFuncionario_Click(new object(), new EventArgs()); 
            }

            if (e.KeyCode == Keys.F4)
            {
                MenuItemNFerramenta_Click(new object(), new EventArgs());
            }

            if (e.KeyCode == Keys.F5)
            {
                menuItemlFerramenta_Click(new object(), new EventArgs()); 
            }

             if (e.KeyCode == Keys.F6)
             {
                 menuItemNRequisição_Click(new object(), new EventArgs());
             }

             if (e.KeyCode == Keys.F7)
             {
                 menuItemLRequisicao_Click(new object(), new EventArgs());
             }

             if (e.KeyCode == Keys.F8)
             {
                 MenuItmRelatorios_Click(new object(), new EventArgs());
             }

             if (e.KeyCode == Keys.F9)
             {
                 MenuItmLogoff_Click(new object(), new EventArgs());
             }

             if (e.KeyCode == Keys.F10)
             {
                 MenuItmSair_Click(new object(), new EventArgs());
             }

             if (e.KeyCode == Keys.F1)
             {
             }

        }
        #endregion

        #endregion

        private void menuItemLRequisicao_Click(object sender, EventArgs e)
        {
            PesquisarRequisicao pRequisicao = new PesquisarRequisicao(funcionario);
            pRequisicao.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            montarTela();
        }

        private void MenuItmRelatorios_Click(object sender, EventArgs e)
        {

        }

    }
}
