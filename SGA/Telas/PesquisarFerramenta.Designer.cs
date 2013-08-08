namespace SGA.Telas
{
    partial class PesquisarFerramenta
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
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNFerramenta = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxFerramenta = new System.Windows.Forms.PictureBox();
            this.gbxFiltrar = new System.Windows.Forms.GroupBox();
            this.checkBoxEcluiveis = new System.Windows.Forms.CheckBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.gbxLmtPerAdmissao = new System.Windows.Forms.GroupBox();
            this.lbldtpickerFinal = new System.Windows.Forms.Label();
            this.dtpickerFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpickerInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRedPeriodo = new System.Windows.Forms.Button();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
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
            this.gbxAddFerramenta.Controls.Add(this.btnEditar);
            this.gbxAddFerramenta.Controls.Add(this.btnDesativar);
            this.gbxAddFerramenta.Controls.Add(this.btnCancelar);
            this.gbxAddFerramenta.Controls.Add(this.pbxFerramenta);
            this.gbxAddFerramenta.Controls.Add(this.gbxFiltrar);
            this.gbxAddFerramenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddFerramenta.Location = new System.Drawing.Point(12, 13);
            this.gbxAddFerramenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddFerramenta.Name = "gbxAddFerramenta";
            this.gbxAddFerramenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddFerramenta.Size = new System.Drawing.Size(922, 607);
            this.gbxAddFerramenta.TabIndex = 0;
            this.gbxAddFerramenta.TabStop = false;
            this.gbxAddFerramenta.Text = "Pesquisar Ferramenta";
            // 
            // listVFerramenta
            // 
            this.listVFerramenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nome,
            this.fabricante,
            this.categoria});
            this.listVFerramenta.FullRowSelect = true;
            this.listVFerramenta.GridLines = true;
            this.listVFerramenta.Location = new System.Drawing.Point(12, 259);
            this.listVFerramenta.Name = "listVFerramenta";
            this.listVFerramenta.Size = new System.Drawing.Size(570, 274);
            this.listVFerramenta.TabIndex = 35;
            this.listVFerramenta.UseCompatibleStateImageBehavior = false;
            this.listVFerramenta.View = System.Windows.Forms.View.Details;
            this.listVFerramenta.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listVFerramenta_ItemChecked);
            this.listVFerramenta.SelectedIndexChanged += new System.EventHandler(this.listVFerramenta_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 88;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nome.Width = 159;
            // 
            // fabricante
            // 
            this.fabricante.Text = "Fabricante";
            this.fabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fabricante.Width = 155;
            // 
            // categoria
            // 
            this.categoria.Text = "Categoria";
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoria.Width = 164;
            // 
            // btnNFerramenta
            // 
            this.btnNFerramenta.Image = global::SGA.Properties.Resources.tooladd;
            this.btnNFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNFerramenta.Location = new System.Drawing.Point(365, 551);
            this.btnNFerramenta.Name = "btnNFerramenta";
            this.btnNFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnNFerramenta.TabIndex = 34;
            this.btnNFerramenta.Text = "Nova Ferramenta";
            this.btnNFerramenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNFerramenta.UseVisualStyleBackColor = true;
            this.btnNFerramenta.Click += new System.EventHandler(this.btnNFerramenta_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Image = global::SGA.Properties.Resources._1370639093_webmaster_tools;
            this.btnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhes.Location = new System.Drawing.Point(27, 551);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(148, 44);
            this.btnDetalhes.TabIndex = 9;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SGA.Properties.Resources._1370640620_edit_file;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(196, 551);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 44);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Image = global::SGA.Properties.Resources._1370635927_Trash_Delete;
            this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesativar.Location = new System.Drawing.Point(534, 551);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(148, 44);
            this.btnDesativar.TabIndex = 33;
            this.btnDesativar.Text = "Excluir";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(746, 551);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxFerramenta
            // 
            this.pbxFerramenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxFerramenta.Location = new System.Drawing.Point(591, 259);
            this.pbxFerramenta.Name = "pbxFerramenta";
            this.pbxFerramenta.Size = new System.Drawing.Size(325, 274);
            this.pbxFerramenta.TabIndex = 8;
            this.pbxFerramenta.TabStop = false;
            // 
            // gbxFiltrar
            // 
            this.gbxFiltrar.Controls.Add(this.checkBoxEcluiveis);
            this.gbxFiltrar.Controls.Add(this.cbxFabricante);
            this.gbxFiltrar.Controls.Add(this.lblFabricante);
            this.gbxFiltrar.Controls.Add(this.cbxSituacao);
            this.gbxFiltrar.Controls.Add(this.lblSituacao);
            this.gbxFiltrar.Controls.Add(this.button1);
            this.gbxFiltrar.Controls.Add(this.btnLimpar);
            this.gbxFiltrar.Controls.Add(this.tbxNome);
            this.gbxFiltrar.Controls.Add(this.cbxGrupo);
            this.gbxFiltrar.Controls.Add(this.tbxCodigo);
            this.gbxFiltrar.Controls.Add(this.gbxLmtPerAdmissao);
            this.gbxFiltrar.Controls.Add(this.lblGrupo);
            this.gbxFiltrar.Controls.Add(this.lblCodigo);
            this.gbxFiltrar.Controls.Add(this.lblNome);
            this.gbxFiltrar.Location = new System.Drawing.Point(6, 23);
            this.gbxFiltrar.Name = "gbxFiltrar";
            this.gbxFiltrar.Size = new System.Drawing.Size(910, 214);
            this.gbxFiltrar.TabIndex = 7;
            this.gbxFiltrar.TabStop = false;
            this.gbxFiltrar.Text = "Filtrar";
            // 
            // checkBoxEcluiveis
            // 
            this.checkBoxEcluiveis.AutoSize = true;
            this.checkBoxEcluiveis.Location = new System.Drawing.Point(578, 73);
            this.checkBoxEcluiveis.Name = "checkBoxEcluiveis";
            this.checkBoxEcluiveis.Size = new System.Drawing.Size(81, 20);
            this.checkBoxEcluiveis.TabIndex = 38;
            this.checkBoxEcluiveis.Text = "Excluíveis";
            this.checkBoxEcluiveis.UseVisualStyleBackColor = true;
            this.checkBoxEcluiveis.CheckStateChanged += new System.EventHandler(this.checkBoxEcluiveis_CheckStateChanged);
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(578, 30);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(167, 24);
            this.cbxFabricante.TabIndex = 37;
            this.cbxFabricante.SelectedIndexChanged += new System.EventHandler(this.cbxFabricante_SelectedIndexChanged);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(503, 33);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(73, 16);
            this.lblFabricante.TabIndex = 36;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(317, 69);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(167, 24);
            this.cbxSituacao.TabIndex = 35;
            this.cbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cbxSituacao_SelectedIndexChanged);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(254, 72);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(62, 16);
            this.lblSituacao.TabIndex = 34;
            this.lblSituacao.Text = "Situação:";
            // 
            // button1
            // 
            this.button1.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(756, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tbxNome.Location = new System.Drawing.Point(66, 66);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(167, 23);
            this.tbxNome.TabIndex = 4;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(317, 27);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(167, 24);
            this.cbxGrupo.TabIndex = 6;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(66, 27);
            this.tbxCodigo.MaxLength = 5;
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 23);
            this.tbxCodigo.TabIndex = 1;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            // 
            // gbxLmtPerAdmissao
            // 
            this.gbxLmtPerAdmissao.Controls.Add(this.lbldtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.lblDtInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.btnRedPeriodo);
            this.gbxLmtPerAdmissao.Location = new System.Drawing.Point(6, 99);
            this.gbxLmtPerAdmissao.Name = "gbxLmtPerAdmissao";
            this.gbxLmtPerAdmissao.Size = new System.Drawing.Size(898, 87);
            this.gbxLmtPerAdmissao.TabIndex = 27;
            this.gbxLmtPerAdmissao.TabStop = false;
            this.gbxLmtPerAdmissao.Text = "Limitar período de aquisição";
            // 
            // lbldtpickerFinal
            // 
            this.lbldtpickerFinal.AutoSize = true;
            this.lbldtpickerFinal.Location = new System.Drawing.Point(393, 40);
            this.lbldtpickerFinal.Name = "lbldtpickerFinal";
            this.lbldtpickerFinal.Size = new System.Drawing.Size(132, 16);
            this.lbldtpickerFinal.TabIndex = 32;
            this.lbldtpickerFinal.Text = "Data final do período:";
            // 
            // dtpickerFinal
            // 
            this.dtpickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinal.Location = new System.Drawing.Point(542, 37);
            this.dtpickerFinal.Name = "dtpickerFinal";
            this.dtpickerFinal.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinal.TabIndex = 31;
            this.dtpickerFinal.ValueChanged += new System.EventHandler(this.dtpickerFinal_ValueChanged);
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(35, 40);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(155, 16);
            this.lblDtInicio.TabIndex = 30;
            this.lblDtInicio.Text = "Data de início do período:";
            // 
            // dtpickerInicio
            // 
            this.dtpickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicio.Location = new System.Drawing.Point(196, 37);
            this.dtpickerInicio.Name = "dtpickerInicio";
            this.dtpickerInicio.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicio.TabIndex = 29;
            this.dtpickerInicio.ValueChanged += new System.EventHandler(this.dtpickerInicio_ValueChanged);
            // 
            // btnRedPeriodo
            // 
            this.btnRedPeriodo.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.btnRedPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedPeriodo.Location = new System.Drawing.Point(734, 28);
            this.btnRedPeriodo.Name = "btnRedPeriodo";
            this.btnRedPeriodo.Size = new System.Drawing.Size(148, 44);
            this.btnRedPeriodo.TabIndex = 28;
            this.btnRedPeriodo.Text = "Redefinir Período";
            this.btnRedPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedPeriodo.UseVisualStyleBackColor = true;
            this.btnRedPeriodo.Click += new System.EventHandler(this.btnRedPeriodo_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(254, 30);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(47, 16);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // PesquisarFerramenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxAddFerramenta);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PesquisarFerramenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarFerramenta";
            this.Load += new System.EventHandler(this.PesquisarFerramenta_Load);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.PictureBox pbxFerramenta;
        private System.Windows.Forms.GroupBox gbxFiltrar;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbxLmtPerAdmissao;
        private System.Windows.Forms.Label lbldtpickerFinal;
        private System.Windows.Forms.DateTimePicker dtpickerFinal;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpickerInicio;
        private System.Windows.Forms.Button btnRedPeriodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnNFerramenta;
        private System.Windows.Forms.ListView listVFerramenta;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader fabricante;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.CheckBox checkBoxEcluiveis;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label lblSituacao;
    }
}