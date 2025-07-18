namespace ProjectExpNet
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
            LblUser = new Label();
            TextBoxUser = new TextBox();
            LblSenha = new Label();
            TextBoxSenha = new TextBox();
            LblDatabase = new Label();
            TxtBoxDatabase = new TextBox();
            BtnConectar = new Button();
            dataGridView1 = new DataGridView();
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
            TextBoxUser.Location = new Point(94, 19);
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
            BtnConectar.Location = new Point(725, 19);
            BtnConectar.Name = "BtnConectar";
            BtnConectar.Size = new Size(75, 23);
            BtnConectar.TabIndex = 10;
            BtnConectar.Text = "CONECTAR";
            BtnConectar.UseVisualStyleBackColor = true;
            BtnConectar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(866, 383);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnConectar);
            Controls.Add(TxtBoxDatabase);
            Controls.Add(LblDatabase);
            Controls.Add(TextBoxSenha);
            Controls.Add(LblSenha);
            Controls.Add(TextBoxUser);
            Controls.Add(LblUser);
            Name = "Form1";
            Text = "Form1";
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
    }
}
