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

namespace SGA.Telas
{
    public partial class PesquisarRequisicao : Form
    {

        private List<Requisicao> i_listaRequisicoes = new List<Requisicao>();
        private Requisicao i_objRequisicao = new Requisicao();
        private Requisicao i_objPesquisaRequisicao = new Requisicao();

        public PesquisarRequisicao()
        {
            InitializeComponent();
        }

        internal Requisicao objPesquisaRequisicao
        {
            get { return i_objPesquisaRequisicao; }
            set { i_objPesquisaRequisicao = value; }
        }

        internal List<Requisicao> listaRequisicoes
        {
            get { return i_listaRequisicoes; }
            set { i_listaRequisicoes = value; }
        }

        internal Requisicao objRequisicao
        {
            get { return i_objRequisicao; }
            set { i_objRequisicao = value; }
        }

        private void montarTela()
        {
            objPesquisaRequisicao.ferramentas.Add(new Ferramenta());
            objPesquisaRequisicao.funcionario.Add(new Funcionario());
            objPesquisaRequisicao.funcionario.Add(new Funcionario());
            objPesquisaRequisicao.funcionario.Add(new Funcionario());

            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;

            preencherListViewRequisicao();
        }

        private void preencherListViewRequisicao()
        {
            RequisicaoDelegate requisicaoDel = new RequisicaoDelegate();
            listaRequisicoes = requisicaoDel.pesquisarRequisicao();
            listVFerramenta.Items.Clear();
            foreach (Requisicao requisicao in listaRequisicoes)
            {
                var item = new ListViewItem(new String[] { requisicao.codRequisicao + "", requisicao.ferramentas[0].codFerramenta, requisicao.ferramentas[0].nomeFerramenta,
                                          requisicao.funcionario[1].matricula + "",requisicao.dtRequisicao.ToString(),requisicao.funcionario[0].matricula + "",
                                          requisicao.dtBaixa.ToString(), requisicao.funcionario[2].matricula + "" });
                listVFerramenta.Items.Add(item);
            }
        }

        private void PesquisarRequisicao_Load(object sender, EventArgs e)
        {
            montarTela();
        }

        private void listVFerramenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVFerramenta.SelectedItems.Count != 0)
            {
                if (listVFerramenta.SelectedItems[0].Selected)
                {
                    foreach(Requisicao requisicao in listaRequisicoes)
                    {
                        if (requisicao.codRequisicao + "" == listVFerramenta.SelectedItems[0].Text)
                        {
                            objRequisicao = requisicao;
                            pbxFerramenta.Image = objRequisicao.ferramentas[0].imagem;
                            break;
                        }
                    }
                }
            }
        }

        private void tbxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        public static void apenasNumeros(KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void tbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {
            objPesquisaRequisicao.codRequisicao = Convert.ToInt32(tbxCodigo.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            objPesquisaRequisicao.ferramentas[0].codFerramenta = textBox3.Text;
        }
    }
}
