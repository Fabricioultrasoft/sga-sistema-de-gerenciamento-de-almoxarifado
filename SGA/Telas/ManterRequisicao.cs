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
    public partial class ManterRequisicao : Form
    {
        private Funcionario i_usuarioLogado;
        private Funcionario i_funcionarioRequisitante = new Funcionario();
        private Funcionario i_funcionarioBaixa = new Funcionario();
        private Funcionario i_funcionarioSaída = new Funcionario();
        private Requisicao i_objRequisicao = new Requisicao();

        internal Requisicao objRequisicao
        {
            get { return i_objRequisicao; }
            set { i_objRequisicao = value; }
        }
        private string i_tipoTela = "";

        List<Ferramenta> i_arrayFerramentas = new List<Ferramenta>();
        Ferramenta objFerramentaSelecionada;

        public ManterRequisicao(Funcionario func, string tipoT, Requisicao req)
        {
            InitializeComponent();
            usuarioLogado = func;
            tipoTela = tipoT;
            objRequisicao = req;
        }

        public Funcionario funcionarioSaída
        {
            get { return i_funcionarioSaída; }
            set { i_funcionarioSaída = value; }
        }

        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }

        public Funcionario funcionarioBaixa
        {
            get { return i_funcionarioBaixa; }
            set { i_funcionarioBaixa = value; }
        }

        public Funcionario funcionarioRequisitante
        {
            get { return i_funcionarioRequisitante; }
            set { i_funcionarioRequisitante = value; }
        }


        private void montarTela()
        {
            pbxFerramenta.Image = null;
            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;
            if (tipoTela == "nova")
            {
                gbxFuncBaixa.Visible = false;
                funcionarioSaída = usuarioLogado;
                preencherListView();
            }
            else
            {
                gbxNRequisicao.Text = "Detalhes requisição";
                funcionarioRequisitante = objRequisicao.funcionario[1];
                funcionarioSaída = objRequisicao.funcionario[0];
                funcionarioBaixa = objRequisicao.funcionario[2];

                btnAddFerramenta.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = false;
                button1.Enabled = false;

                if (funcionarioBaixa.matricula == 0)
                    gbxFuncBaixa.Visible = false;


                listVFerramenta.Height = 68;
                Ferramenta ferr = objRequisicao.ferramentas[0];
                pbxFerramenta.Image = objRequisicao.ferramentas[0].imagem;
                var item = new ListViewItem(new[] { ferr.codFerramenta, ferr.nomeFerramenta, ferr.codFabricante, ferr.codGrupo });
                listVFerramenta.Items.Add(item);
            }
            preencherLstVfuncionario();

        }

        private void preencherLstVfuncionario()
        {
            listViewFuncSaida.Items.Clear();
            var item = new ListViewItem(new String[] { funcionarioSaída.matricula + "", funcionarioSaída.nome, funcionarioSaída.no_funcao });
            listViewFuncSaida.Items.Add(item);

            listVFuncReq.Items.Clear();
            var itemr = new ListViewItem(new String[] { funcionarioRequisitante.matricula + "", funcionarioRequisitante.nome, funcionarioRequisitante.no_funcao });
            listVFuncReq.Items.Add(itemr);

            listViewFuncBaixa.Items.Clear();
            var item2 = new ListViewItem(new String[] { funcionarioBaixa.matricula + "", funcionarioBaixa.nome, funcionarioBaixa.no_funcao });
            listViewFuncBaixa.Items.Add(item2);
        }

        public List<Ferramenta> arrayFerramentas
        {
            get { return i_arrayFerramentas; }
            set { i_arrayFerramentas = value; }
        }

        public Funcionario usuarioLogado
        {
            get { return i_usuarioLogado; }
            set { i_usuarioLogado = value; }
        }

        private void preencherListView()
        {
            listVFerramenta.Items.Clear();
            foreach (Ferramenta ferr in arrayFerramentas)
            {
                var item = new ListViewItem(new[] { ferr.codFerramenta, ferr.nomeFerramenta, ferr.codFabricante, ferr.codGrupo });
                listVFerramenta.Items.Add(item);
            }
        }

        private void btnAddFerramenta_Click(object sender, EventArgs e)
        {
            adicionarFerramenta();
        }

        private void adicionarFerramenta()
        {
            PesquisarFerramenta addFerramenta = new PesquisarFerramenta(usuarioLogado, "adicionar");
            addFerramenta.arrayFerramentasRequsicao = arrayFerramentas;
            addFerramenta.ShowDialog();

            if (addFerramenta.DialogResult != DialogResult.Cancel)
            {
                this.arrayFerramentas = addFerramenta.arrayFerramentasRequsicao;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            preencherListView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (arrayFerramentas.Count <= 0)
            {
                new Mensagem("Adicione ao menos uma\n ferramenta para salvar \na requisição!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
            }
            else
            {

                Mensagem mensagem = new Mensagem("Entre com a senha do atendente.", "senha", SGA.Properties.Resources.key);
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

                            break;

                        }
                        else
                        {
                            mensagem.DialogResult = DialogResult.Cancel;
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
                if (mensagem.DialogResult == DialogResult.OK)
                {
                    while (1 == 1)
                    {
                        mensagem = new Mensagem("Entre com a senha \nfuncionário requisitante.", "senha", SGA.Properties.Resources.key);
                        mensagem.tbxSenha.Text = "";
                        mensagem.ShowDialog();
                        try
                        {

                            if (mensagem.DialogResult == DialogResult.OK)
                            {
                                FuncionarioDelegate funcionarioDel = new FuncionarioDelegate();

                                Funcionario funcionario = funcionarioRequisitante;

                                funcionario.senha = Criptografia.Encrypt(mensagem.texto);

                                funcionarioDel.Logar(funcionario);
                                Requisicao requisicao = new Requisicao();
                                requisicao.ferramentas = this.arrayFerramentas;
                                requisicao.funcionario.Add(usuarioLogado);
                                requisicao.funcionario.Add(funcionarioRequisitante);

                                RequisicaoDelegate requisicaoDel = new RequisicaoDelegate();
                                requisicaoDel.gravarRequisicao(requisicao);

                                new Mensagem("Requisição cadstrada com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
                                this.DialogResult = DialogResult.OK;
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
                    if (mensagem.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tipoTela == "nova")
            {
                Mensagem mensagem = new Mensagem("Deseja cancelar \n a requisição?", "confirma", SGA.Properties.Resources.interrogacao);
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

        private void listVFerramenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVFerramenta.SelectedItems.Count != 0)
            {
                if (listVFerramenta.SelectedItems[0].Selected)
                {
                    foreach (Ferramenta ferr in arrayFerramentas)
                    {
                        if (ferr.codFerramenta == listVFerramenta.SelectedItems[0].Text)
                        {
                            objFerramentaSelecionada = ferr;
                            pbxFerramenta.Image = ferr.imagem;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objFerramentaSelecionada == null)
            {
                new Mensagem("Selecione uma ferramenta \n primeiro!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
            }
            else if (arrayFerramentas.Count <= 0)
            {
                new Mensagem("Não existe ferramentas na requisição!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
            }
            else
            {
                foreach (Ferramenta ferr in arrayFerramentas)
                {
                    if (objFerramentaSelecionada.codFerramenta == ferr.codFerramenta)
                    {
                        arrayFerramentas.Remove(ferr);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                preencherListView();
                objFerramentaSelecionada = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            adicionarFuncionario();
            montarTela();
        }

        private void adicionarFuncionario()
        {
            PesquisarFuncionario pesqFuncionario = new PesquisarFuncionario(usuarioLogado, "adicionar");
            pesqFuncionario.ShowDialog();

            if (pesqFuncionario.DialogResult != DialogResult.Cancel)
            {
                this.funcionarioRequisitante = pesqFuncionario.objFuncionario;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void ManterRequisicao_Load(object sender, EventArgs e)
        {
            montarTela();
        }

    }
}
