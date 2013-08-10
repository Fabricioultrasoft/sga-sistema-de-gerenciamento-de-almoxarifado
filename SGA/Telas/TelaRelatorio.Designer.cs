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
            this.ferramentaDataSet = new SGA.FerramentaDataSet();
            this.tb_requisicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisiçãoDataSet = new SGA.RequisiçãoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_requisicaoTableAdapter = new SGA.RequisiçãoDataSetTableAdapters.tb_requisicaoTableAdapter();
            this.tb_ferramentaTableAdapter = new SGA.FerramentaDataSetTableAdapters.tb_ferramentaTableAdapter();
            this.tbferramentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferramentaMRequisitadaDataSet = new SGA.FerramentaMRequisitadaDataSet();
            this.ferramentasMRequisitadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferramentasMRequisitadasTableAdapter = new SGA.FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_requisicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçãoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbferramentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaMRequisitadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentasMRequisitadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ferramentaDataSet
            // 
            this.ferramentaDataSet.DataSetName = "FerramentaDataSet";
            this.ferramentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_requisicaoBindingSource
            // 
            this.tb_requisicaoBindingSource.DataMember = "tb_requisicao";
            this.tb_requisicaoBindingSource.DataSource = this.requisiçãoDataSet;
            // 
            // requisiçãoDataSet
            // 
            this.requisiçãoDataSet.DataSetName = "RequisiçãoDataSet";
            this.requisiçãoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RequisitadasDataSet";
            reportDataSource1.Value = this.ferramentasMRequisitadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGA.Telas.FerramentaMRequisitada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(930, 611);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // tb_requisicaoTableAdapter
            // 
            this.tb_requisicaoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ferramentaTableAdapter
            // 
            this.tb_ferramentaTableAdapter.ClearBeforeFill = true;
            // 
            // tbferramentaBindingSource
            // 
            this.tbferramentaBindingSource.DataMember = "tb_ferramenta";
            this.tbferramentaBindingSource.DataSource = this.ferramentaDataSet;
            // 
            // ferramentaMRequisitadaDataSet
            // 
            this.ferramentaMRequisitadaDataSet.DataSetName = "FerramentaMRequisitadaDataSet";
            this.ferramentaMRequisitadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ferramentasMRequisitadasBindingSource
            // 
            this.ferramentasMRequisitadasBindingSource.DataMember = "FerramentasMRequisitadas";
            this.ferramentasMRequisitadasBindingSource.DataSource = this.ferramentaMRequisitadaDataSet;
            // 
            // ferramentasMRequisitadasTableAdapter
            // 
            this.ferramentasMRequisitadasTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_requisicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisiçãoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbferramentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentaMRequisitadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferramentasMRequisitadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RequisiçãoDataSet requisiçãoDataSet;
        private RequisiçãoDataSetTableAdapters.tb_requisicaoTableAdapter tb_requisicaoTableAdapter;
        private System.Windows.Forms.BindingSource tb_requisicaoBindingSource;
        private System.Windows.Forms.BindingSource tbferramentaBindingSource;
        private FerramentaDataSet ferramentaDataSet;
        private FerramentaDataSetTableAdapters.tb_ferramentaTableAdapter tb_ferramentaTableAdapter;
        private FerramentaMRequisitadaDataSet ferramentaMRequisitadaDataSet;
        private System.Windows.Forms.BindingSource ferramentasMRequisitadasBindingSource;
        private FerramentaMRequisitadaDataSetTableAdapters.FerramentasMRequisitadasTableAdapter ferramentasMRequisitadasTableAdapter;
    }
}