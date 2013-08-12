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
        private Requisicao i_objRequisicao;
        private Requisicao i_objPesquisaRequisicao = new Requisicao();
        private Funcionario i_usuarioLogado = new Funcionario();

        public PesquisarRequisicao(Funcionario func)
        {
            InitializeComponent();
            usuarioLogado = func;
        }

        public Funcionario usuarioLogado
        {
            get { return i_usuarioLogado; }
            set { i_usuarioLogado = value; }
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

            comboBox1.Items.Add("");
            comboBox1.Items.Add("Criação");
            comboBox1.Items.Add("Baixa");

            cbxSituacao.Items.Add("");
            cbxSituacao.Items.Add("Abertas");
            cbxSituacao.Items.Add("Fechadas");

            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;

            setDtpickers();

            preencherListViewRequisicao();
            if (usuarioLogado.no_permissao == "Usuario_comum")
            {
                btnNFerramenta.Visible = false;
                btnDesativar.Visible = false;
                textBox2.Text = usuarioLogado.matricula + "";
                textBox2.Enabled = false;
            }
        }

        private void preencherListViewRequisicao()
        {
            RequisicaoDelegate requisicaoDel = new RequisicaoDelegate();
            listaRequisicoes = requisicaoDel.pesquisarRequisicao(objPesquisaRequisicao);
            listVFerramenta.Items.Clear();
            foreach (Requisicao requisicao in listaRequisicoes)
            {
                string dataBaixa = "";
                string matFuncBaixa = "";

                if (requisicao.funcionario[2].matricula != 0)
                {
                    dataBaixa = requisicao.dtBaixa.ToString();
                    matFuncBaixa =  requisicao.funcionario[2].matricula + "";
                }
                var item = new ListViewItem(new String[] { requisicao.codRequisicao + "", requisicao.ferramentas[0].codFerramenta, requisicao.ferramentas[0].nomeFerramenta,
                                          requisicao.funcionario[1].matricula + "",requisicao.dtRequisicao.ToString(),requisicao.funcionario[0].matricula + "",
                                          dataBaixa, matFuncBaixa });
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
                            requisicaoFechadaAcao(requisicao);
                            pbxFerramenta.Image = objRequisicao.ferramentas[0].imagem;
                            break;
                        }
                    }
                }
            }
        }

        public void requisicaoFechadaAcao(Requisicao requisicao)
        {
            if (requisicao.funcionario[2].matricula + "" != "0")
            {
                btnDesativar.Enabled = false;
            }
            else
            {
                btnDesativar.Enabled = true;
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
            try
            {
                objPesquisaRequisicao.codRequisicao = Convert.ToInt32(tbxCodigo.Text);
            }
            catch
            {
                objPesquisaRequisicao.codRequisicao = 0;
                tbxCodigo.Text = "";
            }
            preencherListViewRequisicao();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            objPesquisaRequisicao.ferramentas[0].codFerramenta = textBox3.Text;
            preencherListViewRequisicao();
        }

        private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaRequisicao.situacao = cbxSituacao.SelectedItem.ToString();
            preencherListViewRequisicao();
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objPesquisaRequisicao.funcionario[0].matricula = Convert.ToInt32(tbxNome.Text);
            }
            catch
            {
                objPesquisaRequisicao.funcionario[0].matricula = 0;
                tbxNome.Text = "";
            }
            preencherListViewRequisicao();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objPesquisaRequisicao.funcionario[1].matricula = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                objPesquisaRequisicao.funcionario[1].matricula = 0;
                textBox1.Text = "";
            }
            preencherListViewRequisicao();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objPesquisaRequisicao.funcionario[2].matricula = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                objPesquisaRequisicao.funcionario[2].matricula = 0;
                textBox2.Text = "";
            }
            preencherListViewRequisicao();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaRequisicao.tipoPeriodo = comboBox1.SelectedItem.ToString();
            objPesquisaRequisicao.periodo[1] = dtpickerFinal.Value.ToString("yyyy-MM-dd");
            objPesquisaRequisicao.periodo[0] = dtpickerInicio.Value.ToString("yyyy-MM-dd");
            preencherListViewRequisicao();
        }

        private void dtpickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerFinal.Value <= dtpickerInicio.Value)
            {
                new Mensagem("A data final deve ser maior \nque a data de início!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerInicio.Value = dtpickerFinal.Value.AddDays(-1);
            }

            objPesquisaRequisicao.periodo[1] = dtpickerFinal.Value.ToString("yyyy-MM-dd");
            preencherListViewRequisicao();
        }

        private void dtpickerInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerInicio.Value >= dtpickerFinal.Value)
            {
                new Mensagem("A data inicial deve ser menor \nque a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerFinal.Value = dtpickerInicio.Value.AddDays(1);
            }

            objPesquisaRequisicao.periodo[0] = dtpickerInicio.Value.ToString("yyyy-MM-dd");
            preencherListViewRequisicao();
        }

        private void setDtpickers()
        {
            RequisicaoDelegate requisicaoDel = new RequisicaoDelegate();
            dtpickerInicio.MinDate = Convert.ToDateTime(Convert.ToDateTime(requisicaoDel.setDateTimerPicker()).ToString("yyyy-MM-dd"));
            dtpickerInicio.Value = dtpickerInicio.MinDate;
            dtpickerFinal.MinDate = dtpickerInicio.MinDate.AddDays(1);
            DateTime data = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));
            if (dtpickerFinal.MinDate.AddDays(-1) == data)
            {
                dtpickerFinal.MaxDate = dtpickerInicio.MinDate.AddDays(1);
            }
            else
            {
                dtpickerFinal.MaxDate = data;
            }
            dtpickerFinal.Value = dtpickerFinal.MaxDate;
            dtpickerInicio.MaxDate = dtpickerFinal.MaxDate.AddDays(-1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxSituacao.SelectedItem = "";
            tbxCodigo.Clear();
            tbxNome.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnRedPeriodo_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            textBox1.Clear();
            setDtpickers();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNFerramenta_Click(object sender, EventArgs e)
        {
            while (1 == 1)
            {
                PesquisarFerramenta pFerramenta = new PesquisarFerramenta(usuarioLogado, "adicionar");
                pFerramenta.ShowDialog();
                if (pFerramenta.DialogResult == DialogResult.Cancel)
                {
                    break;
                }
                else
                {
                    PesquisarFuncionario pFuncionario = new PesquisarFuncionario(usuarioLogado, "adicionar");
                    pFuncionario.ShowDialog();
                    if (pFuncionario.DialogResult == DialogResult.Cancel)
                    {
                        break;
                    }
                    else
                    {
                        ManterRequisicao cRequisicao = new ManterRequisicao(usuarioLogado, "nova", new Requisicao());
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
            button1_Click(new object(), new EventArgs());
            btnRedPeriodo_Click(new object() ,new EventArgs() );
            objRequisicao = null;
            preencherListViewRequisicao();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (objRequisicao == null)
            {
                new Mensagem("Selecione uma requisição\nprimeiro!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
            }
            else
            {
                ManterRequisicao cRequisicao = new ManterRequisicao(usuarioLogado, "Detalhes", objRequisicao);
                cRequisicao.ShowDialog();
                objRequisicao = null;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (objRequisicao != null)
            {
                while (1 == 1)
                {
                    Mensagem mensagem = new Mensagem("Deseja finalizar a requisição?", "senha", SGA.Properties.Resources.key);
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

                            RequisicaoDelegate requisicaoDel = new RequisicaoDelegate();
                            objRequisicao.funcionario[2].matricula = usuarioLogado.matricula;
                            requisicaoDel.finalizarRequisicao(objRequisicao);

                            new Mensagem("Requisição finalizada com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
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
                            new Mensagem("Senha incorreta!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
                        }
                        else
                        {
                            new Mensagem(erro.Message, "informacao", SGA.Properties.Resources.erro).ShowDialog();
                            break;
                        }

                    }

                }
                objRequisicao = null;
            }
            else
            {
                new Mensagem("Selecione uma requisição\nprimeiro!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
            }
            preencherListViewRequisicao();
        }
    }
}
