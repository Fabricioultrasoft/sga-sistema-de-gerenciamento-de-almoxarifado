using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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
            // TODO: This line of code loads data into the 'logOperacaoFuncionario._LogOperacaoFuncionario' table. You can move, or remove it, as needed.
            this.logOperacaoFuncionarioTableAdapter.Fill(this.logOperacaoFuncionario._LogOperacaoFuncionario);
            // TODO: This line of code loads data into the 'geraRelatorioFuncionario.RelatorioFuncionario' table. You can move, or remove it, as needed.
            this.relatorioFuncionarioTableAdapter.Fill(this.geraRelatorioFuncionario.RelatorioFuncionario);
            // TODO: This line of code loads data into the 'logOperacaoFerramenta.ListaOperacaoFerramenta' table. You can move, or remove it, as needed.
            this.listaOperacaoFerramentaTableAdapter.Fill(this.logOperacaoFerramenta.ListaOperacaoFerramenta);
            // TODO: This line of code loads data into the 'requisiçãoDataSet.ListaDeRequisição' table. You can move, or remove it, as needed.
            this.listaDeRequisiçãoTableAdapter.Fill(this.requisiçãoDataSet.ListaDeRequisição);
            // TODO: This line of code loads data into the 'ferramentaDataSet.ListaDeFerramentas' table. You can move, or remove it, as needed.
            this.listaDeFerramentasTableAdapter.Fill(this.ferramentaDataSet.ListaDeFerramentas);
            // TODO: This line of code loads data into the 'ferramentaMRequisitadaDataSet.FerramentasMRequisitadas' table. You can move, or remove it, as needed.
            this.ferramentasMRequisitadasTableAdapter.Fill(this.ferramentaMRequisitadaDataSet.FerramentasMRequisitadas);
            // TODO: esta linha de código carrega dados na tabela 'ferramentaMRequisitadaDataSet.FerramentasMRequisitadas'. Você pode movê-la ou removê-la conforme necessário.
            this.ferramentasMRequisitadasTableAdapter.Fill(this.ferramentaMRequisitadaDataSet.FerramentasMRequisitadas);
            // TODO: This line of code loads data into the 'requisiçãoDataSet.tb_requisicao' table. You can move, or remove it, as needed.
            
            // TODO: esta linha de código carrega dados na tabela 'ferramentaDataSet.tb_ferramenta'. Você pode movê-la ou removê-la conforme necessário.
            System.Drawing.Printing.PageSettings NovasMargens = new System.Drawing.Printing.PageSettings();
            NovasMargens.Margins.Bottom = 4;
            NovasMargens.Margins.Left = 4;
            NovasMargens.Margins.Right = 4;
            NovasMargens.Margins.Top = 4;

            reportViewer1.SetPageSettings(NovasMargens);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomPercent = 75;

            // TODO: This line of code loads data into the 'requisiçãoDataSet.tb_requisicao' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
