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

        private void Relatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            preencherCbxFuncao();
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
    }
}
