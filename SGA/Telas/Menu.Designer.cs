namespace SGA
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemlFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItmFerramenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNFerramenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemlFerramenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItmRequisicao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItmNRequisição = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLRequisicao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItmRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItmLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItmFuncionario,
            this.MenuItmFerramenta,
            this.MenuItmRequisicao,
            this.MenuItmRelatorios,
            this.MenuItmLogoff,
            this.MenuItmSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1018, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItmFuncionario
            // 
            this.MenuItmFuncionario.AutoSize = false;
            this.MenuItmFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNFuncionario,
            this.menuItemlFuncionario});
            this.MenuItmFuncionario.Name = "MenuItmFuncionario";
            this.MenuItmFuncionario.Size = new System.Drawing.Size(100, 34);
            this.MenuItmFuncionario.Text = "Funcionário";
            // 
            // menuItemNFuncionario
            // 
            this.menuItemNFuncionario.Name = "menuItemNFuncionario";
            this.menuItemNFuncionario.Size = new System.Drawing.Size(242, 22);
            this.menuItemNFuncionario.Text = "Novo Funcionário           (F2)";
            this.menuItemNFuncionario.Click += new System.EventHandler(this.menuItemNFuncionario_Click);
            // 
            // menuItemlFuncionario
            // 
            this.menuItemlFuncionario.Name = "menuItemlFuncionario";
            this.menuItemlFuncionario.Size = new System.Drawing.Size(242, 22);
            this.menuItemlFuncionario.Text = "Pesquisar Funcionário    (F3)";
            this.menuItemlFuncionario.Click += new System.EventHandler(this.menuItemlFuncionario_Click);
            // 
            // MenuItmFerramenta
            // 
            this.MenuItmFerramenta.AutoSize = false;
            this.MenuItmFerramenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNFerramenta,
            this.menuItemlFerramenta});
            this.MenuItmFerramenta.Name = "MenuItmFerramenta";
            this.MenuItmFerramenta.Size = new System.Drawing.Size(100, 34);
            this.MenuItmFerramenta.Text = "Ferramenta";
            // 
            // menuItemNFerramenta
            // 
            this.menuItemNFerramenta.Name = "menuItemNFerramenta";
            this.menuItemNFerramenta.Size = new System.Drawing.Size(243, 22);
            this.menuItemNFerramenta.Text = "Nova Ferramenta           (F5)";
            this.menuItemNFerramenta.Click += new System.EventHandler(this.MenuItemNFerramenta_Click);
            // 
            // menuItemlFerramenta
            // 
            this.menuItemlFerramenta.Name = "menuItemlFerramenta";
            this.menuItemlFerramenta.Size = new System.Drawing.Size(243, 22);
            this.menuItemlFerramenta.Text = "Pesquisar Ferramenta    (F6)";
            this.menuItemlFerramenta.Click += new System.EventHandler(this.menuItemlFerramenta_Click);
            // 
            // MenuItmRequisicao
            // 
            this.MenuItmRequisicao.AutoSize = false;
            this.MenuItmRequisicao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItmNRequisição,
            this.menuItemLRequisicao});
            this.MenuItmRequisicao.Name = "MenuItmRequisicao";
            this.MenuItmRequisicao.Size = new System.Drawing.Size(100, 34);
            this.MenuItmRequisicao.Text = "Requisição";
            // 
            // menuItmNRequisição
            // 
            this.menuItmNRequisição.Name = "menuItmNRequisição";
            this.menuItmNRequisição.Size = new System.Drawing.Size(233, 22);
            this.menuItmNRequisição.Text = "Nova Requisição          (F7)";
            this.menuItmNRequisição.Click += new System.EventHandler(this.menuItemNRequisição_Click);
            // 
            // menuItemLRequisicao
            // 
            this.menuItemLRequisicao.Name = "menuItemLRequisicao";
            this.menuItemLRequisicao.Size = new System.Drawing.Size(233, 22);
            this.menuItemLRequisicao.Text = "Pesquisar Requisição   (F8)";
            this.menuItemLRequisicao.Click += new System.EventHandler(this.menuItemLRequisicao_Click);
            // 
            // MenuItmRelatorios
            // 
            this.MenuItmRelatorios.AutoSize = false;
            this.MenuItmRelatorios.Name = "MenuItmRelatorios";
            this.MenuItmRelatorios.Size = new System.Drawing.Size(94, 34);
            this.MenuItmRelatorios.Text = "Relatórios  (F9)";
            this.MenuItmRelatorios.Click += new System.EventHandler(this.MenuItmRelatorios_Click);
            // 
            // MenuItmLogoff
            // 
            this.MenuItmLogoff.AutoSize = false;
            this.MenuItmLogoff.Name = "MenuItmLogoff";
            this.MenuItmLogoff.Size = new System.Drawing.Size(94, 34);
            this.MenuItmLogoff.Text = "Logoff  (F10)";
            this.MenuItmLogoff.Click += new System.EventHandler(this.MenuItmLogoff_Click);
            // 
            // MenuItmSair
            // 
            this.MenuItmSair.AutoSize = false;
            this.MenuItmSair.Name = "MenuItmSair";
            this.MenuItmSair.Size = new System.Drawing.Size(94, 34);
            this.MenuItmSair.Text = "Sair  (F11)";
            this.MenuItmSair.Click += new System.EventHandler(this.MenuItmSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 744);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Sistema de Gerenciamento de Almoxarifado";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem MenuItmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuItmFerramenta;
        private System.Windows.Forms.ToolStripMenuItem MenuItmRequisicao;
        private System.Windows.Forms.ToolStripMenuItem MenuItmRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuItmLogoff;
        private System.Windows.Forms.ToolStripMenuItem MenuItmSair;
        private System.Windows.Forms.ToolStripMenuItem menuItemNFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuItemlFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuItemNFerramenta;
        private System.Windows.Forms.ToolStripMenuItem menuItemlFerramenta;
        private System.Windows.Forms.ToolStripMenuItem menuItmNRequisição;
        private System.Windows.Forms.ToolStripMenuItem menuItemLRequisicao;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}