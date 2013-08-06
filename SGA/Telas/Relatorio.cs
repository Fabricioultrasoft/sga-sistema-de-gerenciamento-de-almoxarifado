using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGA.Dao;
using SGA.Delegate;

namespace SGA.Telas
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sgaDataSet.tb_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_funcionarioTableAdapter.Fill(this.sgaDataSet.tb_funcionario);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            preencherCbxFuncao();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void preencherCbxFuncao()
        {
            FuncionarioDelegate funcionarioD = new FuncionarioDelegate();
            Queue funcao = funcionarioD.preencherCbxFuncao();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            while (funcao.Count != 0)
            {
                comboBox1.Items.Add(funcao.Dequeue().ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicaoDao r = new RequisicaoDao();
           // sgaDataSet.CreateDataReader = r.query();
        }
    }
}
