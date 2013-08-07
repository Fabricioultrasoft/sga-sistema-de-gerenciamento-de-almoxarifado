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
            this.gbxTipoRelatorio = new System.Windows.Forms.GroupBox();
            this.rbtnLista = new System.Windows.Forms.RadioButton();
            this.rbtnEventosSistema = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFuncionario = new System.Windows.Forms.TabPage();
            this.gbxPeriodoAdimissao = new System.Windows.Forms.GroupBox();
            this.lblpickerFinal = new System.Windows.Forms.Label();
            this.dtpickekAdmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpickekAdmissaoInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxPermissao = new System.Windows.Forms.ComboBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.tabPageFerramenta = new System.Windows.Forms.TabPage();
            this.gbxLmtPerAdmissao = new System.Windows.Forms.GroupBox();
            this.cbxTipoPeriodoFerramenta = new System.Windows.Forms.ComboBox();
            this.lbldtpickerFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpickerFinalFerramenta = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpickerInicioFerramenta = new System.Windows.Forms.DateTimePicker();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.tabPageRequisicao = new System.Windows.Forms.TabPage();
            this.cbxSituacaoRequisicao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxPeriodoRequisicao = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.gbxFiltrarDados = new System.Windows.Forms.GroupBox();
            this.rbtnFerramentasReqisitadas = new System.Windows.Forms.RadioButton();
            this.gbxFocoRelatório = new System.Windows.Forms.GroupBox();
            this.rbtnRequisicao = new System.Windows.Forms.RadioButton();
            this.rbtnFerramenta = new System.Windows.Forms.RadioButton();
            this.rbtnFuncionario = new System.Windows.Forms.RadioButton();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnLimparFuncionario = new System.Windows.Forms.Button();
            this.btnRedefinirPeriodoAdmissao = new System.Windows.Forms.Button();
            this.btnLimparFerramenta = new System.Windows.Forms.Button();
            this.btnRedPeriodoFerramenta = new System.Windows.Forms.Button();
            this.btnLimparRquisicao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxrelatorio.SuspendLayout();
            this.gbxTipoRelatorio.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFuncionario.SuspendLayout();
            this.gbxPeriodoAdimissao.SuspendLayout();
            this.tabPageFerramenta.SuspendLayout();
            this.gbxLmtPerAdmissao.SuspendLayout();
            this.tabPageRequisicao.SuspendLayout();
            this.gbxPeriodoRequisicao.SuspendLayout();
            this.gbxFiltrarDados.SuspendLayout();
            this.gbxFocoRelatório.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxrelatorio
            // 
            this.gbxrelatorio.Controls.Add(this.btnGerarRelatorio);
            this.gbxrelatorio.Controls.Add(this.btnCancelar);
            this.gbxrelatorio.Controls.Add(this.btnLimparTudo);
            this.gbxrelatorio.Controls.Add(this.gbxFocoRelatório);
            this.gbxrelatorio.Controls.Add(this.gbxFiltrarDados);
            this.gbxrelatorio.Controls.Add(this.gbxTipoRelatorio);
            this.gbxrelatorio.Location = new System.Drawing.Point(12, 13);
            this.gbxrelatorio.Name = "gbxrelatorio";
            this.gbxrelatorio.Size = new System.Drawing.Size(922, 620);
            this.gbxrelatorio.TabIndex = 0;
            this.gbxrelatorio.TabStop = false;
            // 
            // gbxTipoRelatorio
            // 
            this.gbxTipoRelatorio.Controls.Add(this.rbtnFerramentasReqisitadas);
            this.gbxTipoRelatorio.Controls.Add(this.rbtnLista);
            this.gbxTipoRelatorio.Controls.Add(this.rbtnEventosSistema);
            this.gbxTipoRelatorio.Location = new System.Drawing.Point(210, 29);
            this.gbxTipoRelatorio.Name = "gbxTipoRelatorio";
            this.gbxTipoRelatorio.Size = new System.Drawing.Size(265, 117);
            this.gbxTipoRelatorio.TabIndex = 2;
            this.gbxTipoRelatorio.TabStop = false;
            this.gbxTipoRelatorio.Text = "Tipo de relatório";
            // 
            // rbtnLista
            // 
            this.rbtnLista.AutoSize = true;
            this.rbtnLista.Location = new System.Drawing.Point(23, 55);
            this.rbtnLista.Name = "rbtnLista";
            this.rbtnLista.Size = new System.Drawing.Size(52, 20);
            this.rbtnLista.TabIndex = 1;
            this.rbtnLista.TabStop = true;
            this.rbtnLista.Text = "Lista";
            this.rbtnLista.UseVisualStyleBackColor = true;
            // 
            // rbtnEventosSistema
            // 
            this.rbtnEventosSistema.AutoSize = true;
            this.rbtnEventosSistema.Location = new System.Drawing.Point(23, 29);
            this.rbtnEventosSistema.Name = "rbtnEventosSistema";
            this.rbtnEventosSistema.Size = new System.Drawing.Size(136, 20);
            this.rbtnEventosSistema.TabIndex = 0;
            this.rbtnEventosSistema.TabStop = true;
            this.rbtnEventosSistema.Text = "Eventos no sistema";
            this.rbtnEventosSistema.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFuncionario);
            this.tabControl1.Controls.Add(this.tabPageFerramenta);
            this.tabControl1.Controls.Add(this.tabPageRequisicao);
            this.tabControl1.Location = new System.Drawing.Point(22, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFuncionario
            // 
            this.tabPageFuncionario.Controls.Add(this.btnLimparFuncionario);
            this.tabPageFuncionario.Controls.Add(this.cbxPermissao);
            this.tabPageFuncionario.Controls.Add(this.gbxPeriodoAdimissao);
            this.tabPageFuncionario.Controls.Add(this.lblMatricula);
            this.tabPageFuncionario.Controls.Add(this.cbxFuncao);
            this.tabPageFuncionario.Controls.Add(this.lblPermissao);
            this.tabPageFuncionario.Controls.Add(this.tbxMatricula);
            this.tabPageFuncionario.Controls.Add(this.lblFuncao);
            this.tabPageFuncionario.Location = new System.Drawing.Point(4, 25);
            this.tabPageFuncionario.Name = "tabPageFuncionario";
            this.tabPageFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuncionario.Size = new System.Drawing.Size(825, 300);
            this.tabPageFuncionario.TabIndex = 0;
            this.tabPageFuncionario.Text = "Funcionário";
            this.tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // gbxPeriodoAdimissao
            // 
            this.gbxPeriodoAdimissao.Controls.Add(this.lblpickerFinal);
            this.gbxPeriodoAdimissao.Controls.Add(this.dtpickekAdmissaoFinal);
            this.gbxPeriodoAdimissao.Controls.Add(this.label2);
            this.gbxPeriodoAdimissao.Controls.Add(this.dtpickekAdmissaoInicio);
            this.gbxPeriodoAdimissao.Controls.Add(this.btnRedefinirPeriodoAdmissao);
            this.gbxPeriodoAdimissao.Location = new System.Drawing.Point(26, 177);
            this.gbxPeriodoAdimissao.Name = "gbxPeriodoAdimissao";
            this.gbxPeriodoAdimissao.Size = new System.Drawing.Size(769, 89);
            this.gbxPeriodoAdimissao.TabIndex = 27;
            this.gbxPeriodoAdimissao.TabStop = false;
            this.gbxPeriodoAdimissao.Text = "Limitar Período de admissão";
            // 
            // lblpickerFinal
            // 
            this.lblpickerFinal.AutoSize = true;
            this.lblpickerFinal.Location = new System.Drawing.Point(316, 44);
            this.lblpickerFinal.Name = "lblpickerFinal";
            this.lblpickerFinal.Size = new System.Drawing.Size(140, 16);
            this.lblpickerFinal.TabIndex = 32;
            this.lblpickerFinal.Text = "Data final do período  :";
            // 
            // dtpickekAdmissaoFinal
            // 
            this.dtpickekAdmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickekAdmissaoFinal.Location = new System.Drawing.Point(462, 40);
            this.dtpickekAdmissaoFinal.Name = "dtpickekAdmissaoFinal";
            this.dtpickekAdmissaoFinal.Size = new System.Drawing.Size(99, 23);
            this.dtpickekAdmissaoFinal.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data de início do período:";
            // 
            // dtpickekAdmissaoInicio
            // 
            this.dtpickekAdmissaoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickekAdmissaoInicio.Location = new System.Drawing.Point(199, 41);
            this.dtpickekAdmissaoInicio.Name = "dtpickekAdmissaoInicio";
            this.dtpickekAdmissaoInicio.Size = new System.Drawing.Size(99, 23);
            this.dtpickekAdmissaoInicio.TabIndex = 29;
            // 
            // cbxPermissao
            // 
            this.cbxPermissao.FormattingEnabled = true;
            this.cbxPermissao.Location = new System.Drawing.Point(205, 125);
            this.cbxPermissao.Name = "cbxPermissao";
            this.cbxPermissao.Size = new System.Drawing.Size(167, 24);
            this.cbxPermissao.TabIndex = 42;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(134, 25);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 16);
            this.lblMatricula.TabIndex = 37;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(124, 128);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(72, 16);
            this.lblPermissao.TabIndex = 41;
            this.lblPermissao.Text = "Permissão:";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(142, 75);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(54, 16);
            this.lblFuncao.TabIndex = 38;
            this.lblFuncao.Text = "Função:";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(205, 22);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(167, 23);
            this.tbxMatricula.TabIndex = 40;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(205, 71);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(167, 24);
            this.cbxFuncao.TabIndex = 39;
            // 
            // tabPageFerramenta
            // 
            this.tabPageFerramenta.Controls.Add(this.btnLimparFerramenta);
            this.tabPageFerramenta.Controls.Add(this.cbxSituacao);
            this.tabPageFerramenta.Controls.Add(this.lblSituacao);
            this.tabPageFerramenta.Controls.Add(this.gbxLmtPerAdmissao);
            this.tabPageFerramenta.Controls.Add(this.tbxCodigo);
            this.tabPageFerramenta.Controls.Add(this.cbxFabricante);
            this.tabPageFerramenta.Controls.Add(this.lblGrupo);
            this.tabPageFerramenta.Controls.Add(this.lblFabricante);
            this.tabPageFerramenta.Controls.Add(this.cbxGrupo);
            this.tabPageFerramenta.Controls.Add(this.lblCodigo);
            this.tabPageFerramenta.Location = new System.Drawing.Point(4, 25);
            this.tabPageFerramenta.Name = "tabPageFerramenta";
            this.tabPageFerramenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFerramenta.Size = new System.Drawing.Size(825, 300);
            this.tabPageFerramenta.TabIndex = 1;
            this.tabPageFerramenta.Text = "Ferramenta";
            this.tabPageFerramenta.UseVisualStyleBackColor = true;
            // 
            // gbxLmtPerAdmissao
            // 
            this.gbxLmtPerAdmissao.Controls.Add(this.cbxTipoPeriodoFerramenta);
            this.gbxLmtPerAdmissao.Controls.Add(this.lbldtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.label1);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerFinalFerramenta);
            this.gbxLmtPerAdmissao.Controls.Add(this.lblDtInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerInicioFerramenta);
            this.gbxLmtPerAdmissao.Controls.Add(this.btnRedPeriodoFerramenta);
            this.gbxLmtPerAdmissao.Location = new System.Drawing.Point(21, 173);
            this.gbxLmtPerAdmissao.Name = "gbxLmtPerAdmissao";
            this.gbxLmtPerAdmissao.Size = new System.Drawing.Size(776, 87);
            this.gbxLmtPerAdmissao.TabIndex = 45;
            this.gbxLmtPerAdmissao.TabStop = false;
            this.gbxLmtPerAdmissao.Text = "Limitar período ";
            // 
            // cbxTipoPeriodoFerramenta
            // 
            this.cbxTipoPeriodoFerramenta.FormattingEnabled = true;
            this.cbxTipoPeriodoFerramenta.Location = new System.Drawing.Point(119, 37);
            this.cbxTipoPeriodoFerramenta.Name = "cbxTipoPeriodoFerramenta";
            this.cbxTipoPeriodoFerramenta.Size = new System.Drawing.Size(167, 24);
            this.cbxTipoPeriodoFerramenta.TabIndex = 47;
            // 
            // lbldtpickerFinal
            // 
            this.lbldtpickerFinal.AutoSize = true;
            this.lbldtpickerFinal.Location = new System.Drawing.Point(333, 50);
            this.lbldtpickerFinal.Name = "lbldtpickerFinal";
            this.lbldtpickerFinal.Size = new System.Drawing.Size(132, 16);
            this.lbldtpickerFinal.TabIndex = 32;
            this.lbldtpickerFinal.Text = "Data final do período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tipo período:";
            // 
            // dtpickerFinalFerramenta
            // 
            this.dtpickerFinalFerramenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinalFerramenta.Location = new System.Drawing.Point(482, 47);
            this.dtpickerFinalFerramenta.Name = "dtpickerFinalFerramenta";
            this.dtpickerFinalFerramenta.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinalFerramenta.TabIndex = 31;
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(310, 18);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(155, 16);
            this.lblDtInicio.TabIndex = 30;
            this.lblDtInicio.Text = "Data de início do período:";
            // 
            // dtpickerInicioFerramenta
            // 
            this.dtpickerInicioFerramenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicioFerramenta.Location = new System.Drawing.Point(482, 15);
            this.dtpickerInicioFerramenta.Name = "dtpickerInicioFerramenta";
            this.dtpickerInicioFerramenta.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicioFerramenta.TabIndex = 29;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(435, 84);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacao.TabIndex = 45;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(371, 87);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(62, 16);
            this.lblSituacao.TabIndex = 44;
            this.lblSituacao.Text = "Situação:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(98, 45);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 23);
            this.tbxCodigo.TabIndex = 38;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(435, 45);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(167, 24);
            this.cbxFabricante.TabIndex = 43;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(360, 48);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(73, 16);
            this.lblFabricante.TabIndex = 42;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 39;
            this.lblCodigo.Text = "Código:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(98, 84);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(167, 24);
            this.cbxGrupo.TabIndex = 41;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(50, 87);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(47, 16);
            this.lblGrupo.TabIndex = 40;
            this.lblGrupo.Text = "Grupo:";
            // 
            // tabPageRequisicao
            // 
            this.tabPageRequisicao.Controls.Add(this.btnLimparRquisicao);
            this.tabPageRequisicao.Controls.Add(this.cbxSituacaoRequisicao);
            this.tabPageRequisicao.Controls.Add(this.label6);
            this.tabPageRequisicao.Controls.Add(this.textBox1);
            this.tabPageRequisicao.Controls.Add(this.label7);
            this.tabPageRequisicao.Controls.Add(this.gbxPeriodoRequisicao);
            this.tabPageRequisicao.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequisicao.Name = "tabPageRequisicao";
            this.tabPageRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequisicao.Size = new System.Drawing.Size(825, 300);
            this.tabPageRequisicao.TabIndex = 2;
            this.tabPageRequisicao.Text = "Requisição";
            this.tabPageRequisicao.UseVisualStyleBackColor = true;
            // 
            // cbxSituacaoRequisicao
            // 
            this.cbxSituacaoRequisicao.FormattingEnabled = true;
            this.cbxSituacaoRequisicao.Location = new System.Drawing.Point(280, 94);
            this.cbxSituacaoRequisicao.Name = "cbxSituacaoRequisicao";
            this.cbxSituacaoRequisicao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacaoRequisicao.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Situação requisição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Código requisição:";
            // 
            // gbxPeriodoRequisicao
            // 
            this.gbxPeriodoRequisicao.Controls.Add(this.comboBox1);
            this.gbxPeriodoRequisicao.Controls.Add(this.label3);
            this.gbxPeriodoRequisicao.Controls.Add(this.label4);
            this.gbxPeriodoRequisicao.Controls.Add(this.dateTimePicker3);
            this.gbxPeriodoRequisicao.Controls.Add(this.label5);
            this.gbxPeriodoRequisicao.Controls.Add(this.dateTimePicker4);
            this.gbxPeriodoRequisicao.Controls.Add(this.button2);
            this.gbxPeriodoRequisicao.Location = new System.Drawing.Point(8, 164);
            this.gbxPeriodoRequisicao.Name = "gbxPeriodoRequisicao";
            this.gbxPeriodoRequisicao.Size = new System.Drawing.Size(804, 99);
            this.gbxPeriodoRequisicao.TabIndex = 28;
            this.gbxPeriodoRequisicao.TabStop = false;
            this.gbxPeriodoRequisicao.Text = "Limitar período ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data final do período:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tipo período:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(486, 59);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(99, 23);
            this.dateTimePicker3.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Data de início do período:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(486, 23);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(99, 23);
            this.dateTimePicker4.TabIndex = 29;
            // 
            // gbxFiltrarDados
            // 
            this.gbxFiltrarDados.Controls.Add(this.tabControl1);
            this.gbxFiltrarDados.Location = new System.Drawing.Point(25, 162);
            this.gbxFiltrarDados.Name = "gbxFiltrarDados";
            this.gbxFiltrarDados.Size = new System.Drawing.Size(873, 378);
            this.gbxFiltrarDados.TabIndex = 3;
            this.gbxFiltrarDados.TabStop = false;
            this.gbxFiltrarDados.Text = "Filtrar Dados";
            // 
            // rbtnFerramentasReqisitadas
            // 
            this.rbtnFerramentasReqisitadas.AutoSize = true;
            this.rbtnFerramentasReqisitadas.Location = new System.Drawing.Point(23, 81);
            this.rbtnFerramentasReqisitadas.Name = "rbtnFerramentasReqisitadas";
            this.rbtnFerramentasReqisitadas.Size = new System.Drawing.Size(203, 20);
            this.rbtnFerramentasReqisitadas.TabIndex = 2;
            this.rbtnFerramentasReqisitadas.TabStop = true;
            this.rbtnFerramentasReqisitadas.Text = "Ferramentas mais requisitadas";
            this.rbtnFerramentasReqisitadas.UseVisualStyleBackColor = true;
            // 
            // gbxFocoRelatório
            // 
            this.gbxFocoRelatório.Controls.Add(this.rbtnRequisicao);
            this.gbxFocoRelatório.Controls.Add(this.rbtnFerramenta);
            this.gbxFocoRelatório.Controls.Add(this.rbtnFuncionario);
            this.gbxFocoRelatório.Location = new System.Drawing.Point(510, 29);
            this.gbxFocoRelatório.Name = "gbxFocoRelatório";
            this.gbxFocoRelatório.Size = new System.Drawing.Size(151, 117);
            this.gbxFocoRelatório.TabIndex = 3;
            this.gbxFocoRelatório.TabStop = false;
            this.gbxFocoRelatório.Text = "Foco do relatório";
            // 
            // rbtnRequisicao
            // 
            this.rbtnRequisicao.AutoSize = true;
            this.rbtnRequisicao.Location = new System.Drawing.Point(25, 81);
            this.rbtnRequisicao.Name = "rbtnRequisicao";
            this.rbtnRequisicao.Size = new System.Drawing.Size(87, 20);
            this.rbtnRequisicao.TabIndex = 2;
            this.rbtnRequisicao.TabStop = true;
            this.rbtnRequisicao.Text = "Requisição";
            this.rbtnRequisicao.UseVisualStyleBackColor = true;
            // 
            // rbtnFerramenta
            // 
            this.rbtnFerramenta.AutoSize = true;
            this.rbtnFerramenta.Location = new System.Drawing.Point(25, 55);
            this.rbtnFerramenta.Name = "rbtnFerramenta";
            this.rbtnFerramenta.Size = new System.Drawing.Size(93, 20);
            this.rbtnFerramenta.TabIndex = 1;
            this.rbtnFerramenta.TabStop = true;
            this.rbtnFerramenta.Text = "Ferramenta";
            this.rbtnFerramenta.UseVisualStyleBackColor = true;
            // 
            // rbtnFuncionario
            // 
            this.rbtnFuncionario.AutoSize = true;
            this.rbtnFuncionario.Location = new System.Drawing.Point(25, 29);
            this.rbtnFuncionario.Name = "rbtnFuncionario";
            this.rbtnFuncionario.Size = new System.Drawing.Size(92, 20);
            this.rbtnFuncionario.TabIndex = 0;
            this.rbtnFuncionario.TabStop = true;
            this.rbtnFuncionario.Text = "Funcionário";
            this.rbtnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Image = global::SGA.Properties.Resources._1375818175_Generate_tables1;
            this.btnGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(389, 555);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(148, 44);
            this.btnGerarRelatorio.TabIndex = 47;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(630, 555);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Image = global::SGA.Properties.Resources._1375863032_edit_clear;
            this.btnLimparTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparTudo.Location = new System.Drawing.Point(148, 555);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(148, 44);
            this.btnLimparTudo.TabIndex = 45;
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = true;
            // 
            // btnLimparFuncionario
            // 
            this.btnLimparFuncionario.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFuncionario.Location = new System.Drawing.Point(478, 61);
            this.btnLimparFuncionario.Name = "btnLimparFuncionario";
            this.btnLimparFuncionario.Size = new System.Drawing.Size(148, 44);
            this.btnLimparFuncionario.TabIndex = 43;
            this.btnLimparFuncionario.Text = "Limpar";
            this.btnLimparFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnRedefinirPeriodoAdmissao
            // 
            this.btnRedefinirPeriodoAdmissao.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.btnRedefinirPeriodoAdmissao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedefinirPeriodoAdmissao.Location = new System.Drawing.Point(605, 28);
            this.btnRedefinirPeriodoAdmissao.Name = "btnRedefinirPeriodoAdmissao";
            this.btnRedefinirPeriodoAdmissao.Size = new System.Drawing.Size(148, 44);
            this.btnRedefinirPeriodoAdmissao.TabIndex = 28;
            this.btnRedefinirPeriodoAdmissao.Text = "Redefinir Período";
            this.btnRedefinirPeriodoAdmissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedefinirPeriodoAdmissao.UseVisualStyleBackColor = true;
            // 
            // btnLimparFerramenta
            // 
            this.btnLimparFerramenta.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFerramenta.Location = new System.Drawing.Point(649, 53);
            this.btnLimparFerramenta.Name = "btnLimparFerramenta";
            this.btnLimparFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnLimparFerramenta.TabIndex = 46;
            this.btnLimparFerramenta.Text = "Limpar";
            this.btnLimparFerramenta.UseVisualStyleBackColor = true;
            // 
            // btnRedPeriodoFerramenta
            // 
            this.btnRedPeriodoFerramenta.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.btnRedPeriodoFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedPeriodoFerramenta.Location = new System.Drawing.Point(611, 22);
            this.btnRedPeriodoFerramenta.Name = "btnRedPeriodoFerramenta";
            this.btnRedPeriodoFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnRedPeriodoFerramenta.TabIndex = 28;
            this.btnRedPeriodoFerramenta.Text = "Redefinir Período";
            this.btnRedPeriodoFerramenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedPeriodoFerramenta.UseVisualStyleBackColor = true;
            // 
            // btnLimparRquisicao
            // 
            this.btnLimparRquisicao.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparRquisicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparRquisicao.Location = new System.Drawing.Point(513, 58);
            this.btnLimparRquisicao.Name = "btnLimparRquisicao";
            this.btnLimparRquisicao.Size = new System.Drawing.Size(148, 44);
            this.btnLimparRquisicao.TabIndex = 44;
            this.btnLimparRquisicao.Text = "Limpar";
            this.btnLimparRquisicao.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(624, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Redefinir Período";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
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
            this.gbxTipoRelatorio.ResumeLayout(false);
            this.gbxTipoRelatorio.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFuncionario.ResumeLayout(false);
            this.tabPageFuncionario.PerformLayout();
            this.gbxPeriodoAdimissao.ResumeLayout(false);
            this.gbxPeriodoAdimissao.PerformLayout();
            this.tabPageFerramenta.ResumeLayout(false);
            this.tabPageFerramenta.PerformLayout();
            this.gbxLmtPerAdmissao.ResumeLayout(false);
            this.gbxLmtPerAdmissao.PerformLayout();
            this.tabPageRequisicao.ResumeLayout(false);
            this.tabPageRequisicao.PerformLayout();
            this.gbxPeriodoRequisicao.ResumeLayout(false);
            this.gbxPeriodoRequisicao.PerformLayout();
            this.gbxFiltrarDados.ResumeLayout(false);
            this.gbxFocoRelatório.ResumeLayout(false);
            this.gbxFocoRelatório.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxrelatorio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFuncionario;
        private System.Windows.Forms.TabPage tabPageFerramenta;
        private System.Windows.Forms.TabPage tabPageRequisicao;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.GroupBox gbxLmtPerAdmissao;
        private System.Windows.Forms.Label lbldtpickerFinal;
        private System.Windows.Forms.DateTimePicker dtpickerFinalFerramenta;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpickerInicioFerramenta;
        private System.Windows.Forms.Button btnRedPeriodoFerramenta;
        private System.Windows.Forms.ComboBox cbxTipoPeriodoFerramenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxPeriodoAdimissao;
        private System.Windows.Forms.Label lblpickerFinal;
        private System.Windows.Forms.DateTimePicker dtpickekAdmissaoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpickekAdmissaoInicio;
        private System.Windows.Forms.Button btnRedefinirPeriodoAdmissao;
        private System.Windows.Forms.ComboBox cbxPermissao;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnLimparFuncionario;
        private System.Windows.Forms.GroupBox gbxTipoRelatorio;
        private System.Windows.Forms.RadioButton rbtnLista;
        private System.Windows.Forms.RadioButton rbtnEventosSistema;
        private System.Windows.Forms.GroupBox gbxPeriodoRequisicao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxSituacaoRequisicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxFiltrarDados;
        private System.Windows.Forms.Button btnLimparFerramenta;
        private System.Windows.Forms.Button btnLimparRquisicao;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.GroupBox gbxFocoRelatório;
        private System.Windows.Forms.RadioButton rbtnRequisicao;
        private System.Windows.Forms.RadioButton rbtnFerramenta;
        private System.Windows.Forms.RadioButton rbtnFuncionario;
        private System.Windows.Forms.RadioButton rbtnFerramentasReqisitadas;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnCancelar;
    }
}