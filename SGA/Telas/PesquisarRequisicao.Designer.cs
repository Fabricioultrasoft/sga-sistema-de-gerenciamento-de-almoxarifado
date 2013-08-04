namespace SGA.Telas
{
    partial class PesquisarRequisicao
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
            this.gbxAddFerramenta = new System.Windows.Forms.GroupBox();
            this.listVFerramenta = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cod_ferramenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ferramenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_func_requisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtsaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_func_saida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_func_baixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtbaixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNFerramenta = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxFerramenta = new System.Windows.Forms.PictureBox();
            this.gbxFiltrar = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.gbxLmtPerAdmissao = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbldtpickerFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpickerFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpickerInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRedPeriodo = new System.Windows.Forms.Button();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodMat = new System.Windows.Forms.Label();
            this.gbxAddFerramenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).BeginInit();
            this.gbxFiltrar.SuspendLayout();
            this.gbxLmtPerAdmissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddFerramenta
            // 
            this.gbxAddFerramenta.Controls.Add(this.listVFerramenta);
            this.gbxAddFerramenta.Controls.Add(this.btnNFerramenta);
            this.gbxAddFerramenta.Controls.Add(this.btnDetalhes);
            this.gbxAddFerramenta.Controls.Add(this.btnDesativar);
            this.gbxAddFerramenta.Controls.Add(this.btnCancelar);
            this.gbxAddFerramenta.Controls.Add(this.pbxFerramenta);
            this.gbxAddFerramenta.Controls.Add(this.gbxFiltrar);
            this.gbxAddFerramenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddFerramenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxAddFerramenta.Location = new System.Drawing.Point(12, 7);
            this.gbxAddFerramenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddFerramenta.Name = "gbxAddFerramenta";
            this.gbxAddFerramenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddFerramenta.Size = new System.Drawing.Size(922, 625);
            this.gbxAddFerramenta.TabIndex = 1;
            this.gbxAddFerramenta.TabStop = false;
            this.gbxAddFerramenta.Text = "Pesquisar Requisição";
            // 
            // listVFerramenta
            // 
            this.listVFerramenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.cod_ferramenta,
            this.ferramenta,
            this.fk_func_requisitante,
            this.dtsaida,
            this.fk_func_saida,
            this.dtbaixa,
            this.fk_func_baixa});
            this.listVFerramenta.FullRowSelect = true;
            this.listVFerramenta.GridLines = true;
            this.listVFerramenta.Location = new System.Drawing.Point(6, 288);
            this.listVFerramenta.Name = "listVFerramenta";
            this.listVFerramenta.Size = new System.Drawing.Size(579, 274);
            this.listVFerramenta.TabIndex = 35;
            this.listVFerramenta.UseCompatibleStateImageBehavior = false;
            this.listVFerramenta.View = System.Windows.Forms.View.Details;
            this.listVFerramenta.SelectedIndexChanged += new System.EventHandler(this.listVFerramenta_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 88;
            // 
            // cod_ferramenta
            // 
            this.cod_ferramenta.Text = "Código Ferramenta";
            this.cod_ferramenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_ferramenta.Width = 130;
            // 
            // ferramenta
            // 
            this.ferramenta.Text = "Ferramenta";
            this.ferramenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ferramenta.Width = 91;
            // 
            // fk_func_requisitante
            // 
            this.fk_func_requisitante.Text = "Func.Requisitante";
            this.fk_func_requisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fk_func_requisitante.Width = 133;
            // 
            // dtsaida
            // 
            this.dtsaida.Text = "Dt-Saída";
            this.dtsaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtsaida.Width = 109;
            // 
            // fk_func_saida
            // 
            this.fk_func_saida.Text = "Func.Saída";
            this.fk_func_saida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fk_func_saida.Width = 108;
            // 
            // fk_func_baixa
            // 
            this.fk_func_baixa.Text = "Func.Baixa";
            this.fk_func_baixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fk_func_baixa.Width = 121;
            // 
            // dtbaixa
            // 
            this.dtbaixa.Text = "Dt-Baixa";
            this.dtbaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtbaixa.Width = 109;
            // 
            // btnNFerramenta
            // 
            this.btnNFerramenta.Image = global::SGA.Properties.Resources._1375245893_document_add;
            this.btnNFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNFerramenta.Location = new System.Drawing.Point(269, 574);
            this.btnNFerramenta.Name = "btnNFerramenta";
            this.btnNFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnNFerramenta.TabIndex = 34;
            this.btnNFerramenta.Text = "Nova Requisição";
            this.btnNFerramenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNFerramenta.UseVisualStyleBackColor = true;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Image = global::SGA.Properties.Resources._1370639093_webmaster_tools;
            this.btnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhes.Location = new System.Drawing.Point(31, 574);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(148, 44);
            this.btnDetalhes.TabIndex = 9;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Image = global::SGA.Properties.Resources._1375244523_document_open;
            this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesativar.Location = new System.Drawing.Point(512, 574);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(148, 44);
            this.btnDesativar.TabIndex = 33;
            this.btnDesativar.Text = "Finalizar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(750, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pbxFerramenta
            // 
            this.pbxFerramenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxFerramenta.Location = new System.Drawing.Point(591, 288);
            this.pbxFerramenta.Name = "pbxFerramenta";
            this.pbxFerramenta.Size = new System.Drawing.Size(322, 274);
            this.pbxFerramenta.TabIndex = 8;
            this.pbxFerramenta.TabStop = false;
            // 
            // gbxFiltrar
            // 
            this.gbxFiltrar.Controls.Add(this.textBox3);
            this.gbxFiltrar.Controls.Add(this.textBox2);
            this.gbxFiltrar.Controls.Add(this.label2);
            this.gbxFiltrar.Controls.Add(this.textBox1);
            this.gbxFiltrar.Controls.Add(this.label1);
            this.gbxFiltrar.Controls.Add(this.cbxSituacao);
            this.gbxFiltrar.Controls.Add(this.lblSituacao);
            this.gbxFiltrar.Controls.Add(this.button1);
            this.gbxFiltrar.Controls.Add(this.btnLimpar);
            this.gbxFiltrar.Controls.Add(this.tbxNome);
            this.gbxFiltrar.Controls.Add(this.tbxCodigo);
            this.gbxFiltrar.Controls.Add(this.gbxLmtPerAdmissao);
            this.gbxFiltrar.Controls.Add(this.lblGrupo);
            this.gbxFiltrar.Controls.Add(this.lblCodigo);
            this.gbxFiltrar.Controls.Add(this.lblCodMat);
            this.gbxFiltrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxFiltrar.Location = new System.Drawing.Point(6, 23);
            this.gbxFiltrar.Name = "gbxFiltrar";
            this.gbxFiltrar.Size = new System.Drawing.Size(910, 259);
            this.gbxFiltrar.TabIndex = 7;
            this.gbxFiltrar.TabStop = false;
            this.gbxFiltrar.Text = "Filtrar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 23);
            this.textBox3.TabIndex = 40;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(565, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 39;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Matrícula funcionário requisitante:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 37;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mátrícula funcionário baixa:";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(133, 107);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacao.TabIndex = 35;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(64, 111);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(62, 16);
            this.lblSituacao.TabIndex = 34;
            this.lblSituacao.Text = "Situação:";
            // 
            // button1
            // 
            this.button1.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(744, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(685, 41);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(0, 0);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(565, 27);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(167, 23);
            this.tbxNome.TabIndex = 4;
            this.tbxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNome_KeyPress);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(133, 27);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 23);
            this.tbxCodigo.TabIndex = 1;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            this.tbxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodigo_KeyPress);
            // 
            // gbxLmtPerAdmissao
            // 
            this.gbxLmtPerAdmissao.Controls.Add(this.comboBox1);
            this.gbxLmtPerAdmissao.Controls.Add(this.lbldtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.label3);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.lblDtInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.btnRedPeriodo);
            this.gbxLmtPerAdmissao.Location = new System.Drawing.Point(6, 139);
            this.gbxLmtPerAdmissao.Name = "gbxLmtPerAdmissao";
            this.gbxLmtPerAdmissao.Size = new System.Drawing.Size(898, 99);
            this.gbxLmtPerAdmissao.TabIndex = 27;
            this.gbxLmtPerAdmissao.TabStop = false;
            this.gbxLmtPerAdmissao.Text = "Limitar período de criação";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 41;
            // 
            // lbldtpickerFinal
            // 
            this.lbldtpickerFinal.AutoSize = true;
            this.lbldtpickerFinal.Location = new System.Drawing.Point(421, 64);
            this.lbldtpickerFinal.Name = "lbldtpickerFinal";
            this.lbldtpickerFinal.Size = new System.Drawing.Size(132, 16);
            this.lbldtpickerFinal.TabIndex = 32;
            this.lbldtpickerFinal.Text = "Data final do período:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo período:";
            // 
            // dtpickerFinal
            // 
            this.dtpickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinal.Location = new System.Drawing.Point(559, 61);
            this.dtpickerFinal.Name = "dtpickerFinal";
            this.dtpickerFinal.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinal.TabIndex = 31;
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(398, 30);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(155, 16);
            this.lblDtInicio.TabIndex = 30;
            this.lblDtInicio.Text = "Data de início do período:";
            // 
            // dtpickerInicio
            // 
            this.dtpickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicio.Location = new System.Drawing.Point(559, 25);
            this.dtpickerInicio.Name = "dtpickerInicio";
            this.dtpickerInicio.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicio.TabIndex = 29;
            // 
            // btnRedPeriodo
            // 
            this.btnRedPeriodo.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.btnRedPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedPeriodo.Location = new System.Drawing.Point(738, 33);
            this.btnRedPeriodo.Name = "btnRedPeriodo";
            this.btnRedPeriodo.Size = new System.Drawing.Size(148, 44);
            this.btnRedPeriodo.TabIndex = 28;
            this.btnRedPeriodo.Text = "Redefinir Período";
            this.btnRedPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedPeriodo.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(7, 69);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(120, 16);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Código ferramenta:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(114, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código requisição:";
            // 
            // lblCodMat
            // 
            this.lblCodMat.AutoSize = true;
            this.lblCodMat.Location = new System.Drawing.Point(391, 33);
            this.lblCodMat.Name = "lblCodMat";
            this.lblCodMat.Size = new System.Drawing.Size(166, 16);
            this.lblCodMat.TabIndex = 3;
            this.lblCodMat.Text = "Matrícula funcionário saída:";
            // 
            // PesquisarRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxAddFerramenta);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PesquisarRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarRequisicao";
            this.Load += new System.EventHandler(this.PesquisarRequisicao_Load);
            this.gbxAddFerramenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).EndInit();
            this.gbxFiltrar.ResumeLayout(false);
            this.gbxFiltrar.PerformLayout();
            this.gbxLmtPerAdmissao.ResumeLayout(false);
            this.gbxLmtPerAdmissao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddFerramenta;
        private System.Windows.Forms.ListView listVFerramenta;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader cod_ferramenta;
        private System.Windows.Forms.ColumnHeader ferramenta;
        private System.Windows.Forms.ColumnHeader fk_func_saida;
        private System.Windows.Forms.Button btnNFerramenta;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxFerramenta;
        private System.Windows.Forms.GroupBox gbxFiltrar;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.GroupBox gbxLmtPerAdmissao;
        private System.Windows.Forms.Label lbldtpickerFinal;
        private System.Windows.Forms.DateTimePicker dtpickerFinal;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpickerInicio;
        private System.Windows.Forms.Button btnRedPeriodo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodMat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ColumnHeader fk_func_baixa;
        private System.Windows.Forms.ColumnHeader fk_func_requisitante;
        private System.Windows.Forms.ColumnHeader dtsaida;
        private System.Windows.Forms.ColumnHeader dtbaixa;

    }
}