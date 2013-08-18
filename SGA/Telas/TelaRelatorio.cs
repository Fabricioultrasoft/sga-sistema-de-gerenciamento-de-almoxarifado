using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SGA.Entity;
using SGA.Properties;

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
            System.Drawing.Printing.PageSettings NovasMargens = new System.Drawing.Printing.PageSettings();
            NovasMargens.Margins.Bottom = 4;
            NovasMargens.Margins.Left = 4;
            NovasMargens.Margins.Right = 4;
            NovasMargens.Margins.Top = 4;
            reportViewer1.SetPageSettings(NovasMargens);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomPercent = 100;

        }

        public void ListaFuncionario(Funcionario funcionario, string tipo)
        {
            
            if (tipo == "lista") // Lista de Funcionários
            {

                GeraRelatorioFuncionarioTableAdapters.RelatorioFuncionarioTableAdapter adaptador = new GeraRelatorioFuncionarioTableAdapters.RelatorioFuncionarioTableAdapter();
                GeraRelatorioFuncionario.RelatorioFuncionarioDataTable tabela = new GeraRelatorioFuncionario.RelatorioFuncionarioDataTable();

                adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;

                adaptador.FillByFunPermDtInDtOut(tabela, "%" + funcionario.no_funcao + "%", "%" + funcionario.no_permissao + "%", Convert.ToDateTime(funcionario.periodo[0]), Convert.ToDateTime(funcionario.periodo[1]));

                ReportDataSource NovaFonteDados = new ReportDataSource("FuncionarioDataSet", (DataTable)tabela);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.ListaFuncionario.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else // Log de Funcionários
            {

                LogOperacaoFuncionarioTableAdapters.LogOperacaoFuncionarioTableAdapter adaptador = new LogOperacaoFuncionarioTableAdapters.LogOperacaoFuncionarioTableAdapter();
                LogOperacaoFuncionario.LogOperacaoFuncionarioDataTable tabela = new LogOperacaoFuncionario.LogOperacaoFuncionarioDataTable();

                adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                adaptador.FillByMatFunPerDtInDtOut(tabela, "%" + funcionario.matricula + "%", "%" + funcionario.no_funcao + "%", "%" + funcionario.no_permissao + "%", Convert.ToDateTime(funcionario.periodo[0]), Convert.ToDateTime(funcionario.periodo[1]));

                if (funcionario.matricula == 0) // Caso matricula zero, consulta será em branco no campo matricula!
                {
                    adaptador.FillByMatFunPerDtInDtOut(tabela, "%%", "%" + funcionario.no_funcao + "%", "%" + funcionario.no_permissao + "%", Convert.ToDateTime(funcionario.periodo[0]), Convert.ToDateTime(funcionario.periodo[1]));
                }
                else
                {
                    adaptador.FillByMatFunPerDtInDtOut(tabela, "%" + funcionario.matricula + "%", "%" + funcionario.no_funcao + "%", "%" + funcionario.no_permissao + "%", Convert.ToDateTime(funcionario.periodo[0]), Convert.ToDateTime(funcionario.periodo[1]));
                }


                ReportDataSource NovaFonteDados = new ReportDataSource("LogOperacaoFuncionario", (DataTable)tabela);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.LogFuncionario.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();

            }
        }

        public void ListaFerramentas(Ferramenta ferramenta, Funcionario funcionario, Requisicao requisicao, string tipo)
        {
            if (tipo == "lista")
            {
                FerramentaDataSetTableAdapters.ListaDeFerramentasTableAdapter adaptador = new FerramentaDataSetTableAdapters.ListaDeFerramentasTableAdapter();
                FerramentaDataSet.ListaDeFerramentasDataTable tabela = new FerramentaDataSet.ListaDeFerramentasDataTable();

                adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                adaptador.FillByDtiaDtfaFabGruSit(tabela, "%" + ferramenta.codSituacao + "%", Convert.ToDateTime(ferramenta.periodo[0]), Convert.ToDateTime(ferramenta.periodo[1]), "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%");

                ReportDataSource NovaFonteDados = new ReportDataSource("GeraRelatorioFerramenta", (DataTable)tabela);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.ListaDeFerramentas.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else if (tipo == "log")
            {
                LogOperacaoFerramentaTableAdapters.ListaOperacaoFerramentaTableAdapter adaptador = new LogOperacaoFerramentaTableAdapters.ListaOperacaoFerramentaTableAdapter();
                LogOperacaoFerramenta.ListaOperacaoFerramentaDataTable tabela = new LogOperacaoFerramenta.ListaOperacaoFerramentaDataTable();

                adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                adaptador.FillBySitCodFabCatDtInDtOut(tabela, "%" + ferramenta.codSituacao + "%", "%" + ferramenta.codFerramenta + "%", "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%", Convert.ToDateTime(ferramenta.periodo[0]), Convert.ToDateTime(ferramenta.periodo[1]));

                ReportDataSource NovaFonteDados = new ReportDataSource("LogFerramentaDataSet", (DataTable)tabela);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.LogFerramenta.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();

            }
            else
            {
                if (funcionario.matricula == 0)
                {
                    FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter adaptador = new FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter();
                    FerramentaMRequisitadaDataSet.FerramentasMRequisitadasDataTable tabela = new FerramentaMRequisitadaDataSet.FerramentasMRequisitadasDataTable();

                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByCatFabMatFunDtInDtOut(tabela, "%" + ferramenta.codGrupo + "%", "%" + ferramenta.codFabricante + "%", "%%", "%" + funcionario.no_funcao + "%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]));

                    ReportDataSource NovaFonteDados = new ReportDataSource("RequisitadasDataSet", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.FerramentaMRequisitada.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else
                {
                    FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter adaptador = new FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter();
                    FerramentaMRequisitadaDataSet.FerramentasMRequisitadasDataTable tabela = new FerramentaMRequisitadaDataSet.FerramentasMRequisitadasDataTable();

                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByCatFabMatFunDtInDtOut(tabela, "%" + ferramenta.codGrupo + "%", "%" + ferramenta.codFabricante + "%", "%" + funcionario.matricula.ToString() + "%", "%%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]));

                    ReportDataSource NovaFonteDados = new ReportDataSource("RequisitadasDataSet", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.FerramentaMRequisitada.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }

            }
        }

        public void ListaRequisicao(Ferramenta ferramenta, Funcionario funcionario, Requisicao requisicao, string tipo)
        {
            
            if (tipo == "Abertas") // Requisições abertas
            {
                if (funcionario.matricula == 0) // Matricula vazia
                {

                    RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter adaptador = new RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter();
                    RequisiçãoDataSet.ListaDeRequisiçãoDataTable tabela = new RequisiçãoDataSet.ListaDeRequisiçãoDataTable();

                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByAbertas(tabela, "%" + ferramenta.codFerramenta + "%", "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%", "%" + funcionario.no_funcao + "%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]), "%%");

                    ReportDataSource NovaFonteDados = new ReportDataSource("GeraRelatorioRequisicao", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.RelatorioRequisição.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else // Matricula preenchida
                {
                    RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter adaptador = new RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter();
                    RequisiçãoDataSet.ListaDeRequisiçãoDataTable tabela = new RequisiçãoDataSet.ListaDeRequisiçãoDataTable();

                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByAbertas(tabela, "%" + ferramenta.codFerramenta + "%", "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%", "%" + funcionario.no_funcao + "%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]), "%" + funcionario.matricula + "%");

                    ReportDataSource NovaFonteDados = new ReportDataSource("GeraRelatorioRequisicao", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.RelatorioRequisição.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
            }
            else // Requisições baixadas
            {
                if (funcionario.matricula == 0) // Matricula vazia!
                {

                    RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter adaptador = new RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter();
                    RequisiçãoDataSet.ListaDeRequisiçãoDataTable tabela = new RequisiçãoDataSet.ListaDeRequisiçãoDataTable();

                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByBaixadas(tabela, "%" + ferramenta.codFerramenta + "%", "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%", "%" + funcionario.no_funcao + "%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]), "%%");

                    ReportDataSource NovaFonteDados = new ReportDataSource("GeraRelatorioRequisicao", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.RelatorioRequisição.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                else // Matricula preenchida
                {
                    RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter adaptador = new RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter();
                    RequisiçãoDataSet.ListaDeRequisiçãoDataTable tabela = new RequisiçãoDataSet.ListaDeRequisiçãoDataTable();
                   
                    adaptador.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["sga"].ConnectionString;
                    adaptador.FillByBaixadas(tabela, "%" + ferramenta.codFerramenta + "%", "%" + ferramenta.codFabricante + "%", "%" + ferramenta.codGrupo + "%", "%" + funcionario.no_funcao + "%", Convert.ToDateTime(requisicao.periodo[0]), Convert.ToDateTime(requisicao.periodo[1]), "%" + funcionario.matricula + "%");

                    ReportDataSource NovaFonteDados = new ReportDataSource("GeraRelatorioRequisicao", (DataTable)tabela);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(NovaFonteDados);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.RelatorioRequisição.rdlc";
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
            }
        }
    }
}
