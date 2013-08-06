namespace SGA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.pictBErroSenha = new System.Windows.Forms.PictureBox();
            this.pictBErroMat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBErroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBErroMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.pictBErroSenha);
            this.gbxLogin.Controls.Add(this.pictBErroMat);
            this.gbxLogin.Controls.Add(this.pictureBox1);
            this.gbxLogin.Controls.Add(this.lblSenha);
            this.gbxLogin.Controls.Add(this.lblUsuario);
            this.gbxLogin.Controls.Add(this.btnSair);
            this.gbxLogin.Controls.Add(this.btnLogar);
            this.gbxLogin.Controls.Add(this.tbxSenha);
            this.gbxLogin.Controls.Add(this.tbxMatricula);
            this.gbxLogin.Location = new System.Drawing.Point(30, 37);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxLogin.Size = new System.Drawing.Size(432, 303);
            this.gbxLogin.TabIndex = 7;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login:";
            // 
            // pictBErroSenha
            // 
            this.pictBErroSenha.Image = global::SGA.Properties.Resources.exclamation;
            this.pictBErroSenha.Location = new System.Drawing.Point(402, 135);
            this.pictBErroSenha.Name = "pictBErroSenha";
            this.pictBErroSenha.Size = new System.Drawing.Size(16, 16);
            this.pictBErroSenha.TabIndex = 14;
            this.pictBErroSenha.TabStop = false;
            // 
            // pictBErroMat
            // 
            this.pictBErroMat.Image = global::SGA.Properties.Resources.exclamation;
            this.pictBErroMat.Location = new System.Drawing.Point(402, 64);
            this.pictBErroMat.Name = "pictBErroMat";
            this.pictBErroMat.Size = new System.Drawing.Size(16, 16);
            this.pictBErroMat.TabIndex = 13;
            this.pictBErroMat.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = global::SGA.Properties.Resources._1370592887_Login_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(16, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(150, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 16);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "*Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(150, 64);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 16);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "*Matrícula:";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SGA.Properties.Resources._1370597954_xfce_system_exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(230, 218);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 44);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogar.Image = global::SGA.Properties.Resources._1370593393_Check;
            this.btnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogar.Location = new System.Drawing.Point(47, 218);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(148, 44);
            this.btnLogar.TabIndex = 8;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(229, 133);
            this.tbxSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxSenha.MaxLength = 10;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(167, 23);
            this.tbxSenha.TabIndex = 7;
            this.tbxSenha.Leave += new System.EventHandler(this.tbxSenha_Leave);
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(229, 61);
            this.tbxMatricula.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxMatricula.MaxLength = 6;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(167, 23);
            this.tbxMatricula.TabIndex = 6;
            this.tbxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatricula_KeyPress);
            this.tbxMatricula.Leave += new System.EventHandler(this.tbxMatricula_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(492, 385);
            this.Controls.Add(this.gbxLogin);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBErroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBErroMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictBErroSenha;
        private System.Windows.Forms.PictureBox pictBErroMat;
    }
}