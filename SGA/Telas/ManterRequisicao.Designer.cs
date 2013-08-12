namespace SGA.Telas
{
    partial class ManterRequisicao
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
            this.gbxNRequisicao = new System.Windows.Forms.GroupBox();
            this.gbxFuncBaixa = new System.Windows.Forms.GroupBox();
            this.listViewFuncBaixa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxFuncSaida = new System.Windows.Forms.GroupBox();
            this.listViewFuncSaida = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxFerramenta = new System.Windows.Forms.GroupBox();
            this.listVFerramenta = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverFerr = new System.Windows.Forms.Button();
            this.btnAddFerramenta = new System.Windows.Forms.Button();
            this.pbxFerramenta = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxFuncionario = new System.Windows.Forms.GroupBox();
            this.listVFuncReq = new System.Windows.Forms.ListView();
            this.columnMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFuncao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbxNRequisicao.SuspendLayout();
            this.gbxFuncBaixa.SuspendLayout();
            this.gbxFuncSaida.SuspendLayout();
            this.gbxFerramenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).BeginInit();
            this.gbxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNRequisicao
            // 
            this.gbxNRequisicao.Controls.Add(this.gbxFuncBaixa);
            this.gbxNRequisicao.Controls.Add(this.gbxFuncSaida);
            this.gbxNRequisicao.Controls.Add(this.gbxFerramenta);
            this.gbxNRequisicao.Controls.Add(this.btnCancelar);
            this.gbxNRequisicao.Controls.Add(this.btnSalvar);
            this.gbxNRequisicao.Controls.Add(this.gbxFuncionario);
            this.gbxNRequisicao.Location = new System.Drawing.Point(12, 12);
            this.gbxNRequisicao.Name = "gbxNRequisicao";
            this.gbxNRequisicao.Size = new System.Drawing.Size(922, 621);
            this.gbxNRequisicao.TabIndex = 0;
            this.gbxNRequisicao.TabStop = false;
            this.gbxNRequisicao.Text = "Nova Requisição";
            // 
            // gbxFuncBaixa
            // 
            this.gbxFuncBaixa.Controls.Add(this.listViewFuncBaixa);
            this.gbxFuncBaixa.Location = new System.Drawing.Point(541, 118);
            this.gbxFuncBaixa.Name = "gbxFuncBaixa";
            this.gbxFuncBaixa.Size = new System.Drawing.Size(369, 96);
            this.gbxFuncBaixa.TabIndex = 39;
            this.gbxFuncBaixa.TabStop = false;
            this.gbxFuncBaixa.Text = "Funcionário Baixa";
            // 
            // listViewFuncBaixa
            // 
            this.listViewFuncBaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listViewFuncBaixa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFuncBaixa.FullRowSelect = true;
            this.listViewFuncBaixa.GridLines = true;
            this.listViewFuncBaixa.LabelWrap = false;
            this.listViewFuncBaixa.Location = new System.Drawing.Point(6, 22);
            this.listViewFuncBaixa.Name = "listViewFuncBaixa";
            this.listViewFuncBaixa.Size = new System.Drawing.Size(357, 68);
            this.listViewFuncBaixa.TabIndex = 37;
            this.listViewFuncBaixa.UseCompatibleStateImageBehavior = false;
            this.listViewFuncBaixa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matrícula";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Função";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 105;
            // 
            // gbxFuncSaida
            // 
            this.gbxFuncSaida.Controls.Add(this.listViewFuncSaida);
            this.gbxFuncSaida.Location = new System.Drawing.Point(541, 13);
            this.gbxFuncSaida.Name = "gbxFuncSaida";
            this.gbxFuncSaida.Size = new System.Drawing.Size(369, 102);
            this.gbxFuncSaida.TabIndex = 38;
            this.gbxFuncSaida.TabStop = false;
            this.gbxFuncSaida.Text = "Funcionário Saída";
            // 
            // listViewFuncSaida
            // 
            this.listViewFuncSaida.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listViewFuncSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewFuncSaida.FullRowSelect = true;
            this.listViewFuncSaida.GridLines = true;
            this.listViewFuncSaida.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFuncSaida.LabelWrap = false;
            this.listViewFuncSaida.Location = new System.Drawing.Point(6, 22);
            this.listViewFuncSaida.Name = "listViewFuncSaida";
            this.listViewFuncSaida.Size = new System.Drawing.Size(357, 68);
            this.listViewFuncSaida.TabIndex = 37;
            this.listViewFuncSaida.UseCompatibleStateImageBehavior = false;
            this.listViewFuncSaida.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Matrícula";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Função";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 105;
            // 
            // gbxFerramenta
            // 
            this.gbxFerramenta.Controls.Add(this.listVFerramenta);
            this.gbxFerramenta.Controls.Add(this.btnRemoverFerr);
            this.gbxFerramenta.Controls.Add(this.btnAddFerramenta);
            this.gbxFerramenta.Controls.Add(this.pbxFerramenta);
            this.gbxFerramenta.Location = new System.Drawing.Point(6, 214);
            this.gbxFerramenta.Name = "gbxFerramenta";
            this.gbxFerramenta.Size = new System.Drawing.Size(910, 350);
            this.gbxFerramenta.TabIndex = 15;
            this.gbxFerramenta.TabStop = false;
            this.gbxFerramenta.Text = "Ferramentas";
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
            this.listVFerramenta.Location = new System.Drawing.Point(6, 16);
            this.listVFerramenta.Name = "listVFerramenta";
            this.listVFerramenta.Size = new System.Drawing.Size(570, 274);
            this.listVFerramenta.TabIndex = 36;
            this.listVFerramenta.UseCompatibleStateImageBehavior = false;
            this.listVFerramenta.View = System.Windows.Forms.View.Details;
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
            // btnRemoverFerr
            // 
            this.btnRemoverFerr.Image = global::SGA.Properties.Resources._1370629558_minus;
            this.btnRemoverFerr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverFerr.Location = new System.Drawing.Point(327, 298);
            this.btnRemoverFerr.Name = "btnRemoverFerr";
            this.btnRemoverFerr.Size = new System.Drawing.Size(148, 44);
            this.btnRemoverFerr.TabIndex = 14;
            this.btnRemoverFerr.Text = "Retirar";
            this.btnRemoverFerr.UseVisualStyleBackColor = true;
            this.btnRemoverFerr.Click += new System.EventHandler(this.btnRemoverFerr_Click);
            // 
            // btnAddFerramenta
            // 
            this.btnAddFerramenta.Image = global::SGA.Properties.Resources._1370629399_plus;
            this.btnAddFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFerramenta.Location = new System.Drawing.Point(109, 298);
            this.btnAddFerramenta.Name = "btnAddFerramenta";
            this.btnAddFerramenta.Size = new System.Drawing.Size(148, 44);
            this.btnAddFerramenta.TabIndex = 13;
            this.btnAddFerramenta.Text = "Adicionar";
            this.btnAddFerramenta.UseVisualStyleBackColor = true;
            this.btnAddFerramenta.Click += new System.EventHandler(this.btnAddFerramenta_Click);
            // 
            // pbxFerramenta
            // 
            this.pbxFerramenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxFerramenta.Location = new System.Drawing.Point(579, 16);
            this.pbxFerramenta.Name = "pbxFerramenta";
            this.pbxFerramenta.Size = new System.Drawing.Size(325, 274);
            this.pbxFerramenta.TabIndex = 12;
            this.pbxFerramenta.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(511, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SGA.Properties.Resources._1370629123_button_30;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(299, 571);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 44);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbxFuncionario
            // 
            this.gbxFuncionario.Controls.Add(this.listVFuncReq);
            this.gbxFuncionario.Controls.Add(this.btnAlterar);
            this.gbxFuncionario.Location = new System.Drawing.Point(12, 58);
            this.gbxFuncionario.Name = "gbxFuncionario";
            this.gbxFuncionario.Size = new System.Drawing.Size(523, 104);
            this.gbxFuncionario.TabIndex = 1;
            this.gbxFuncionario.TabStop = false;
            this.gbxFuncionario.Text = "Funcionário Requisitante";
            // 
            // listVFuncReq
            // 
            this.listVFuncReq.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listVFuncReq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMatricula,
            this.columnNome,
            this.columnFuncao});
            this.listVFuncReq.FullRowSelect = true;
            this.listVFuncReq.GridLines = true;
            this.listVFuncReq.LabelWrap = false;
            this.listVFuncReq.Location = new System.Drawing.Point(6, 22);
            this.listVFuncReq.Name = "listVFuncReq";
            this.listVFuncReq.Size = new System.Drawing.Size(357, 68);
            this.listVFuncReq.TabIndex = 37;
            this.listVFuncReq.UseCompatibleStateImageBehavior = false;
            this.listVFuncReq.View = System.Windows.Forms.View.Details;
            // 
            // columnMatricula
            // 
            this.columnMatricula.Text = "Matrícula";
            this.columnMatricula.Width = 76;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNome.Width = 170;
            // 
            // columnFuncao
            // 
            this.columnFuncao.Text = "Função";
            this.columnFuncao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFuncao.Width = 91;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::SGA.Properties.Resources._1370643457_Search_Male_User;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(364, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(148, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // ManterRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxNRequisicao);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManterRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroRequisicao";
            this.Load += new System.EventHandler(this.ManterRequisicao_Load);
            this.gbxNRequisicao.ResumeLayout(false);
            this.gbxFuncBaixa.ResumeLayout(false);
            this.gbxFuncSaida.ResumeLayout(false);
            this.gbxFerramenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).EndInit();
            this.gbxFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNRequisicao;
        private System.Windows.Forms.GroupBox gbxFerramenta;
        private System.Windows.Forms.Button btnAddFerramenta;
        private System.Windows.Forms.PictureBox pbxFerramenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRemoverFerr;
        private System.Windows.Forms.ListView listVFerramenta;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader fabricante;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.GroupBox gbxFuncionario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gbxFuncBaixa;
        private System.Windows.Forms.ListView listViewFuncSaida;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbxFuncSaida;
        private System.Windows.Forms.ListView listViewFuncBaixa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listVFuncReq;
        private System.Windows.Forms.ColumnHeader columnMatricula;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnFuncao;
    }
}