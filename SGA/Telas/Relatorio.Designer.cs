namespace SGA.Telas
{
    partial class Relatorio
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
            this.gbxrelatorio = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFuncionario = new System.Windows.Forms.TabPage();
            this.tabPageFerramenta = new System.Windows.Forms.TabPage();
            this.tabPageRequisicao = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnREventos = new System.Windows.Forms.RadioButton();
            this.rbtnRLista = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxrelatorio.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFuncionario.SuspendLayout();
            this.tabPageFerramenta.SuspendLayout();
            this.tabPageRequisicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxrelatorio
            // 
            this.gbxrelatorio.Controls.Add(this.tabControl1);
            this.gbxrelatorio.Location = new System.Drawing.Point(12, 13);
            this.gbxrelatorio.Name = "gbxrelatorio";
            this.gbxrelatorio.Size = new System.Drawing.Size(922, 620);
            this.gbxrelatorio.TabIndex = 0;
            this.gbxrelatorio.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFuncionario);
            this.tabControl1.Controls.Add(this.tabPageFerramenta);
            this.tabControl1.Controls.Add(this.tabPageRequisicao);
            this.tabControl1.Location = new System.Drawing.Point(7, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFuncionario
            // 
            this.tabPageFuncionario.Controls.Add(this.reportViewer1);
            this.tabPageFuncionario.Controls.Add(this.comboBox1);
            this.tabPageFuncionario.Controls.Add(this.groupBox1);
            this.tabPageFuncionario.Location = new System.Drawing.Point(4, 25);
            this.tabPageFuncionario.Name = "tabPageFuncionario";
            this.tabPageFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuncionario.Size = new System.Drawing.Size(901, 562);
            this.tabPageFuncionario.TabIndex = 0;
            this.tabPageFuncionario.Text = "Funcionário";
            this.tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabPageFerramenta
            // 
            this.tabPageFerramenta.Controls.Add(this.groupBox2);
            this.tabPageFerramenta.Location = new System.Drawing.Point(4, 25);
            this.tabPageFerramenta.Name = "tabPageFerramenta";
            this.tabPageFerramenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFerramenta.Size = new System.Drawing.Size(901, 562);
            this.tabPageFerramenta.TabIndex = 1;
            this.tabPageFerramenta.Text = "Ferramenta";
            this.tabPageFerramenta.UseVisualStyleBackColor = true;
            // 
            // tabPageRequisicao
            // 
            this.tabPageRequisicao.Controls.Add(this.groupBox3);
            this.tabPageRequisicao.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequisicao.Name = "tabPageRequisicao";
            this.tabPageRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequisicao.Size = new System.Drawing.Size(901, 562);
            this.tabPageRequisicao.TabIndex = 2;
            this.tabPageRequisicao.Text = "Requisição";
            this.tabPageRequisicao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRLista);
            this.groupBox1.Controls.Add(this.rbtnREventos);
            this.groupBox1.Location = new System.Drawing.Point(45, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de relatório";
            // 
            // rbtnREventos
            // 
            this.rbtnREventos.AutoSize = true;
            this.rbtnREventos.Location = new System.Drawing.Point(17, 23);
            this.rbtnREventos.Name = "rbtnREventos";
            this.rbtnREventos.Size = new System.Drawing.Size(70, 20);
            this.rbtnREventos.TabIndex = 0;
            this.rbtnREventos.TabStop = true;
            this.rbtnREventos.Text = "Eventos";
            this.rbtnREventos.UseVisualStyleBackColor = true;
            // 
            // rbtnRLista
            // 
            this.rbtnRLista.AutoSize = true;
            this.rbtnRLista.Location = new System.Drawing.Point(17, 49);
            this.rbtnRLista.Name = "rbtnRLista";
            this.rbtnRLista.Size = new System.Drawing.Size(52, 20);
            this.rbtnRLista.TabIndex = 1;
            this.rbtnRLista.TabStop = true;
            this.rbtnRLista.Text = "Lista";
            this.rbtnRLista.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(45, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de relatório";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lista";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Eventos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(45, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 129);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de relatório";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lista";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(7, 254);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(888, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxrelatorio);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.gbxrelatorio.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFuncionario.ResumeLayout(false);
            this.tabPageFerramenta.ResumeLayout(false);
            this.tabPageRequisicao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxrelatorio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRLista;
        private System.Windows.Forms.RadioButton rbtnREventos;
        private System.Windows.Forms.TabPage tabPageFerramenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TabPage tabPageRequisicao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}