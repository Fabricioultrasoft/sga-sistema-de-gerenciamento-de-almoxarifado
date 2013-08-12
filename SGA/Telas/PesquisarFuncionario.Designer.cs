namespace SGA.Telas
{
    partial class PesquisarFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.gbxLmtPerAdmissao = new System.Windows.Forms.GroupBox();
            this.lblpickerFinal = new System.Windows.Forms.Label();
            this.dtpickerFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpickerInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRedPeriodo = new System.Windows.Forms.Button();
            this.listVFuncionario = new System.Windows.Forms.ListView();
            this.Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Função = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Permissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxPesqFunc = new System.Windows.Forms.GroupBox();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.cbxPermissao = new System.Windows.Forms.ComboBox();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.btnNFuncionario = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxLmtPerAdmissao.SuspendLayout();
            this.gbxPesqFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(45, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(45, 53);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 16);
            this.lblMatricula.TabIndex = 16;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(366, 46);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(54, 16);
            this.lblFuncao.TabIndex = 19;
            this.lblFuncao.Text = "Função:";
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(447, 45);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(167, 24);
            this.cbxFuncao.TabIndex = 20;
            this.cbxFuncao.SelectedIndexChanged += new System.EventHandler(this.cbxFuncao_SelectedIndexChanged);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(116, 90);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(167, 23);
            this.tbxNome.TabIndex = 18;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // gbxLmtPerAdmissao
            // 
            this.gbxLmtPerAdmissao.Controls.Add(this.lblpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerFinal);
            this.gbxLmtPerAdmissao.Controls.Add(this.lblDtInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.dtpickerInicio);
            this.gbxLmtPerAdmissao.Controls.Add(this.btnRedPeriodo);
            this.gbxLmtPerAdmissao.Location = new System.Drawing.Point(48, 128);
            this.gbxLmtPerAdmissao.Name = "gbxLmtPerAdmissao";
            this.gbxLmtPerAdmissao.Size = new System.Drawing.Size(817, 84);
            this.gbxLmtPerAdmissao.TabIndex = 26;
            this.gbxLmtPerAdmissao.TabStop = false;
            this.gbxLmtPerAdmissao.Text = "Limitar Período de admissão";
            // 
            // lblpickerFinal
            // 
            this.lblpickerFinal.AutoSize = true;
            this.lblpickerFinal.Location = new System.Drawing.Point(351, 35);
            this.lblpickerFinal.Name = "lblpickerFinal";
            this.lblpickerFinal.Size = new System.Drawing.Size(140, 16);
            this.lblpickerFinal.TabIndex = 32;
            this.lblpickerFinal.Text = "Data final do período  :";
            // 
            // dtpickerFinal
            // 
            this.dtpickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerFinal.Location = new System.Drawing.Point(497, 31);
            this.dtpickerFinal.Name = "dtpickerFinal";
            this.dtpickerFinal.Size = new System.Drawing.Size(99, 23);
            this.dtpickerFinal.TabIndex = 31;
            this.dtpickerFinal.ValueChanged += new System.EventHandler(this.dtpickerFinal_ValueChanged);
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(19, 34);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(155, 16);
            this.lblDtInicio.TabIndex = 30;
            this.lblDtInicio.Text = "Data de início do período:";
            // 
            // dtpickerInicio
            // 
            this.dtpickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerInicio.Location = new System.Drawing.Point(180, 31);
            this.dtpickerInicio.Name = "dtpickerInicio";
            this.dtpickerInicio.Size = new System.Drawing.Size(99, 23);
            this.dtpickerInicio.TabIndex = 29;
            this.dtpickerInicio.ValueChanged += new System.EventHandler(this.dtpickerInicio_ValueChanged);
            // 
            // btnRedPeriodo
            // 
            this.btnRedPeriodo.Image = global::SGA.Properties.Resources._1370631673_gnome_mime_text_x_vcalendar;
            this.btnRedPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedPeriodo.Location = new System.Drawing.Point(646, 22);
            this.btnRedPeriodo.Name = "btnRedPeriodo";
            this.btnRedPeriodo.Size = new System.Drawing.Size(148, 44);
            this.btnRedPeriodo.TabIndex = 28;
            this.btnRedPeriodo.Text = "Redefinir Período";
            this.btnRedPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedPeriodo.UseVisualStyleBackColor = true;
            this.btnRedPeriodo.Click += new System.EventHandler(this.btnRedPeriodo_Click);
            // 
            // listVFuncionario
            // 
            this.listVFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricula,
            this.Nome,
            this.Função,
            this.Permissao});
            this.listVFuncionario.FullRowSelect = true;
            this.listVFuncionario.GridLines = true;
            this.listVFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listVFuncionario.Location = new System.Drawing.Point(172, 228);
            this.listVFuncionario.Name = "listVFuncionario";
            this.listVFuncionario.Size = new System.Drawing.Size(565, 283);
            this.listVFuncionario.TabIndex = 27;
            this.listVFuncionario.UseCompatibleStateImageBehavior = false;
            this.listVFuncionario.View = System.Windows.Forms.View.Details;
            this.listVFuncionario.SelectedIndexChanged += new System.EventHandler(this.listVFuncionario_SelectedIndexChanged);
            // 
            // Matricula
            // 
            this.Matricula.Text = "Matrícula";
            this.Matricula.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 202;
            // 
            // Função
            // 
            this.Função.Text = "Função";
            this.Função.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Função.Width = 133;
            // 
            // Permissao
            // 
            this.Permissao.Text = "Permissão";
            this.Permissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Permissao.Width = 145;
            // 
            // gbxPesqFunc
            // 
            this.gbxPesqFunc.Controls.Add(this.btnDesativar);
            this.gbxPesqFunc.Controls.Add(this.cbxPermissao);
            this.gbxPesqFunc.Controls.Add(this.btnDetalhes);
            this.gbxPesqFunc.Controls.Add(this.lblPermissao);
            this.gbxPesqFunc.Controls.Add(this.btnEditar);
            this.gbxPesqFunc.Controls.Add(this.tbxMatricula);
            this.gbxPesqFunc.Controls.Add(this.btnNFuncionario);
            this.gbxPesqFunc.Controls.Add(this.btnFechar);
            this.gbxPesqFunc.Controls.Add(this.listVFuncionario);
            this.gbxPesqFunc.Controls.Add(this.gbxLmtPerAdmissao);
            this.gbxPesqFunc.Controls.Add(this.btnLimpar);
            this.gbxPesqFunc.Controls.Add(this.tbxNome);
            this.gbxPesqFunc.Controls.Add(this.cbxFuncao);
            this.gbxPesqFunc.Controls.Add(this.lblFuncao);
            this.gbxPesqFunc.Controls.Add(this.lblMatricula);
            this.gbxPesqFunc.Controls.Add(this.lblNome);
            this.gbxPesqFunc.Location = new System.Drawing.Point(22, 12);
            this.gbxPesqFunc.Name = "gbxPesqFunc";
            this.gbxPesqFunc.Size = new System.Drawing.Size(903, 621);
            this.gbxPesqFunc.TabIndex = 0;
            this.gbxPesqFunc.TabStop = false;
            this.gbxPesqFunc.Text = "Pesquisar Funcionário";
            // 
            // btnDesativar
            // 
            this.btnDesativar.Image = global::SGA.Properties.Resources._1370637874_user_male_delete;
            this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesativar.Location = new System.Drawing.Point(524, 548);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(148, 44);
            this.btnDesativar.TabIndex = 32;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // cbxPermissao
            // 
            this.cbxPermissao.FormattingEnabled = true;
            this.cbxPermissao.Location = new System.Drawing.Point(447, 86);
            this.cbxPermissao.Name = "cbxPermissao";
            this.cbxPermissao.Size = new System.Drawing.Size(167, 24);
            this.cbxPermissao.TabIndex = 36;
            this.cbxPermissao.SelectedIndexChanged += new System.EventHandler(this.cbxPermissao_SelectedIndexChanged);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Image = global::SGA.Properties.Resources._1370637053_cv;
            this.btnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhes.Location = new System.Drawing.Point(62, 548);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(148, 44);
            this.btnDetalhes.TabIndex = 28;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(366, 89);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(72, 16);
            this.lblPermissao.TabIndex = 35;
            this.lblPermissao.Text = "Permissão:";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SGA.Properties.Resources._1370637407_user_male_edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(370, 548);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 44);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(116, 50);
            this.tbxMatricula.MaxLength = 6;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(167, 23);
            this.tbxMatricula.TabIndex = 34;
            this.tbxMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatricula_KeyPress);
            // 
            // btnNFuncionario
            // 
            this.btnNFuncionario.Image = global::SGA.Properties.Resources._1370637313_user_male_add;
            this.btnNFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNFuncionario.Location = new System.Drawing.Point(216, 548);
            this.btnNFuncionario.Name = "btnNFuncionario";
            this.btnNFuncionario.Size = new System.Drawing.Size(148, 44);
            this.btnNFuncionario.TabIndex = 31;
            this.btnNFuncionario.Text = "Novo Funcionário";
            this.btnNFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNFuncionario.UseVisualStyleBackColor = true;
            this.btnNFuncionario.Click += new System.EventHandler(this.btnNFuncionario_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(678, 548);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(148, 44);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SGA.Properties.Resources._1370631243_eraser;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(694, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 44);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // PesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxPesqFunc);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PesquisarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Funcionario";
            this.Load += new System.EventHandler(this.PesquisarFuncionario_Load);
            this.gbxLmtPerAdmissao.ResumeLayout(false);
            this.gbxLmtPerAdmissao.PerformLayout();
            this.gbxPesqFunc.ResumeLayout(false);
            this.gbxPesqFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbxLmtPerAdmissao;
        private System.Windows.Forms.Button btnRedPeriodo;
        private System.Windows.Forms.ListView listVFuncionario;
        private System.Windows.Forms.GroupBox gbxPesqFunc;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Label lblpickerFinal;
        private System.Windows.Forms.DateTimePicker dtpickerFinal;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpickerInicio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNFuncionario;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.ColumnHeader Matricula;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Função;
        private System.Windows.Forms.ColumnHeader Permissao;
        private System.Windows.Forms.ComboBox cbxPermissao;
        private System.Windows.Forms.Label lblPermissao;

    }
}