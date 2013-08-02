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
        public Funcionario i_funcionarioRequisitante = new Funcionario();
        List<Ferramenta> i_arrayFerramentas = new List<Ferramenta>();
        Ferramenta objFerramentaSelecionada;

        public ManterRequisicao(Funcionario func)
        {
            InitializeComponent();
            usuarioLogado = func;
            montarTela();
        }

        private void montarTela()
        {
            pbxFerramenta.Image = null;
            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;
            preencherListView();
            lblMatFunc.Text = i_funcionarioRequisitante.matricula.ToString();
            lblNomeFunc.Text = i_funcionarioRequisitante.nome;
            lblFuncaoFunc.Text = i_funcionarioRequisitante.no_funcao;
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
                    if (erro.Message == "Matrícula e/ou senha incorretos. \n Entre novamente com os dados.")
                    {
                        new Mensagem("Senha incorreta,insira \nasenha novamenta!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
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

                            Funcionario funcionario = usuarioLogado;

                            funcionario.senha = Criptografia.Encrypt(mensagem.texto);

                            funcionarioDel.Logar(funcionario);
                            Requisicao requisicao = new Requisicao();
                            requisicao.ferramentas = this.arrayFerramentas;
                            requisicao.funcionario.Add(usuarioLogado);
                            requisicao.funcionario.Add(i_funcionarioRequisitante);

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
                        if (erro.Message == "Matrícula e/ou senha incorretos. \n Entre novamente com os dados.")
                        {
                            new Mensagem("Senha incorreta,insira \nasenha novamenta!", "informacao", SGA.Properties.Resources.erro).ShowDialog();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem("Deseja cancelar \n a requisição?", "confirma", SGA.Properties.Resources.interrogacao);
            mensagem.ShowDialog();
            if (mensagem.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
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
                this.i_funcionarioRequisitante = pesqFuncionario.objFuncionario;
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
