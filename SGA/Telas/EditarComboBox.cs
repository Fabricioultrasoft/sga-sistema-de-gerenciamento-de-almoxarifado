using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Properties;
using SGA.Delegate;
using System.Collections;

namespace SGA.Telas
{
    public partial class EditarComboBox : Form
    {
        private string i_tipoTela;
        private string i_itemSelecionado = "";

        public EditarComboBox(string tipo)
        {
            InitializeComponent();
            tipoTela = tipo;
            montarTela();
        }


        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }

        public string itemSelecionado
        {
            get { return i_itemSelecionado; }
            set { i_itemSelecionado = value; }
        }

        private void montarTela()
        {
            if (tipoTela == "funcao")
            {
                gbxEditar.Text = "Editar função";
                listView1.Columns[0].Text = "Função";
            }
            else if (tipoTela == "fabricante")
            {
                gbxEditar.Text = "Editar fabricante";
                listView1.Columns[0].Text = "Fabricante";
            }
            else if (tipoTela == "categoria")
            {
                gbxEditar.Text = "Editar categoria";
                listView1.Columns[0].Text = "Categoria";
            }
            preencherLstv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbnNova_Click(object sender, EventArgs e)
        {
            itemSelecionado = "";
            var itens = listView1.Items;

            string frase = "";
            string label = "";

            if (tipoTela == "funcao")
            {
                frase = "Entre com a nova função e dê OK.";
                label = "Função:";
            }
            else if (tipoTela == "fabricante")
            {
                frase = "Entre com o novo fabricante e dê OK.";
                label = "Fabricante:";
            }
            else if (tipoTela == "categoria")
            {
                frase = "Entre com a nova categoria e dê OK.";
                label = "Categoria:";
            }

            Mensagem nova = new Mensagem(frase, "", Resources.file_edit);
            nova.lblSenha.Text = label;
            nova.ShowDialog();

            if (nova.DialogResult == DialogResult.OK)
            {
                try
                {
                    manterCbx("insert", itemSelecionado, nova.texto);
                    new Mensagem("Registro salvo com sucesso!", "informacao", Resources.ok).ShowDialog();
                    preencherLstv();
                }
                catch (Exception erro)
                {
                    new Mensagem(erro.Message, "informacao", Resources.erro).ShowDialog();
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (itemSelecionado != "")
            {
                string frase = "";
                string label = "";

                if (tipoTela == "funcao")
                {
                    frase = "Editar função.";
                    label = "Função:";
                }
                else if (tipoTela == "fabricante")
                {
                    frase = "Editar fabricante.";
                    label = "Fabricante:";
                }
                else if (tipoTela == "categoria")
                {
                    frase = "Editar categoria.";
                    label = "Categoria:";
                }

                Mensagem nova = new Mensagem(frase, "", Resources.file_edit);
                nova.lblSenha.Text = label;
                nova.tbxSenha.Text = itemSelecionado;
                nova.ShowDialog();

                if (nova.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        manterCbx("update", itemSelecionado, nova.texto);
                        new Mensagem("Registro alterado com sucesso!", "informacao", Resources.ok).ShowDialog();
                        preencherLstv();
                    }
                    catch (Exception erro)
                    {
                        new Mensagem(erro.Message, "informacao", Resources.erro).ShowDialog();
                    }

                }
                itemSelecionado = "";
                listView1.SelectedItems.Clear();
            }
            else
            {
                new Mensagem("Selecione um item primeiro!", "informacao", Resources.atencao).ShowDialog();
            }
        }

        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0].Selected)
                {
                    itemSelecionado = listView1.SelectedItems[0].Text;
                }
            }

        }

        private void manterCbx(string comando, string valorAntigo, string novoValor)
        {
            if (tipoTela == "funcao")
            {
                FuncionarioDelegate funcionarioDelegate = new FuncionarioDelegate();
                funcionarioDelegate.manterFuncao(comando, valorAntigo, novoValor);
            }
            else if (tipoTela == "fabricante")
            {
                FerramentaDelegate ferramentaDel = new FerramentaDelegate();
                ferramentaDel.manterFabricante(comando, valorAntigo, novoValor);
            }
            else if (tipoTela == "categoria")
            {
                FerramentaDelegate ferramentaDel = new FerramentaDelegate();
                ferramentaDel.manterGrupo(comando, valorAntigo, novoValor);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (itemSelecionado != "")
            {
                string frase = "";
                string label = "";

                if (tipoTela == "funcao")
                {
                    frase = "Deseja realmente excluir este \n              registro? ";
                    label = "Função:";
                }
                else if (tipoTela == "fabricante")
                {
                    frase = "Deseja realmente excluir este registro? ";
                    label = "Fabricante:";
                }
                else if (tipoTela == "categoria")
                {
                    frase = "Deseja realmente excluir este registro? ";
                    label = "Categoria:";
                }

                Mensagem nova = new Mensagem(frase, "", Resources.interrogacao);
                nova.lblSenha.Text = label;
                nova.tbxSenha.Text = itemSelecionado;
                nova.lblSenha.Visible = false;
                nova.tbxSenha.Visible = false;
                nova.ShowDialog();

                if (nova.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        manterCbx("delete", itemSelecionado, nova.texto);
                        new Mensagem("Registro excluído com Sucesso!", "informacao", Resources.ok).ShowDialog();
                        preencherLstv();
                    }
                    catch (Exception erro)
                    {
                        new Mensagem(erro.Message, "informacao", Resources.erro).ShowDialog();
                    }
                }
                itemSelecionado = "";
                listView1.SelectedItems.Clear();
            }
            else
            {
                new Mensagem("Selecione um item primeiro!", "informacao", Resources.atencao).ShowDialog();
            }
        }

        private void preencherLstv()
        {

            listView1.Items.Clear();
            Queue array = new Queue();

            if (tipoTela == "funcao")
            {
                FuncionarioDelegate funcionarioD = new FuncionarioDelegate();
                array = funcionarioD.preencherCbxFuncao();
            }
            else if (tipoTela == "fabricante")
            {
                FerramentaDelegate ferramentaDel = new FerramentaDelegate();
                array = ferramentaDel.preencherCbxFabricante();
            }
            else
            {
                FerramentaDelegate ferramentaDel = new FerramentaDelegate();
                array = ferramentaDel.preencherCbxGrupo();
            }

            while (array.Count != 0)
            {
                listView1.Items.Add(array.Dequeue().ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0].Selected)
                {
                    itemSelecionado = listView1.SelectedItems[0].Text;
                }
            }
        }
    }
}
