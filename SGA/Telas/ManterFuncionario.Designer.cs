namespace SGA.Telas
{
    partial class ManterFuncionario
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
            this.gbxFuncionario = new System.Windows.Forms.GroupBox();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.btnAddFuncao = new System.Windows.Forms.Button();
            this.cbxPermissao = new System.Windows.Forms.ComboBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFuncionario
            // 
            this.gbxFuncionario.Controls.Add(this.btnRedefinirSenha);
            this.gbxFuncionario.Controls.Add(this.btnAddFuncao);
            this.gbxFuncionario.Controls.Add(this.cbxPermissao);
            this.gbxFuncionario.Controls.Add(this.cbxFuncao);
            this.gbxFuncionario.Controls.Add(this.lblFuncao);
            this.gbxFuncionario.Controls.Add(this.lblPermissao);
            this.gbxFuncionario.Controls.Add(this.lblNome);
            this.gbxFuncionario.Controls.Add(this.lblMatricula);
            this.gbxFuncionario.Controls.Add(this.tbxNome);
            this.gbxFuncionario.Controls.Add(this.tbxMatricula);
            this.gbxFuncionario.Controls.Add(this.btnCancelar);
            this.gbxFuncionario.Controls.Add(this.btnSalvar);
            this.gbxFuncionario.Location = new System.Drawing.Point(220, 133);
            this.gbxFuncionario.Name = "gbxFuncionario";
            this.gbxFuncionario.Size = new System.Drawing.Size(476, 399);
            this.gbxFuncionario.TabIndex = 0;
            this.gbxFuncionario.TabStop = false;
            this.gbxFuncionario.Text = "Novo Funcionário";
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.Image = global::SGA.Properties.Resources._1372224553_key_delete;
            this.btnRedefinirSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedefinirSenha.Location = new System.Drawing.Point(180, 268);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(148, 44);
            this.btnRedefinirSenha.TabIndex = 39;
            this.btnRedefinirSenha.Text = "Redefinir Senha";
            this.btnRedefinirSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedefinirSenha.UseVisualStyleBackColor = true;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // btnAddFuncao
            // 
            this.btnAddFuncao.Image = global::SGA.Properties.Resources._1370629399_plus;
            this.btnAddFuncao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFuncao.Location = new System.Drawing.Point(432, 157);
            this.btnAddFuncao.Name = "btnAddFuncao";
            this.btnAddFuncao.Size = new System.Drawing.Size(38, 38);
            this.btnAddFuncao.TabIndex = 35;
            this.btnAddFuncao.UseVisualStyleBackColor = true;
            this.btnAddFuncao.Click += new System.EventHandler(this.btnOpcaoFuncao_Click);
            // 
            // cbxPermissao
            // 
            this.cbxPermissao.FormattingEnabled = true;
            this.cbxPermissao.Location = new System.Drawing.Point(226, 221);
            this.cbxPermissao.Name = "cbxPermissao";
            this.cbxPermissao.Size = new System.Drawing.Size(167, 24);
            this.cbxPermissao.TabIndex = 20;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(226, 165);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(167, 24);
            this.cbxFuncao.TabIndex = 19;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(73, 168);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(62, 16);
            this.lblFuncao.TabIndex = 18;
            this.lblFuncao.Text = "*Função:";
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(73, 224);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(80, 16);
            this.lblPermissao.TabIndex = 17;
            this.lblPermissao.Text = "*Permissão:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(73, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 16);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "*Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(73, 61);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 16);
            this.lblMatricula.TabIndex = 15;
            this.lblMatricula.Text = "*Matrícula:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(226, 110);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(167, 23);
            this.tbxNome.TabIndex = 14;
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(226, 58);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(167, 23);
            this.tbxMatricula.TabIndex = 13;
            this.tbxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatricula_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(267, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SGA.Properties.Resources._1370629123_button_30;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(76, 332);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 44);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ManterFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.gbxFuncionario);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManterFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.ManterFuncionario_Load_1);
            this.gbxFuncionario.ResumeLayout(false);
            this.gbxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFuncionario;
        private System.Windows.Forms.ComboBox cbxPermissao;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAddFuncao;
        private System.Windows.Forms.Button btnRedefinirSenha;

    }
}