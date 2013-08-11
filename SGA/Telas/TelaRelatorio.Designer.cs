namespace SGA.Telas
{
    partial class TelaRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ferramentasMRequisitadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferramentaMRequisitadaDataSet = new SGA.FerramentaMRequisitadaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferramentasMRequisitadasTableAdapter = new SGA.FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter();
            this.ferramentaDataSet = new SGA.FerramentaDataSet();
            this.requisiçãoDataSet = new SGA.RequisiçãoDataSet();
            this.listaDeFerramentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeFerramentasTableAdapter = new SGA.FerramentaDataSetTableAdapters.ListaDeFerramentasTableAdapter();
            this.listaDeRequisiçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeRequisiçãoTableAdapter = new SGA.RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentasMRequisitadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaMRequisitadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçãoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeFerramentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeRequisiçãoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ferramentasMRequisitadasBindingSource
            // 
            this.ferramentasMRequisitadasBindingSource.DataMember = "FerramentasMRequisitadas";
            this.ferramentasMRequisitadasBindingSource.DataSource = this.ferramentaMRequisitadaDataSet;
            // 
            // ferramentaMRequisitadaDataSet
            // 
            this.ferramentaMRequisitadaDataSet.DataSetName = "FerramentaMRequisitadaDataSet";
            this.ferramentaMRequisitadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GeraRelatorioRequisicao";
            reportDataSource1.Value = this.listaDeRequisiçãoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.RelatorioRequisição.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(930, 611);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // ferramentasMRequisitadasTableAdapter
            // 
            this.ferramentasMRequisitadasTableAdapter.ClearBeforeFill = true;
            // 
            // ferramentaDataSet
            // 
            this.ferramentaDataSet.DataSetName = "FerramentaDataSet";
            this.ferramentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisiçãoDataSet
            // 
            this.requisiçãoDataSet.DataSetName = "RequisiçãoDataSet";
            this.requisiçãoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaDeFerramentasBindingSource
            // 
            this.listaDeFerramentasBindingSource.DataMember = "ListaDeFerramentas";
            this.listaDeFerramentasBindingSource.DataSource = this.ferramentaDataSet;
            // 
            // listaDeFerramentasTableAdapter
            // 
            this.listaDeFerramentasTableAdapter.ClearBeforeFill = true;
            // 
            // listaDeRequisiçãoBindingSource
            // 
            this.listaDeRequisiçãoBindingSource.DataMember = "ListaDeRequisição";
            this.listaDeRequisiçãoBindingSource.DataSource = this.requisiçãoDataSet;
            // 
            // listaDeRequisiçãoTableAdapter
            // 
            this.listaDeRequisiçãoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 611);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.TelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferramentasMRequisitadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaMRequisitadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçãoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeFerramentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeRequisiçãoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RequisiçãoDataSet requisiçãoDataSet;
        private FerramentaDataSet ferramentaDataSet;
        private FerramentaMRequisitadaDataSet ferramentaMRequisitadaDataSet;
        private System.Windows.Forms.BindingSource ferramentasMRequisitadasBindingSource;
        private FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter ferramentasMRequisitadasTableAdapter;
        private System.Windows.Forms.BindingSource listaDeFerramentasBindingSource;
        private FerramentaDataSetTableAdapters.ListaDeFerramentasTableAdapter listaDeFerramentasTableAdapter;
        private System.Windows.Forms.BindingSource listaDeRequisiçãoBindingSource;
        private RequisiçãoDataSetTableAdapters.ListaDeRequisiçãoTableAdapter listaDeRequisiçãoTableAdapter;
    }
}