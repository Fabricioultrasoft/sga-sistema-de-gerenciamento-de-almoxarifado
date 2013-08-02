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
            this.gbxFerramenta = new System.Windows.Forms.GroupBox();
            this.listVFerramenta = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddFerramenta = new System.Windows.Forms.Button();
            this.pbxFerramenta = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxFuncionario = new System.Windows.Forms.GroupBox();
            this.lblFuncaoFunc = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblMatFunc = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.gbxNRequisicao.SuspendLayout();
            this.gbxFerramenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).BeginInit();
            this.gbxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNRequisicao
            // 
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
            // gbxFerramenta
            // 
            this.gbxFerramenta.Controls.Add(this.listVFerramenta);
            this.gbxFerramenta.Controls.Add(this.button1);
            this.gbxFerramenta.Controls.Add(this.btnAddFerramenta);
            this.gbxFerramenta.Controls.Add(this.pbxFerramenta);
            this.gbxFerramenta.Location = new System.Drawing.Point(6, 166);
            this.gbxFerramenta.Name = "gbxFerramenta";
            this.gbxFerramenta.Size = new System.Drawing.Size(910, 391);
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
            this.listVFerramenta.Location = new System.Drawing.Point(6, 22);
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
            // button1
            // 
            this.button1.Image = global::SGA.Properties.Resources._1370629558_minus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(327, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddFerramenta
            // 
            this.btnAddFerramenta.Image = global::SGA.Properties.Resources._1370629399_plus;
            this.btnAddFerramenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFerramenta.Location = new System.Drawing.Point(110, 320);
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
            this.pbxFerramenta.Location = new System.Drawing.Point(579, 22);
            this.pbxFerramenta.Name = "pbxFerramenta";
            this.pbxFerramenta.Size = new System.Drawing.Size(325, 274);
            this.pbxFerramenta.TabIndex = 12;
            this.pbxFerramenta.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(511, 563);
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
            this.btnSalvar.Location = new System.Drawing.Point(299, 563);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 44);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbxFuncionario
            // 
            this.gbxFuncionario.Controls.Add(this.lblFuncaoFunc);
            this.gbxFuncionario.Controls.Add(this.lblNomeFunc);
            this.gbxFuncionario.Controls.Add(this.lblMatFunc);
            this.gbxFuncionario.Controls.Add(this.btnAlterar);
            this.gbxFuncionario.Controls.Add(this.lblFuncao);
            this.gbxFuncionario.Controls.Add(this.lblNome);
            this.gbxFuncionario.Controls.Add(this.lblMatricula);
            this.gbxFuncionario.Location = new System.Drawing.Point(6, 22);
            this.gbxFuncionario.Name = "gbxFuncionario";
            this.gbxFuncionario.Size = new System.Drawing.Size(546, 138);
            this.gbxFuncionario.TabIndex = 1;
            this.gbxFuncionario.TabStop = false;
            this.gbxFuncionario.Text = "Funcionário";
            // 
            // lblFuncaoFunc
            // 
            this.lblFuncaoFunc.AutoSize = true;
            this.lblFuncaoFunc.Location = new System.Drawing.Point(142, 98);
            this.lblFuncaoFunc.Name = "lblFuncaoFunc";
            this.lblFuncaoFunc.Size = new System.Drawing.Size(46, 16);
            this.lblFuncaoFunc.TabIndex = 7;
            this.lblFuncaoFunc.Text = "função";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(142, 65);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(40, 16);
            this.lblNomeFunc.TabIndex = 6;
            this.lblNomeFunc.Text = "nome";
            // 
            // lblMatFunc
            // 
            this.lblMatFunc.AutoSize = true;
            this.lblMatFunc.Location = new System.Drawing.Point(142, 29);
            this.lblMatFunc.Name = "lblMatFunc";
            this.lblMatFunc.Size = new System.Drawing.Size(61, 16);
            this.lblMatFunc.TabIndex = 4;
            this.lblMatFunc.Text = "matrícula";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::SGA.Properties.Resources._1370643457_Search_Male_User;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(371, 51);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(148, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(26, 98);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(54, 16);
            this.lblFuncao.TabIndex = 2;
            this.lblFuncao.Text = "Função:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(26, 29);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 16);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
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
            this.gbxFerramenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFerramenta)).EndInit();
            this.gbxFuncionario.ResumeLayout(false);
            this.gbxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNRequisicao;
        private System.Windows.Forms.GroupBox gbxFerramenta;
        private System.Windows.Forms.Button btnAddFerramenta;
        private System.Windows.Forms.PictureBox pbxFerramenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listVFerramenta;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader fabricante;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.GroupBox gbxFuncionario;
        private System.Windows.Forms.Label lblFuncaoFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblMatFunc;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
    }
}