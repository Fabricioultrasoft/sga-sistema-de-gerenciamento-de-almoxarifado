﻿namespace SGA.Telas
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.gbxFocoRelatório = new System.Windows.Forms.GroupBox();
            this.rbtnRequisicao = new System.Windows.Forms.RadioButton();
            this.rbtnFerramenta = new System.Windows.Forms.RadioButton();
            this.rbtnFuncionario = new System.Windows.Forms.RadioButton();
            this.gbxFiltrarDados = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFuncionario = new System.Windows.Forms.TabPage();
            this.btnLimparFuncionario = new System.Windows.Forms.Button();
            this.cbxPermissao = new System.Windows.Forms.ComboBox();
            this.gbxPeriodoAdimissao = new System.Windows.Forms.GroupBox();
            this.lblpickerFinal = new System.Windows.Forms.Label();
            this.dtpickekAdmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpickekAdmissaoInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRedefinirPeriodoAdmissao = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.tabPageFerramenta = new System.Windows.Forms.TabPage();
            this.btnLimparFerramenta = new System.Windows.Forms.Button();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.gbxLmtPerAdmissao = new System.Windows.Forms.GroupBox();
            this.lbldtpickerFinal = new System.Windows.Forms.Label();
            this.dtpickerFinalFerramenta = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpickerInicioFerramenta = new System.Windows.Forms.DateTimePicker();
            this.btnRedPeriodoFerramenta = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPageRequisicao = new System.Windows.Forms.TabPage();
            this.btnLimparRquisicao = new System.Windows.Forms.Button();
            this.cbxSituacaoRequisicao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxPeriodoRequisicao = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpickerInicio = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxTipoRelatorio = new System.Windows.Forms.GroupBox();
            this.rbtnFerramentasReqisitadas = new System.Windows.Forms.RadioButton();
            this.rbtnLista = new System.Windows.Forms.RadioButton();
            this.rbtnEventosSistema = new System.Windows.Forms.RadioButton();
            this.gbxrelatorio.SuspendLayout();
            this.gbxFocoRelatório.SuspendLayout();
            this.gbxFiltrarDados.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFuncionario.SuspendLayout();
            this.gbxPeriodoAdimissao.SuspendLayout();
            this.tabPageFerramenta.SuspendLayout();
            this.gbxLmtPerAdmissao.SuspendLayout();
            this.tabPageRequisicao.SuspendLayout();
            this.gbxPeriodoRequisicao.SuspendLayout();
            this.gbxTipoRelatorio.SuspendLayout();
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
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // gbxFocoRelatório
            // 
            this.gbxFocoRelatório.Controls.Add(this.rbtnRequisicao);
            this.gbxFocoRelatório.Controls.Add(this.rbtnFerramenta);
            this.gbxFocoRelatório.Controls.Add(this.rbtnFuncionario);
            this.gbxFocoRelatório.Location = new System.Drawing.Point(209, 22);
            this.gbxFocoRelatório.Name = "gbxFocoRelatório";
            this.gbxFocoRelatório.Size = new System.Drawing.Size(151, 117);
            this.gbxFocoRelatório.TabIndex = 3;
            this.gbxFocoRelatório.TabStop = false;
            this.gbxFocoRelatório.Text = "Foco do relatório";
            // 
            // rbtnRequisicao
            // 
            this.rbtnRequisicao.AutoSize = true;
            this.rbtnRequisicao.Location = new System.Drawing.Point(25, 29);
            this.rbtnRequisicao.Name = "rbtnRequisicao";
            this.rbtnRequisicao.Size = new System.Drawing.Size(87, 20);
            this.rbtnRequisicao.TabIndex = 2;
            this.rbtnRequisicao.TabStop = true;
            this.rbtnRequisicao.Text = "Requisição";
            this.rbtnRequisicao.UseVisualStyleBackColor = true;
            this.rbtnRequisicao.CheckedChanged += new System.EventHandler(this.rbtnRequisicao_CheckedChanged);
            // 
            // rbtnFerramenta
            // 
            this.rbtnFerramenta.AutoSize = true;
            this.rbtnFerramenta.Location = new System.Drawing.Point(25, 81);
            this.rbtnFerramenta.Name = "rbtnFerramenta";
            this.rbtnFerramenta.Size = new System.Drawing.Size(93, 20);
            this.rbtnFerramenta.TabIndex = 1;
            this.rbtnFerramenta.TabStop = true;
            this.rbtnFerramenta.Text = "Ferramenta";
            this.rbtnFerramenta.UseVisualStyleBackColor = true;
            this.rbtnFerramenta.CheckedChanged += new System.EventHandler(this.rbtnFerramenta_CheckedChanged);
            // 
            // rbtnFuncionario
            // 
            this.rbtnFuncionario.AutoSize = true;
            this.rbtnFuncionario.Checked = true;
            this.rbtnFuncionario.Location = new System.Drawing.Point(26, 55);
            this.rbtnFuncionario.Name = "rbtnFuncionario";
            this.rbtnFuncionario.Size = new System.Drawing.Size(92, 20);
            this.rbtnFuncionario.TabIndex = 0;
            this.rbtnFuncionario.TabStop = true;
            this.rbtnFuncionario.Text = "Funcionário";
            this.rbtnFuncionario.UseVisualStyleBackColor = true;
            this.rbtnFuncionario.CheckedChanged += new System.EventHandler(this.rbtnFuncionario_CheckedChanged);
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
            // btnLimparFuncionario
            // 
            this.btnLimparFuncionario.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFuncionario.Location = new System.Drawing.Point(647, 60);
            this.btnLimparFuncionario.Name = "btnLimparFuncionario";
            this.btnLimparFuncionario.Size = new System.Drawing.Size(148, 44);
            this.btnLimparFuncionario.TabIndex = 43;
            this.btnLimparFuncionario.Text = "Limpar";
            this.btnLimparFuncionario.UseVisualStyleBackColor = true;
            this.btnLimparFuncionario.Click += new System.EventHandler(this.btnLimparFuncionario_Click);
            // 
            // cbxPermissao
            // 
            this.cbxPermissao.FormattingEnabled = true;
            this.cbxPermissao.Location = new System.Drawing.Point(109, 125);
            this.cbxPermissao.Name = "cbxPermissao";
            this.cbxPermissao.Size = new System.Drawing.Size(167, 24);
            this.cbxPermissao.TabIndex = 42;
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
            this.dtpickekAdmissaoFinal.ValueChanged += new System.EventHandler(this.dtpickekAdmissaoFinal_ValueChanged);
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
            this.dtpickekAdmissaoInicio.ValueChanged += new System.EventHandler(this.dtpickekAdmissaoInicio_ValueChanged);
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
            this.btnRedefinirPeriodoAdmissao.Click += new System.EventHandler(this.btnRedefinirPeriodoAdmissao_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(38, 25);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 16);
            this.lblMatricula.TabIndex = 37;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(109, 71);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(167, 24);
            this.cbxFuncao.TabIndex = 39;
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(28, 128);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(72, 16);
            this.lblPermissao.TabIndex = 41;
            this.lblPermissao.Text = "Permissão:";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(109, 22);
            this.tbxMatricula.MaxLength = 6;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(167, 23);
            this.tbxMatricula.TabIndex = 40;
            this.tbxMatricula.TextChanged += new System.EventHandler(this.tbxMatricula_TextChanged);
            this.tbxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatricula_KeyPress);
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(46, 75);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(54, 16);
            this.lblFuncao.TabIndex = 38;
            this.lblFuncao.Text = "Função:";
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
            // btnLimparFerramenta
            // 
            this.btnLimparFerramenta.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFerramenta.Location = new System.Drawing.Point(632, 62);
            this.btnLimparFerramenta.Name = "btnLimparFerramenta";
            this.btnLimparFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnLimparFerramenta.TabIndex = 46;
            this.btnLimparFerramenta.Text = "Limpar";
            this.btnLimparFerramenta.UseVisualStyleBackColor = true;
            this.btnLimparFerramenta.Click += new System.EventHandler(this.btnLimparFerramenta_Click);
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(418, 93);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacao.TabIndex = 45;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(354, 96);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(62, 16);
            this.lblSituacao.TabIndex = 44;
            this.lblSituacao.Text = "Situação:";
            // 
            // gbxLmtPerAdmissao
            // 
            this.gbxLmtPerAdmissao.Controls.Add(this.lbldtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerFinalFerramenta);
            this.gbxLmtPerAdmissao.Controls.Add(this.lblDtInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerInicioFerramenta);
            this.gbxLmtPerAdmissao.Controls.Add(this.btnRedPeriodoFerramenta);
            this.gbxLmtPerAdmissao.Location = new System.Drawing.Point(21, 173);
            this.gbxLmtPerAdmissao.Name = "gbxLmtPerAdmissao";
            this.gbxLmtPerAdmissao.Size = new System.Drawing.Size(776, 80);
            this.gbxLmtPerAdmissao.TabIndex = 45;
            this.gbxLmtPerAdmissao.TabStop = false;
            this.gbxLmtPerAdmissao.Text = "Limitar período de aquisição";
            // 
            // lbldtpickerFinal
            // 
            this.lbldtpickerFinal.AutoSize = true;
            this.lbldtpickerFinal.Location = new System.Drawing.Point(333, 34);
            this.lbldtpickerFinal.Name = "lbldtpickerFinal";
            this.lbldtpickerFinal.Size = new System.Drawing.Size(132, 16);
            this.lbldtpickerFinal.TabIndex = 32;
            this.lbldtpickerFinal.Text = "Data final do período:";
            // 
            // dtpickerFinalFerramenta
            // 
            this.dtpickerFinalFerramenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinalFerramenta.Location = new System.Drawing.Point(482, 31);
            this.dtpickerFinalFerramenta.Name = "dtpickerFinalFerramenta";
            this.dtpickerFinalFerramenta.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinalFerramenta.TabIndex = 31;
            this.dtpickerFinalFerramenta.ValueChanged += new System.EventHandler(this.dtpickerFinalFerramenta_ValueChanged);
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(17, 34);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(155, 16);
            this.lblDtInicio.TabIndex = 30;
            this.lblDtInicio.Text = "Data de início do período:";
            // 
            // dtpickerInicioFerramenta
            // 
            this.dtpickerInicioFerramenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicioFerramenta.Location = new System.Drawing.Point(189, 31);
            this.dtpickerInicioFerramenta.Name = "dtpickerInicioFerramenta";
            this.dtpickerInicioFerramenta.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicioFerramenta.TabIndex = 29;
            this.dtpickerInicioFerramenta.ValueChanged += new System.EventHandler(this.dtpickerInicioFerramenta_ValueChanged);
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
            this.btnRedPeriodoFerramenta.Click += new System.EventHandler(this.btnRedPeriodoFerramenta_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(81, 54);
            this.tbxCodigo.MaxLength = 5;
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 23);
            this.tbxCodigo.TabIndex = 38;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(418, 54);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(167, 24);
            this.cbxFabricante.TabIndex = 43;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(33, 96);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(47, 16);
            this.lblGrupo.TabIndex = 40;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(343, 57);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(73, 16);
            this.lblFabricante.TabIndex = 42;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(81, 93);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(167, 24);
            this.cbxGrupo.TabIndex = 41;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 39;
            this.lblCodigo.Text = "Código:";
            // 
            // tabPageRequisicao
            // 
            this.tabPageRequisicao.Controls.Add(this.btnLimparRquisicao);
            this.tabPageRequisicao.Controls.Add(this.cbxSituacaoRequisicao);
            this.tabPageRequisicao.Controls.Add(this.label6);
            this.tabPageRequisicao.Controls.Add(this.gbxPeriodoRequisicao);
            this.tabPageRequisicao.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequisicao.Name = "tabPageRequisicao";
            this.tabPageRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequisicao.Size = new System.Drawing.Size(825, 300);
            this.tabPageRequisicao.TabIndex = 2;
            this.tabPageRequisicao.Text = "Requisição";
            this.tabPageRequisicao.UseVisualStyleBackColor = true;
            // 
            // btnLimparRquisicao
            // 
            this.btnLimparRquisicao.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimparRquisicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparRquisicao.Location = new System.Drawing.Point(512, 68);
            this.btnLimparRquisicao.Name = "btnLimparRquisicao";
            this.btnLimparRquisicao.Size = new System.Drawing.Size(148, 44);
            this.btnLimparRquisicao.TabIndex = 44;
            this.btnLimparRquisicao.Text = "Limpar";
            this.btnLimparRquisicao.UseVisualStyleBackColor = true;
            this.btnLimparRquisicao.Click += new System.EventHandler(this.btnLimparRquisicao_Click);
            // 
            // cbxSituacaoRequisicao
            // 
            this.cbxSituacaoRequisicao.FormattingEnabled = true;
            this.cbxSituacaoRequisicao.Location = new System.Drawing.Point(262, 79);
            this.cbxSituacaoRequisicao.Name = "cbxSituacaoRequisicao";
            this.cbxSituacaoRequisicao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacaoRequisicao.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Situação requisição:";
            // 
            // gbxPeriodoRequisicao
            // 
            this.gbxPeriodoRequisicao.Controls.Add(this.label3);
            this.gbxPeriodoRequisicao.Controls.Add(this.dtpickerFinal);
            this.gbxPeriodoRequisicao.Controls.Add(this.label5);
            this.gbxPeriodoRequisicao.Controls.Add(this.dtpickerInicio);
            this.gbxPeriodoRequisicao.Controls.Add(this.button2);
            this.gbxPeriodoRequisicao.Location = new System.Drawing.Point(8, 164);
            this.gbxPeriodoRequisicao.Name = "gbxPeriodoRequisicao";
            this.gbxPeriodoRequisicao.Size = new System.Drawing.Size(804, 78);
            this.gbxPeriodoRequisicao.TabIndex = 28;
            this.gbxPeriodoRequisicao.TabStop = false;
            this.gbxPeriodoRequisicao.Text = "Limitar período requisição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data final do período:";
            // 
            // dtpickerFinal
            // 
            this.dtpickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinal.Location = new System.Drawing.Point(486, 29);
            this.dtpickerFinal.Name = "dtpickerFinal";
            this.dtpickerFinal.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinal.TabIndex = 31;
            this.dtpickerFinal.ValueChanged += new System.EventHandler(this.dtpickerFinal_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Data de início do período:";
            // 
            // dtpickerInicio
            // 
            this.dtpickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicio.Location = new System.Drawing.Point(176, 29);
            this.dtpickerInicio.Name = "dtpickerInicio";
            this.dtpickerInicio.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicio.TabIndex = 29;
            this.dtpickerInicio.ValueChanged += new System.EventHandler(this.dtpickerInicio_ValueChanged);
            // 
            // button2
            // 
            this.button2.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(636, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Redefinir Período";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbxTipoRelatorio
            // 
            this.gbxTipoRelatorio.Controls.Add(this.rbtnFerramentasReqisitadas);
            this.gbxTipoRelatorio.Controls.Add(this.rbtnLista);
            this.gbxTipoRelatorio.Controls.Add(this.rbtnEventosSistema);
            this.gbxTipoRelatorio.Location = new System.Drawing.Point(485, 22);
            this.gbxTipoRelatorio.Name = "gbxTipoRelatorio";
            this.gbxTipoRelatorio.Size = new System.Drawing.Size(265, 117);
            this.gbxTipoRelatorio.TabIndex = 2;
            this.gbxTipoRelatorio.TabStop = false;
            this.gbxTipoRelatorio.Text = "Tipo de relatório";
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
            this.rbtnFerramentasReqisitadas.CheckedChanged += new System.EventHandler(this.rbtnFerramentasReqisitadas_CheckedChanged);
            // 
            // rbtnLista
            // 
            this.rbtnLista.AutoSize = true;
            this.rbtnLista.Checked = true;
            this.rbtnLista.Location = new System.Drawing.Point(23, 29);
            this.rbtnLista.Name = "rbtnLista";
            this.rbtnLista.Size = new System.Drawing.Size(52, 20);
            this.rbtnLista.TabIndex = 1;
            this.rbtnLista.TabStop = true;
            this.rbtnLista.Text = "Lista";
            this.rbtnLista.UseVisualStyleBackColor = true;
            this.rbtnLista.CheckedChanged += new System.EventHandler(this.rbtnLista_CheckedChanged);
            // 
            // rbtnEventosSistema
            // 
            this.rbtnEventosSistema.AutoSize = true;
            this.rbtnEventosSistema.Location = new System.Drawing.Point(23, 55);
            this.rbtnEventosSistema.Name = "rbtnEventosSistema";
            this.rbtnEventosSistema.Size = new System.Drawing.Size(136, 20);
            this.rbtnEventosSistema.TabIndex = 0;
            this.rbtnEventosSistema.Text = "Eventos no sistema";
            this.rbtnEventosSistema.UseVisualStyleBackColor = true;
            this.rbtnEventosSistema.CheckedChanged += new System.EventHandler(this.rbtnEventosSistema_CheckedChanged);
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
            this.gbxFocoRelatório.ResumeLayout(false);
            this.gbxFocoRelatório.PerformLayout();
            this.gbxFiltrarDados.ResumeLayout(false);
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
            this.gbxTipoRelatorio.ResumeLayout(false);
            this.gbxTipoRelatorio.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpickerFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpickerInicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxSituacaoRequisicao;
        private System.Windows.Forms.Label label6;
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