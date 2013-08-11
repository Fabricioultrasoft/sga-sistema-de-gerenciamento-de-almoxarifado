using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGA.Telas
{
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {

           InitializeComponent();
            
        }

        private void TelaRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'requisiçãoDataSet.ListaDeRequisição' table. You can move, or remove it, as needed.
            this.listaDeRequisiçãoTableAdapter.Fill(this.requisiçãoDataSet.ListaDeRequisição);
            // TODO: This line of code loads data into the 'ferramentaDataSet.ListaDeFerramentas' table. You can move, or remove it, as needed.
            this.listaDeFerramentasTableAdapter.Fill(this.ferramentaDataSet.ListaDeFerramentas);
            // TODO: This line of code loads data into the 'ferramentaMRequisitadaDataSet.FerramentasMRequisitadas' table. You can move, or remove it, as needed.
            this.ferramentasMRequisitadasTableAdapter.Fill(this.ferramentaMRequisitadaDataSet.FerramentasMRequisitadas);
            // TODO: esta linha de código carrega dados na tabela 'ferramentaMRequisitadaDataSet.FerramentasMRequisitadas'. Você pode movê-la ou removê-la conforme necessário.
            this.ferramentasMRequisitadasTableAdapter.Fill(this.ferramentaMRequisitadaDataSet.FerramentasMRequisitadas);
            // TODO: This line of code loads data into the 'requisiçãoDataSet.tb_requisicao' table. You can move, or remove it, as needed.
            this.tb_requisicaoTableAdapter.Fill(this.requisiçãoDataSet.tb_requisicao);
            // TODO: esta linha de código carrega dados na tabela 'ferramentaDataSet.tb_ferramenta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ferramentaTableAdapter.Fill(this.ferramentaDataSet.tb_ferramenta);
            System.Drawing.Printing.PageSettings NovasDimensoes = new System.Drawing.Printing.PageSettings();
            NovasDimensoes.Margins.Bottom = 8;
            NovasDimensoes.Margins.Left = 8;
            NovasDimensoes.Margins.Right = 8;
            NovasDimensoes.Margins.Top = 8;

            reportViewer1.SetPageSettings(NovasDimensoes);
            // TODO: This line of code loads data into the 'requisiçãoDataSet.tb_requisicao' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
