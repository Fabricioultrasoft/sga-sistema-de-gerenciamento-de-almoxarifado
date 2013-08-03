namespace SGA.Telas
{
    partial class EditarComboBox
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
            this.gbxEditar = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.funcao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbnNova = new System.Windows.Forms.Button();
            this.gbxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEditar
            // 
            this.gbxEditar.Controls.Add(this.listView1);
            this.gbxEditar.Controls.Add(this.btnEditar);
            this.gbxEditar.Controls.Add(this.btnCancelar);
            this.gbxEditar.Controls.Add(this.btnExcluir);
            this.gbxEditar.Controls.Add(this.tbnNova);
            this.gbxEditar.Location = new System.Drawing.Point(11, 10);
            this.gbxEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditar.Name = "gbxEditar";
            this.gbxEditar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditar.Size = new System.Drawing.Size(356, 281);
            this.gbxEditar.TabIndex = 0;
            this.gbxEditar.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.funcao});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(185, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(165, 239);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // funcao
            // 
            this.funcao.Text = "Função";
            this.funcao.Width = 160;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SGA.Properties.Resources._1370640620_edit_file;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(6, 86);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 54);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SGA.Properties.Resources._1370597954_xfce_system_exit;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(6, 210);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 54);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SGA.Properties.Resources._1370635927_Trash_Delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(6, 148);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(173, 54);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbnNova
            // 
            this.tbnNova.Image = global::SGA.Properties.Resources._1370629399_plus;
            this.tbnNova.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnNova.Location = new System.Drawing.Point(6, 24);
            this.tbnNova.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnNova.Name = "tbnNova";
            this.tbnNova.Size = new System.Drawing.Size(173, 54);
            this.tbnNova.TabIndex = 13;
            this.tbnNova.Text = "Nova";
            this.tbnNova.UseVisualStyleBackColor = true;
            this.tbnNova.Click += new System.EventHandler(this.tbnNova_Click);
            // 
            // EditarComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(379, 302);
            this.Controls.Add(this.gbxEditar);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(399, 157);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditarComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA";
            this.Load += new System.EventHandler(this.EditarComboBox_Load);
            this.gbxEditar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button tbnNova;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader funcao;
    }
}