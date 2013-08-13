using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Delegate;
using SGA.Entity;

namespace SGA.Telas
{
    public partial class ManterFerramenta : Form
    {
        private string i_tipoTela;
        private Ferramenta ferramenta = new Ferramenta();
        private Funcionario i_usuarioLogado;

        private FerramentaDelegate ferramentaDel = new FerramentaDelegate();

        public ManterFerramenta(string tipo, Ferramenta ferr, Funcionario func)
        {
            InitializeComponent();
            ferramenta = ferr;
            tipoTela = tipo;
            usuarioLogado = func;
        }

        public Funcionario usuarioLogado
        {
            get { return i_usuarioLogado; }
            set { i_usuarioLogado = value; }
        }

        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tipoTela != "Detalhes"  && tbxNome.Text != "" || tbxNuSerie.Text != "")
            {
                Mensagem mensagem = new Mensagem("Deseja descartar as informações?", "confirma", SGA.Properties.Resources.interrogacao);
                mensagem.ShowDialog();
                if (mensagem.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoTela == "Detalhes")
            {
                tipoTela = "Edicao";
                montarTela();
            }else{
                if (tbxNome.Text == "")
                {
                    new Mensagem("Campos obrigatórios em branco! \n Por favor preencha!", "informacao", SGA.Properties.Resources.atencao).ShowDialog();
                }
                else
                {
                    if (tipoTela == "Edicao")
                        this.ferramenta.codFerramenta = this.tbxCodigo.Text;
                    this.ferramenta.nomeFerramenta = this.tbxNome.Text;
                    this.ferramenta.quantidade = Convert.ToInt32(this.numUDQuant.Value);
                    this.ferramenta.imagem = pbxFerramenta.Image;
                    this.ferramenta.codGrupo = this.cbxGrupo.SelectedItem.ToString();
                    this.ferramenta.codFabricante = this.cbxFabricante.SelectedItem.ToString();
                    this.ferramenta.nu_serie = tbxNuSerie.Text;
                    this.ferramenta.codSituacao = cbxSituacao.SelectedItem.ToString();

                    this.ferramenta.chaveUsuario = usuarioLogado.matricula.ToString();

                    try
                    {
                        ferramentaDel.gravarFerramenta(ferramenta);
                        if (tipoTela == "Edicao")
                        {
                            new Mensagem("Registro alterado com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            new Mensagem("Registro salvo com sucesso!", "informacao", SGA.Properties.Resources.ok).ShowDialog();
                            ferramenta = new Ferramenta();
                            montarTela();
                        }
                        
                    }
                    catch (Exception erro)
                    {
                        new Mensagem(erro.Message, "informacao", SGA.Properties.Resources.erro).ShowDialog();
                    }
                }
            }
        }

        private void btnPImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagens JPEG (*.JPG)|*.jpg|Imagens BMP (*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxCImagem.Text = "";
                foreach(string arquivo in openFileDialog1.FileNames){
                    tbxCImagem.Text += arquivo;
                }
            }
            try
            {
                Image imagem = Image.FromFile(tbxCImagem.Text);
                pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;
                pbxFerramenta.Image = imagem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void CadastroFerramenta_Load(object sender, EventArgs e)
        {
            montarTela();

        }

        private void rbtnNuSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNuSerie.Checked)
            {
                tbxNuSerie.Enabled = true;
                numUDQuant.Value = 1;
                numUDQuant.Enabled = false;
            }
            else
            {
                numUDQuant.Enabled = true;
                tbxNuSerie.Clear();
                tbxNuSerie.Enabled = false;
            }
        }

