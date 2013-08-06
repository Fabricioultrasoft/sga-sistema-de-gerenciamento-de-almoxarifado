namespace SGA.Telas
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabTipo = new System.Windows.Forms.TabControl();
            this.gbxrelatorio.SuspendLayout();
            this.tabTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxrelatorio
            // 
            this.gbxrelatorio.Controls.Add(this.tabTipo);
            this.gbxrelatorio.Location = new System.Drawing.Point(12, 13);
            this.gbxrelatorio.Name = "gbxrelatorio";
            this.gbxrelatorio.Size = new System.Drawing.Size(922, 620);
            this.gbxrelatorio.TabIndex = 0;
            this.gbxrelatorio.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipos de relatório";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabTipo
            // 
            this.tabTipo.Controls.Add(this.tabPage1);
            this.tabTipo.Controls.Add(this.tabPage2);
            this.tabTipo.Location = new System.Drawing.Point(174, 166);
            this.tabTipo.Name = "tabTipo";
            this.tabTipo.SelectedIndex = 0;
            this.tabTipo.Size = new System.Drawing.Size(548, 325);
            this.tabTipo.TabIndex = 0;
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
            this.gbxrelatorio.ResumeLayout(false);
            this.tabTipo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxrelatorio;
        private System.Windows.Forms.TabControl tabTipo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}