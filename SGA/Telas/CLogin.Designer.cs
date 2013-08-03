namespace SGA.Telas
{
    partial class CLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxCSenha = new System.Windows.Forms.TextBox();
            this.btnSalvarLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(96, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirme a Senha:";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbxSenha.Location = new System.Drawing.Point(171, 66);
            this.tbxSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(167, 23);
            this.tbxSenha.TabIndex = 2;
            // 
            // tbxCSenha
            // 
            this.tbxCSenha.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tbxCSenha.Location = new System.Drawing.Point(171, 121);
            this.tbxCSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCSenha.Name = "tbxCSenha";
            this.tbxCSenha.PasswordChar = '*';
            this.tbxCSenha.Size = new System.Drawing.Size(167, 23);
            this.tbxCSenha.TabIndex = 3;
            // 
            // btnSalvarLogin
            // 
            this.btnSalvarLogin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnSalvarLogin.Image = global::SGA.Properties.Resources._1370593393_Check;
            this.btnSalvarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarLogin.Location = new System.Drawing.Point(21, 218);
            this.btnSalvarLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarLogin.Name = "btnSalvarLogin";
            this.btnSalvarLogin.Size = new System.Drawing.Size(148, 44);
            this.btnSalvarLogin.TabIndex = 4;
            this.btnSalvarLogin.Text = "OK";
            this.btnSalvarLogin.UseVisualStyleBackColor = true;
            this.btnSalvarLogin.Click += new System.EventHandler(this.btnSalvarLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbxSenha);
            this.groupBox1.Controls.Add(this.btnSalvarLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 298);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova senha";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.button1.Image = global::SGA.Properties.Resources._1370597340_button_cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(220, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(412, 322);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA";
            this.Load += new System.EventHandler(this.CLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxCSenha;
        private System.Windows.Forms.Button btnSalvarLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}