﻿namespace ProjectExpNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LblUser = new Label();
            TextBoxUser = new TextBox();
            LblSenha = new Label();
            TextBoxSenha = new TextBox();
            LblDatabase = new Label();
            TxtBoxDatabase = new TextBox();
            BtnConectar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBoxEmpresaId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblUser
            // 
            LblUser.Font = new Font("Segoe UI", 12F);
            LblUser.Location = new Point(12, 21);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(105, 31);
            LblUser.TabIndex = 2;
            LblUser.Text = "USUÁRIO:";
            LblUser.Click += label1_Click;
            // 
            // TextBoxUser
            // 
            TextBoxUser.CausesValidation = false;
            TextBoxUser.ForeColor = SystemColors.WindowText;
            TextBoxUser.Location = new Point(97, 19);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.Size = new Size(133, 23);
            TextBoxUser.TabIndex = 3;
            TextBoxUser.Text = "VH_NET";
            TextBoxUser.TextChanged += TextBoxUser_TextChanged;
            TextBoxUser.KeyDown += TextBoxUser_KeyDown;
            // 
            // LblSenha
            // 
            LblSenha.Font = new Font("Segoe UI", 12F);
            LblSenha.Location = new Point(255, 21);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(67, 18);
            LblSenha.TabIndex = 4;
            LblSenha.Text = "SENHA:";
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.ForeColor = SystemColors.WindowText;
            TextBoxSenha.Location = new Point(325, 19);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '*';
            TextBoxSenha.Size = new Size(133, 23);
            TextBoxSenha.TabIndex = 7;
            TextBoxSenha.Text = "MANAGER";
            TextBoxSenha.TextChanged += TextBoxSenha_TextChanged;
            // 
            // LblDatabase
            // 
            LblDatabase.Font = new Font("Segoe UI", 12F);
            LblDatabase.Location = new Point(480, 21);
            LblDatabase.Name = "LblDatabase";
            LblDatabase.Size = new Size(105, 31);
            LblDatabase.TabIndex = 8;
            LblDatabase.Text = "DATABASE:";
            LblDatabase.Click += label1_Click_1;
            // 
            // TxtBoxDatabase
            // 
            TxtBoxDatabase.ForeColor = SystemColors.WindowText;
            TxtBoxDatabase.Location = new Point(570, 19);
            TxtBoxDatabase.Name = "TxtBoxDatabase";
            TxtBoxDatabase.Size = new Size(133, 23);
            TxtBoxDatabase.TabIndex = 9;
            TxtBoxDatabase.Text = "192.168.1.237";
            TxtBoxDatabase.TextChanged += TxtBoxDatabase_TextChanged;
            // 
            // BtnConectar
            // 
            BtnConectar.Location = new Point(735, 12);
            BtnConectar.Name = "BtnConectar";
            BtnConectar.Size = new Size(127, 61);
            BtnConectar.TabIndex = 10;
            BtnConectar.Text = "CONECTAR";
            BtnConectar.UseVisualStyleBackColor = true;
            BtnConectar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(875, 470);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 574);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 12;
            button1.Text = "ORGANIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(763, 574);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 13;
            button2.Text = "EXPORTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 14;
            label1.Text = "EMPRESAID:";
            // 
            // textBoxEmpresaId
            // 
            textBoxEmpresaId.Location = new Point(112, 50);
            textBoxEmpresaId.Name = "textBoxEmpresaId";
            textBoxEmpresaId.Size = new Size(118, 23);
            textBoxEmpresaId.TabIndex = 15;
            textBoxEmpresaId.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 609);
            Controls.Add(textBoxEmpresaId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnConectar);
            Controls.Add(TxtBoxDatabase);
            Controls.Add(LblDatabase);
            Controls.Add(TextBoxSenha);
            Controls.Add(LblSenha);
            Controls.Add(TextBoxUser);
            Controls.Add(LblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EXPORTAÇÃO DE DADOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblUser;
        private TextBox TextBoxUser;
        private Label LblSenha;
        private TextBox TextBoxSenha;
        private Label LblDatabase;
        private TextBox TxtBoxDatabase;
        private Button BtnConectar;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBoxEmpresaId;
    }
}
