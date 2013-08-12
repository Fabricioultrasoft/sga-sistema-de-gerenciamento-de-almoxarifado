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
    public partial class Relatorio : Form
    {
        private FuncionarioDelegate funcionarioD = new FuncionarioDelegate();
        private Requisicao i_objPesquisa = new Requisicao();
        private FerramentaDelegate ferramentaD = new FerramentaDelegate();

        public Relatorio()
        {
            InitializeComponent();
        }

        public Requisicao objPesquisa
        {
            get { return i_objPesquisa; }
            set { i_objPesquisa = value; }
        }

        private void montarTela()
        {
            preencherCbxFuncao();
            setDtpickers();
            preencherCbxPermissao();
            preencherCbxGrupo();
            preencherCbxSituacao();
            preencherCbxFabricante();
            preenchercbxTipoPeriodo();
            setDtpickersFerramenta();
            setDtpickersRequisicao();
            preencherCbxSituacaoRequisicao();
            preenchercbxTipoPeriodoRequisuicao();
            mudancaFocoRelatorio();
        }

        private void preenchercbxTipoPeriodo()
        {
            cbxTipoPeriodoFerramenta.Items.Add("");
            cbxTipoPeriodoFerramenta.Items.Add("Aquisicao");
            cbxTipoPeriodoFerramenta.Items.Add("Desativação");
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            montarTela();
        }

        private void preencherCbxFuncao()
        {
            FuncionarioDelegate funcionarioD = new FuncionarioDelegate();
            Queue funcao = funcionarioD.preencherCbxFuncao();
            cbxFuncao.Items.Clear();
            cbxFuncao.Items.Add("");
            while (funcao.Count != 0)
            {
                cbxFuncao.Items.Add(funcao.Dequeue().ToString());
            }
        }

        private void rbtnEventosSistema_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEventosSistema.Checked)
                mudancaFocoRelatorio();
        }

        private void rbtnLista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLista.Checked)
                mudancaFocoRelatorio();
        }

        private void rbtnFerramentasReqisitadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFerramentasReqisitadas.Checked)
                mudancaFocoRelatorio();
        }

        private void rbtnFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFuncionario.Checked)
            {
                rbtnLista.Checked = false;
                rbtnLista.Checked = true;
            }
        }

        private void rbtnFerramenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFerramenta.Checked)
            {
                rbtnLista.Checked = false;
                rbtnLista.Checked = true;
            }
        }

        private void rbtnRequisicao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRequisicao.Checked)
            {
                rbtnLista.Checked = false;
                rbtnLista.Checked = true;
            }
        }

        private void mudancaFocoRelatorio()
        {
            tabControl1.Controls.Remove(tabPageFerramenta);
            tabControl1.Controls.Remove(tabPageFuncionario);
            tabControl1.Controls.Remove(tabPageRequisicao);
            btnRedPeriodoFerramenta_Click(new object(), new EventArgs());
            btnRedPeriodoFerramenta_Click(new object(), new EventArgs());
            cbxTipoPeriodoFerramenta.Enabled = true;
            dtpickerInicioFerramenta.Enabled = true;
            dtpickerFinalFerramenta.Enabled = true;
            dtpickekAdmissaoFinal.Enabled = true;
            dtpickekAdmissaoInicio.Enabled = true;
            tbxMatricula.Enabled = true;
            tbxCodigo.Enabled = true;
          
            rbtnFerramentasReqisitadas.Visible = false;

            if (rbtnFuncionario.Checked)
            {
                lblPermissao.Visible = true;
                cbxPermissao.Visible = true;
                rbtnEventosSistema.Visible = true;
                tabControl1.Controls.Add(tabPageFuncionario);

                if (rbtnLista.Checked)
                {
                    tbxMatricula.Enabled = false;
                }
            }
            else if (rbtnFerramenta.Checked)
            {
                cbxSituacao.Visible = true;
                lblSituacao.Visible = true;
                tabControl1.Controls.Add(tabPageFerramenta);
                rbtnFerramentasReqisitadas.Visible = true;
                rbtnEventosSistema.Visible = true;

                if (rbtnLista.Checked)
                {
                    tbxCodigo.Enabled = false;
                }
                else if (rbtnFerramentasReqisitadas.Checked)
                {
                    tabControl1.Controls.Add(tabPageFuncionario);
                    tabControl1.Controls.Add(tabPageRequisicao);

                    tbxCodigo.Enabled = false;
                    cbxSituacaoRequisicao.Enabled = false;

                    cbxTipoPeriodoFerramenta.Enabled = false;
                    dtpickerInicioFerramenta.Enabled = false;
                    dtpickerFinalFerramenta.Enabled = false;
                    dtpickekAdmissaoFinal.Enabled = false;
                    dtpickekAdmissaoInicio.Enabled = false;
                }
            }
            else if (rbtnRequisicao.Checked)
            {
                lblPermissao.Visible = false;
                cbxPermissao.Visible = false;
                cbxSituacao.Visible = false;
                lblSituacao.Visible = false;
                rbtnEventosSistema.Visible = false;
                cbxSituacaoRequisicao.Enabled = true;
                tbxMatricula.Enabled = true;
                tbxCodigo.Enabled = true;
                cbxTipoPeriodoFerramenta.Enabled = false;
                dtpickerInicioFerramenta.Enabled = false;
                dtpickerFinalFerramenta.Enabled = false;
                dtpickekAdmissaoFinal.Enabled = false;
                dtpickekAdmissaoInicio.Enabled = false;
                tabControl1.Controls.Add(tabPageFerramenta);
                tabControl1.Controls.Add(tabPageRequisicao);
                tabControl1.Controls.Add(tabPageFuncionario);
            }
        }

        private void tbxCodigoRequisicao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
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

        private void setDtpickers()
        {
            dtpickekAdmissaoInicio.MinDate = Convert.ToDateTime(Convert.ToDateTime(funcionarioD.setDateTimerPicker()).ToString("yyyy-MM-dd"));
            dtpickekAdmissaoInicio.Value = dtpickekAdmissaoInicio.MinDate;
            dtpickekAdmissaoFinal.MinDate = dtpickekAdmissaoInicio.MinDate.AddDays(1);
            DateTime data = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));
            if (dtpickekAdmissaoFinal.MinDate.AddDays(-1) == data)
            {
                dtpickekAdmissaoFinal.MaxDate = dtpickerInicioFerramenta.MinDate.AddDays(1);
            }
            else
            {
                dtpickekAdmissaoFinal.MaxDate = data;
            }
            dtpickekAdmissaoInicio.MaxDate = dtpickekAdmissaoFinal.MaxDate.AddDays(-1);
            dtpickekAdmissaoFinal.Value = dtpickekAdmissaoFinal.MaxDate;
        }

        private void setDtpickersFerramenta()
        {
            dtpickerInicioFerramenta.MinDate = Convert.ToDateTime(Convert.ToDateTime(ferramentaD.setDateTimerPicker()).ToString("yyyy-MM-dd"));
            dtpickerInicioFerramenta.Value = dtpickerInicioFerramenta.MinDate;
            dtpickerFinalFerramenta.MinDate = dtpickerInicioFerramenta.MinDate.AddDays(1);
            DateTime data = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));
            if (dtpickerFinalFerramenta.MinDate.AddDays(-1) == data)
            {
                dtpickerFinalFerramenta.MaxDate = dtpickerInicioFerramenta.MinDate.AddDays(1);
            }
            else
            {
                dtpickerFinalFerramenta.MaxDate = data;
            }
            dtpickerFinalFerramenta.Value = dtpickerFinalFerramenta.MaxDate;
            dtpickerInicioFerramenta.MaxDate = dtpickerFinalFerramenta.MaxDate.AddDays(-1);
        }


        private void dtpickekAdmissaoInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickekAdmissaoInicio.Value >= dtpickekAdmissaoFinal.Value)
            {
                new Mensagem("A data inicial deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickekAdmissaoFinal.Value = dtpickekAdmissaoInicio.Value.AddDays(1);
            }
        }

        private void dtpickekAdmissaoFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickekAdmissaoFinal.Value <= dtpickekAdmissaoInicio.Value)
            {
                new Mensagem("A data final deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickekAdmissaoInicio.Value = dtpickekAdmissaoFinal.Value.AddDays(-1);
            }
        }

        private void btnLimparFuncionario_Click(object sender, EventArgs e)
        {
            tbxMatricula.Clear();
            cbxFuncao.Text = "";
            cbxPermissao.Text = "";
        }

        private void btnRedefinirPeriodoAdmissao_Click(object sender, EventArgs e)
        {
            setDtpickers();
        }

        private void tbxMatricula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 i = Convert.ToInt32(tbxMatricula.Text);
            }
            catch
            {
                tbxMatricula.Text = "";
            }
            if (tbxMatricula.Text != "")
            {
                cbxFuncao.Enabled = false;
                cbxPermissao.Enabled = false;
                dtpickekAdmissaoFinal.Enabled = false;
                dtpickekAdmissaoInicio.Enabled = false;
                cbxFuncao.Text = "";
                cbxPermissao.Text = "";
                setDtpickers();
            }
            else
            {
                cbxFuncao.Enabled = true;
                cbxPermissao.Enabled = true;
                if (rbtnFuncionario.Checked)
                {
                    dtpickekAdmissaoFinal.Enabled = true;
                    dtpickekAdmissaoInicio.Enabled = true;
                }
            }
        }

        public void preencherCbxFabricante()
        {
            Queue fabricantes = ferramentaD.preencherCbxFabricante();
            cbxFabricante.Items.Clear();
            cbxFabricante.Items.Add("");
            while (fabricantes.Count != 0)
            {
                cbxFabricante.Items.Add(fabricantes.Dequeue().ToString());
            }
        }

        public void preencherCbxSituacao()
        {
            Queue situacao = ferramentaD.preencherCbxSituacao();
            cbxSituacao.Items.Clear();
            cbxSituacao.Items.Add("");
            while (situacao.Count != 0)
            {
                cbxSituacao.Items.Add(situacao.Dequeue().ToString());
            }
        }

        public void preencherCbxGrupo()
        {
            Queue grupos = ferramentaD.preencherCbxGrupo();
            cbxGrupo.Items.Clear();
            cbxGrupo.Items.Add("");
            while (grupos.Count != 0)
            {
                cbxGrupo.Items.Add(grupos.Dequeue().ToString());
            }

        }

        private void dtpickerInicioFerramenta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerInicioFerramenta.Value >= dtpickerFinalFerramenta.Value)
            {
                new Mensagem("A data inicial deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerFinalFerramenta.Value = dtpickerInicioFerramenta.Value.AddDays(1);
            }
        }

        private void dtpickerFinalFerramenta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerFinalFerramenta.Value <= dtpickerInicioFerramenta.Value)
            {
                new Mensagem("A data final deve ser menor \n que a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerInicioFerramenta.Value = dtpickerFinalFerramenta.Value.AddDays(-1);
            }
        }

        private void btnRedPeriodoFerramenta_Click(object sender, EventArgs e)
        {
            setDtpickersFerramenta();
            cbxTipoPeriodoFerramenta.SelectedItem = "";
        }

        private void btnLimparFerramenta_Click(object sender, EventArgs e)
        {
            tbxCodigo.Clear();
            cbxFabricante.Text = "";
            cbxGrupo.Text = "";
            cbxSituacao.Text = "";
        }

        private void dtpickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerFinal.Value <= dtpickerInicio.Value)
            {
                new Mensagem("A data final deve ser maior \nque a data de início!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerInicio.Value = dtpickerFinal.Value.AddDays(-1);
            }
        }

        private void dtpickerInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpickerInicio.Value >= dtpickerFinal.Value)
            {
                new Mensagem("A data inicial deve ser menor \nque a data final!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                dtpickerFinal.Value = dtpickerInicio.Value.AddDays(1);
            }
        }

        private void setDtpickersRequisicao()
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

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbxCodigo.Text != "")
            {
                cbxGrupo.Enabled = false;
                cbxFabricante.Enabled = false;
                cbxSituacao.Enabled = false;
                cbxTipoPeriodoFerramenta.Enabled = false;
                dtpickerInicioFerramenta.Enabled = false;
                dtpickerFinalFerramenta.Enabled = false;
                cbxFabricante.Text = "";
                cbxGrupo.Text = "";
                cbxSituacao.Text = "";
                btnRedPeriodoFerramenta_Click(new object(), new EventArgs());
            }
            else
            {
                cbxGrupo.Enabled = true;
                cbxFabricante.Enabled = true;
                cbxSituacao.Enabled = true;
                if (!rbtnRequisicao.Checked)
                {
                    cbxTipoPeriodoFerramenta.Enabled = true;
                    dtpickerInicioFerramenta.Enabled = true;
                    dtpickerFinalFerramenta.Enabled = true;
                }
            }

        }

        private void preencherCbxSituacaoRequisicao()
        {
            cbxSituacaoRequisicao.Items.Add("");
            cbxSituacaoRequisicao.Items.Add("Abertas");
            cbxSituacaoRequisicao.Items.Add("Fechadas");
        }
        private void preenchercbxTipoPeriodoRequisuicao()
        {
            cbxTipoPeriodoRequisicao.Items.Add("");
            cbxTipoPeriodoRequisicao.Items.Add("Criação");
            cbxTipoPeriodoRequisicao.Items.Add("Baixa");
        }

        private void btnLimparRquisicao_Click(object sender, EventArgs e)
        {
            cbxSituacaoRequisicao.SelectedItem = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDtpickersRequisicao();
            cbxTipoPeriodoRequisicao.SelectedItem = "";
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            /*Funcionario funcionario = new Funcionario();
            Ferramenta ferramenta = new Ferramenta();
            Requisicao requisicao = new Requisicao();

            if(tbxMatricula.Text != "")
            funcionario.matricula = Convert.ToInt32(tbxMatricula.Text);

            funcionario.no_funcao = cbxFuncao.SelectedItem.ToString();
            funcionario.no_permissao = cbxPermissao.Text;
            funcionario.papel = cbxPapel.SelectedItem.ToString();
            funcionario.periodo[0] = dtpickekAdmissaoInicio.Value.ToString();
            funcionario.periodo[1] = dtpickekAdmissaoFinal.Value.ToString();

            ferramenta.codFerramenta = tbxCodigo.Text;
            ferramenta.codGrupo = cbxGrupo.SelectedItem.ToString();
            ferramenta.codSituacao = cbxSituacao.SelectedItem.ToString();
            ferramenta.codFabricante = cbxFabricante.SelectedItem.ToString();
            ferramenta.periodo[0] = cbxTipoPeriodoFerramenta.SelectedItem.ToString();
            ferramenta.periodo[1] = dtpickerInicioFerramenta.Value.ToString();
            ferramenta.periodo[2] = dtpickerFinalFerramenta.Value.ToString();

            requisicao.situacao = cbxSituacaoRequisicao.Text;
            requisicao.tipoPeriodo = cbxTipoPeriodoRequisicao.Text;
            requisicao.periodo[0] = dtpickerInicio.Value.ToString();
            requisicao.periodo[1] = dtpickerFinal.Value.ToString();*/
            TelaRelatorio tela = new TelaRelatorio();
            tela.ShowDialog();
        }
    }
}