        public void montarTela()
        {
            rbtnNuSerie.Checked = true;
            numUDQuant.Minimum = 1;
            numUDQuant.Maximum = 100;
            lblCodigo.Visible = false;
            tbxCodigo.Visible = false;
            tbxCImagem.Enabled = false;
            lblSituacao.Visible = false;
            cbxSituacao.Visible = false;
            pbxFerramenta.SizeMode = PictureBoxSizeMode.Zoom;

            preencherCbxGrupo();
            preencherCbxSituacao();
            preencherCbxFabricante();

            this.tbxNome.Text = ferramenta.nomeFerramenta;
            this.tbxCodigo.Text = ferramenta.codFerramenta;
            this.tbxNuSerie.Text = ferramenta.nu_serie;
            this.tbxCImagem.Text = "SGA";
            this.pbxFerramenta.Image = ferramenta.imagem;

            if (tipoTela == "Edicao")
            {
                lblCodigo.Visible = true;
                tbxCodigo.Visible = true;
                gbxNFerramenta.Text = "Editar Ferramenta";
                btnSalvar.Text = "Salvar";
                btnSalvar.Image = SGA.Properties.Resources._1370629123_button_30;
                tbxNome.Enabled = true;
                tbxCodigo.Enabled = false;
                cbxGrupo.Enabled = true;
                cbxFabricante.Enabled = true;
                btnAddCategoria.Visible = true;
                btnAddFabricante.Visible = true;
                btnPImagem.Enabled = true;
                tbxNuSerie.Enabled = true;
                rbtnNuSerie.Enabled = false;
                rbtnQuant.Enabled = false;
                lblSituacao.Visible = true;
                cbxSituacao.Visible = true;

                
            }
            else if (tipoTela == "Detalhes")
            {
                
                lblCodigo.Visible = true;
                tbxCodigo.Visible = true;
                gbxNFerramenta.Text = "Detalhes Ferramenta";
                btnSalvar.Text = "Editar";
                btnSalvar.Image = SGA.Properties.Resources._1370637407_user_male_edit;
                tbxNome.Enabled = false;
                tbxCodigo.Enabled = false;
                cbxGrupo.Enabled = false;
                cbxFabricante.Enabled = false;
                btnAddCategoria.Visible = false;
                btnAddFabricante.Visible = false;
                btnPImagem.Enabled = false;
                tbxNuSerie.Enabled = false;
                rbtnNuSerie.Enabled = false;
                rbtnQuant.Enabled = false;
                if (ferramenta.codSituacao == "Em uso")
                {
                    btnSalvar.Enabled = false;
                    lblSituacao.Visible = true;
                    cbxSituacao.Visible = true;
                    lblSituacao.Enabled = false;
                    cbxSituacao.Enabled = false;
                    cbxSituacao.Items.Clear();
                    cbxSituacao.Items.Add("Em uso");
                    cbxSituacao.SelectedItem = "Em uso";
                    btnCancelar.Text = "OK";
                    btnCancelar.Image = SGA.Properties.Resources._1370593393_Check;
                }
            }
            if (usuarioLogado.no_permissao != "Administrador")
            {
                btnSalvar.Visible = false;
            }
        }

        public void preencherCbxFabricante()
        {
            Queue fabricantes = ferramentaDel.preencherCbxFabricante();
            cbxFabricante.Items.Clear();
            while (fabricantes.Count != 0)
            {
                cbxFabricante.Items.Add(fabricantes.Dequeue().ToString());
            }
            if (tipoTela == "Edicao")
            {
                this.cbxFabricante.SelectedIndex = cbxFabricante.Items.IndexOf(ferramenta.codFabricante);
            }
            else
            {
                cbxFabricante.SelectedIndex = 0;
            }
        }

        public void preencherCbxSituacao()
        {
            Queue situacao = ferramentaDel.preencherCbxSituacao();
            cbxFabricante.Items.Clear();
            while (situacao.Count != 0)
            {
                string item = situacao.Dequeue().ToString();
                if (item == "Em uso")
                {
                    continue;
                }
                cbxSituacao.Items.Add(item);
            }
            if (tipoTela == "Edicao")
            {
                this.cbxSituacao.SelectedIndex = cbxSituacao.Items.IndexOf(ferramenta.codSituacao);
            }
            else
            {
                cbxSituacao.SelectedIndex = 0;
            }
        }

        public void preencherCbxGrupo()
        {
            Queue grupos = ferramentaDel.preencherCbxGrupo();
            cbxGrupo.Items.Clear();
            while (grupos.Count != 0)
            {
                cbxGrupo.Items.Add(grupos.Dequeue().ToString());
            }
            if (tipoTela == "Edicao")
            {
                this.cbxGrupo.SelectedIndex = cbxGrupo.Items.IndexOf(ferramenta.codGrupo);
            }
            else
            {
                cbxGrupo.SelectedIndex = 0;
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            MultiAuxiliar edtCategoria = new MultiAuxiliar("categoria");
            edtCategoria.ShowDialog();
            preencherCbxGrupo();
        }

        private void btnAddFabricante_Click(object sender, EventArgs e)
        {
            MultiAuxiliar edtFabricante = new MultiAuxiliar("fabricante");
            edtFabricante.ShowDialog();
            preencherCbxFabricante();
        }

    }
}
