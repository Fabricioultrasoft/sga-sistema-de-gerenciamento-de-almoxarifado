using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Properties;
using System.Windows.Threading;

namespace SGA.Telas
{
    public partial class Mensagem : Form
    {
        private string i_texto;
        private string i_tipoTela;

        public Mensagem(string texto, string tipoT, Image icone)
        {
            InitializeComponent();

            this.tipoTela = tipoT;

            lblMensagem.Text = texto;
            pictureBox1.Image = icone;
            
        }

        public string tipoTela
        {
            get { return i_tipoTela; }
            set { i_tipoTela = value; }
        }

        public string texto
        {
            get { return i_texto; }
            set { i_texto = value; }
        }

        private void montarTela(string tipoTela)
        {
            this.AcceptButton = this.btnOK;
            switch (tipoTela)
            {
                case "informacao":
                    {
                        lblSenha.Visible = false;
                        tbxSenha.Visible = false;
                        btnCancelar.Visible = false;
                        btnOK.Left = btnOK.Left + 80;
                    }
                    break;
                case "confirma":
                    {
                        lblSenha.Visible = false;
                        tbxSenha.Visible = false;
                        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    break;
                case "senha":
                    {
                        lblSenha.Text = "Senha:";
                        tbxSenha.PasswordChar = '*';
                        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    break;
                default:
                    {
                        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    break;
            }
            //this.Show();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            texto = tbxSenha.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tipoTela == "" || tipoTela == "senha")
            {
                if (tbxSenha.Text == "")
                {
                    new Mensagem("Campo vazio, preencha corretamente!", "informacao", Resources.erro).ShowDialog();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {
            montarTela(tipoTela);
            this.ControlBox = false;
        }
    }
}
