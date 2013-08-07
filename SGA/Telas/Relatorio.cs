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

namespace SGA.Telas
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void montarTela()
        {
            preencherCbxFuncao();

        }

        private void mudançaTipoRelatorio(RadioButton radiobutton)
        {
            rbtnRequisicao.Checked = false;
            rbtnFerramenta.Checked = false;
            rbtnFuncionario.Checked = true;

            if (radiobutton == rbtnEventosSistema)
            {
                rbtnRequisicao.Enabled = false;
                rbtnFerramenta.Enabled = true;
                rbtnFuncionario.Enabled = true;
            }
            else if(radiobutton == rbtnLista)
            {
                rbtnRequisicao.Enabled = true;
                rbtnFerramenta.Enabled = true;
                rbtnFuncionario.Enabled = true;
            }
            else 
            {
                rbtnRequisicao.Enabled = false;
                rbtnFerramenta.Checked = true;
                rbtnFuncionario.Enabled = false;
            }
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
            {
                mudançaTipoRelatorio(rbtnEventosSistema);
            }
        }

        private void rbtnLista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLista.Checked)
            {
                mudançaTipoRelatorio(rbtnLista);
            }
        }

        private void rbtnFerramentasReqisitadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFerramentasReqisitadas.Checked)
            {
                mudançaTipoRelatorio(rbtnFerramentasReqisitadas);
            }
        }
    }
}
