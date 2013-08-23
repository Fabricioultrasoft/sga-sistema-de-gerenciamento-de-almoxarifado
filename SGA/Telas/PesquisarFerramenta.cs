using System;
using System.Collections;
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
    public partial class PesquisarFerramenta : Form
    {

        private List<Ferramenta> ferramentas = new List<Ferramenta>();
        private Ferramenta objFerramenta = null;
        private Ferramenta i_objPesquisaFerramenta = new Ferramenta();
        private Funcionario i_usuarioLogado;
        private List<Ferramenta> i_ferramentasSelecionadas = new List<Ferramenta>();
        private List<Ferramenta> i_arrayFerramentasRequsicao = new List<Ferramenta>();
        private string i_tipoTela;
        private string i_tipoLista;

        FerramentaDelegate ferramentaDel = new FerramentaDelegate();

        public PesquisarFerramenta(Funcionario funcionario, string tipot)
        {
            InitializeComponent();
            usuarioLogado = funcionario;
            tipoTela = tipot;
        }

        public string tipoLista
        {
            get { return i_tipoLista; }
            set { i_tipoLista = value; }
        }


        public List<Ferramenta> arrayFerramentasRequsicao
        {
            get { return i_arrayFerramentasRequsicao; }
            set { i_arrayFerramentasRequsicao = value; }
        }

        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }

        public List<Ferramenta> ferramentasSelecionadas
        {
            get { return i_ferramentasSelecionadas; }
            set { i_ferramentasSelecionadas = value; }
        }

        public Funcionario usuarioLogado
        {
            get { return i_usuarioLogado; }
            set { i_usuarioLogado = value; }
        }


        private void montarTela()
        {
            pbxFerramenta.Image = null;
            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;
            preencherCbxFabricante();
            preencherCbxGrupo();
            preencherListView();

            setDtpickers();
            if (tipoTela == "pesquisa")
            {
                preencherCbxSituacao();
            }
            else
            {
                checkBoxEcluiveis.Visible = false;
                cbxSituacao.Visible = false;
                btnEditar.Visible = false;
                btnDesativar.Visible = false;
                cbxSituacao.Visible = false;
                listVFerramenta.CheckBoxes = true;
                btnNFerramenta.Text = "Salvar seleção";
                btnNFerramenta.Image = SGA.Properties.Resources._1370629123_button_30;
                btnDetalhes.Text = "Selecionadas";
                btnDetalhes.Image = SGA.Properties.Resources._1374804631_Checkbox_Full;
                lblSituacao.Visible = false;
            }
            if (usuarioLogado.no_permissao != "Administrador")
            {
                btnNFerramenta.Visible = false;
                btnEditar.Visible = false;
                btnDesativar.Visible = false;
                checkBoxEcluiveis.Visible = false;
                cbxSituacao.SelectedItem = "Disponível";
                cbxSituacao.Enabled = false;
            }
            if (usuarioLogado.no_permissao == "Atendente")
            {
                if (tipoTela == "adicionar")
                {
                    btnNFerramenta.Visible = true;
                }
                else
                {
                    btnNFerramenta.Visible = false;
                }

            }
        }

        public Ferramenta objPesquisaFerramenta
        {
            get { return i_objPesquisaFerramenta; }
            set { i_objPesquisaFerramenta = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnDetalhes_Click_1(object sender, EventArgs e)
        {
            if (tipoTela == "pesquisa")
            {
                if (objFerramenta == null)
                {
                    new Mensagem("Selecione uma ferramenta \n primeiro!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                }
                else
                {
                    ManterFerramenta telaDetalhes = new ManterFerramenta("Detalhes", objFerramenta, usuarioLogado);
                    telaDetalhes.ShowDialog();
                    usuarioLogado = telaDetalhes.usuarioLogado;
                    pbxFerramenta.Image = null;
                    objFerramenta = null;
                    montarTela();
                }
            }
            else
            {
                tipoLista = "selecionadas";
                adicionarlistaFerr();
                ferramentasSelecionadas = new List<Ferramenta>();
                if (arrayFerramentasRequsicao.Count > 0)
                {
                    listVFerramenta.Items.Clear();
                    foreach (Ferramenta ferr in arrayFerramentasRequsicao)
                    {
                        var item = new ListViewItem(new[] { ferr.codFerramenta, ferr.nomeFerramenta, ferr.codFabricante, ferr.codGrupo });
                        item.Checked = true;
                        listVFerramenta.Items.Add(item);
                    }
                }
                else
                {
                    new Mensagem("Nenhuma ferramenta selecionada!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                    preencherListView();
                }

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (objFerramenta == null)
            {
                new Mensagem("Selecione uma ferramenta \n primeiro!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
            }
            else
            {
                ManterFerramenta telaDetalhes = new ManterFerramenta("Edicao", objFerramenta, usuarioLogado);
                telaDetalhes.ShowDialog();
                usuarioLogado = telaDetalhes.usuarioLogado;
                pbxFerramenta.Image = null;
                objFerramenta = null;
                montarTela();
            }
        }

        private void adicionarlistaFerr()
        {
            foreach (Ferramenta objf in ferramentasSelecionadas)
            {
                bool teste = false;
                foreach (Ferramenta f in arrayFerramentasRequsicao)
                {
                    if (objf.codFerramenta == f.codFerramenta)
                    {
                        teste = true;
                    }
                }
                if (!teste)
                {
                    arrayFerramentasRequsicao.Add(objf);
                }

            }
            List<Ferramenta> array = new List<Ferramenta>();
            foreach (Ferramenta f in arrayFerramentasRequsicao)
            {
                bool teste1 = false;
                
                foreach (Ferramenta fe in array)
                {
                    if (f.codFerramenta == fe.codFerramenta)
                    {
                        teste1 = true;
                    }
                }
                if (array.Count <= 0)
                {
                    array.Add(f);
                }
                else
                {
                    if (teste1)
                    {
                        continue;
                    }
                    else
                    {
                        array.Add(f); 
                    }
                }
            }
            arrayFerramentasRequsicao = array;
        }

        private void btnNFerramenta_Click(object sender, EventArgs e)
        {
            if (tipoTela == "pesquisa")
            {
                Ferramenta ferr = new Ferramenta();
                ManterFerramenta novaFerr = new ManterFerramenta("cadastro", ferr, usuarioLogado);
                novaFerr.ShowDialog();
                usuarioLogado = novaFerr.usuarioLogado;
                pbxFerramenta.Image = null;
            }
            else
            {
                adicionarlistaFerr();
                ferramentasSelecionadas = new List<Ferramenta>();
                if (arrayFerramentasRequsicao.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    new Mensagem("Selecione ao menos\n uma ferramenta para prosseguir!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                    preencherListView();
                }
            }
            montarTela();
        }

        private void pesquisarFerramenta()
        {
            if (tipoTela == "adicionar")
            {
                objPesquisaFerramenta.codSituacao = "Disponível";
            }
            FerramentaDelegate ferramentaDel = new FerramentaDelegate();
            Queue arrayFerramentas = ferramentaDel.pesquisaFerramenta(objPesquisaFerramenta);
            ferramentas.Clear();

            while (arrayFerramentas.Count != 0)
            {
                ferramentas.Add((Ferramenta)arrayFerramentas.Dequeue());
            }

        }

        private void preencherListView()
        {
            tipoLista = "pesquisa";
            foreach (Ferramenta objf in ferramentasSelecionadas)
            {
                arrayFerramentasRequsicao.Add(objf);
            }
            listVFerramenta.Items.Clear();
            pesquisarFerramenta();

            foreach (Ferramenta ferr in ferramentas)
            {
                int i = 0;
                for (int j = 0; j < arrayFerramentasRequsicao.Count; j++)
                {
                    if ((arrayFerramentasRequsicao[j]).codFerramenta == ferr.codFerramenta)
                    {
                        i = 1;
                        break;
                    }
                }
                if (i == 0)
                {
                    var item = new ListViewItem(new[] { ferr.codFerramenta, ferr.nomeFerramenta, ferr.codFabricante, ferr.codGrupo });
                    listVFerramenta.Items.Add(item);
                }
            }
            ferramentaEmUsoAcao();
        }

        private void PesquisarFerramenta_Load(object sender, EventArgs e)
        {
            montarTela();
        }

        private void ferramentaEmUsoAcao()
        {
            if (objFerramenta != null)
            {

                if (objFerramenta.codSituacao == "Em uso")
                {
                    btnDesativar.Enabled = false;
                    btnEditar.Enabled = false;
                }
                else
                {
                    btnDesativar.Enabled = true;
                    btnEditar.Enabled = true;
                }
            }
            else
            {
                btnDesativar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private void listVFerramenta_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listVFerramenta.SelectedItems.Count != 0)
            {
                if (listVFerramenta.SelectedItems[0].Selected)
                {
                    foreach (Ferramenta ferr in ferramentas)
                    {
                        if (ferr.codFerramenta == listVFerramenta.SelectedItems[0].Text)
                        {
                            objFerramenta = ferr;
                            ferramentaEmUsoAcao();
                            objFerramenta.chaveUsuario = usuarioLogado.matricula.ToString(); ;
                            pbxFerramenta.Image = ferr.imagem;
                            break;
                        }
                    }
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (objFerramenta == null)
            {
                new Mensagem("Selecione uma ferramenta \n primeiro!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
            }
            else
            {
                Mensagem mensagem = new Mensagem("Deseja realmente excluir \n este registro?", "senha", SGA.Properties.Resources.key);
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

                            FerramentaDelegate ferramentaDel = new FerramentaDelegate();
                            ferramentaDel.desativaFerramenta(objFerramenta);
                            new Mensagem("Registro excluído com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
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
                        if (erro.Message == "Senha incorreta!")
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
            objFerramenta = null;
            pbxFerramenta.Image = null;
            montarTela();


        }

        public void preencherCbxFabricante()
        {
            Queue fabricantes = ferramentaDel.preencherCbxFabricante();
            cbxFabricante.Items.Clear();
            cbxFabricante.Items.Add("");
            while (fabricantes.Count != 0)
            {
                cbxFabricante.Items.Add(fabricantes.Dequeue().ToString());
            }
        }

        public void preencherCbxSituacao()
        {
            Queue situacao = ferramentaDel.preencherCbxSituacao();
            cbxSituacao.Items.Clear();
            cbxSituacao.Items.Add("");
            while (situacao.Count != 0)
            {
                cbxSituacao.Items.Add(situacao.Dequeue().ToString());
            }
        }

        public void preencherCbxGrupo()
        {
            Queue grupos = ferramentaDel.preencherCbxGrupo();
            cbxGrupo.Items.Clear();
            cbxGrupo.Items.Add("");
            while (grupos.Count != 0)
            {
                cbxGrupo.Items.Add(grupos.Dequeue().ToString());
            }

        }

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {
            objPesquisaFerramenta.codFerramenta = tbxCodigo.Text;
            preencherListView();
        }

        private void dtpickerInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerInicio.Value > dtpickerFinal.Value)
            {
                new Mensagem("A data inicial deve ser menor \nque a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerFinal.Value = dtpickerInicio.Value.AddDays(1);
            }

            objPesquisaFerramenta.periodo[0] = "Aquisicao";
            objPesquisaFerramenta.periodo[1] = dtpickerInicio.Value.ToString();
            objPesquisaFerramenta.periodo[2] = dtpickerFinal.Value.ToString();
            preencherListView();
        }

        private void dtpickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerFinal.Value < dtpickerInicio.Value)
            {
                new Mensagem("A data final deve ser maior \nque a data de início!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerInicio.Value = dtpickerFinal.Value.AddDays(-1);
            }

            objPesquisaFerramenta.periodo[0] = "Aquisicao";
            objPesquisaFerramenta.periodo[1] = dtpickerInicio.Value.ToString();
            objPesquisaFerramenta.periodo[2] = dtpickerFinal.Value.ToString();
            preencherListView();
        }

        private void setDtpickers()
        {
            if (ferramentaDel.setDateTimerPicker() != "")
            {
                dtpickerInicio.Enabled = true;
                dtpickerFinal.Enabled = true;
                dtpickerInicio.MinDate = Convert.ToDateTime(ferramentaDel.setDateTimerPicker());
                dtpickerInicio.Value = dtpickerInicio.MinDate;
                dtpickerFinal.MinDate = dtpickerInicio.MinDate.AddDays(1);
                DateTime data = Convert.ToDateTime(System.DateTime.Now);


                if (dtpickerInicio.MinDate.ToString("yyyy-MM-dd") == data.ToString("yyyy-MM-dd"))
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
            else
            {
                dtpickerInicio.Enabled = false;
                dtpickerFinal.Enabled = false;
            }

        }

        private void btnRedPeriodo_Click(object sender, EventArgs e)
        {
            setDtpickers();
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            objPesquisaFerramenta.nomeFerramenta = tbxNome.Text;
            preencherListView();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaFerramenta.codGrupo = cbxGrupo.SelectedItem.ToString();
            preencherListView();
        }

        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaFerramenta.codFabricante = cbxFabricante.SelectedItem.ToString();
            preencherListView();
        }

        private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPesquisaFerramenta.codSituacao = cbxSituacao.SelectedItem.ToString();
            preencherListView();
        }

        private void checkBoxEcluiveis_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxEcluiveis.Checked)
            {
                objPesquisaFerramenta.excluivel = "sim";
            }
            else
            {
                objPesquisaFerramenta.excluivel = "";

            }
            preencherListView();
        }

        private void listVFerramenta_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (tipoLista != "selecionadas")
            {
                ferramentasSelecionadas = new List<Ferramenta>();
            }
            else
            {
                arrayFerramentasRequsicao = new List<Ferramenta>();
            }
            if (listVFerramenta.CheckedItems.Count != 0)
            {
                for (int i = 0; i < listVFerramenta.CheckedItems.Count; i++)
                {
                    if (listVFerramenta.CheckedItems[i].Checked)
                    {
                        foreach (Ferramenta f in ferramentas)
                        {
                            if (f.codFerramenta == listVFerramenta.CheckedItems[i].Text)
                            {
                                if (tipoLista != "selecionadas")
                                {
                                    ferramentasSelecionadas.Add(f);
                                }
                                else
                                {
                                    arrayFerramentasRequsicao.Add(f);
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxCodigo.Clear();
            tbxNome.Clear();
            cbxFabricante.Text = "";
            cbxGrupo.Text = "";
            cbxSituacao.Text = "";
            checkBoxEcluiveis.Checked = false;
        }
    }
}
