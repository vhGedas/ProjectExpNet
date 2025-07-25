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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LblUser = new Label();
            TextBoxUser = new TextBox();
            LblSenha = new Label();
            TextBoxSenha = new TextBox();
            LblDatabase = new Label();
            TxtBoxDatabase = new TextBox();
            dataGridViewCliente = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            textBoxEmpresaId = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridViewTelCliente = new DataGridView();
            tabPage3 = new TabPage();
            dataGridViewFornecedor = new DataGridView();
            tabPage4 = new TabPage();
            dataGridViewTelFornecedor = new DataGridView();
            tabPage5 = new TabPage();
            dataGridViewGrupoProd = new DataGridView();
            tabPage6 = new TabPage();
            dataGridViewMarca = new DataGridView();
            tabPage7 = new TabPage();
            dataGridViewLinha = new DataGridView();
            tabPage8 = new TabPage();
            dataGridViewNcm = new DataGridView();
            tabPage9 = new TabPage();
            dataGridViewProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTelCliente).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTelFornecedor).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupoProd).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinha).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNcm).BeginInit();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
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
            // dataGridViewCliente
            // 
            dataGridViewCliente.AllowUserToOrderColumns = true;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(0, 6);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.Size = new Size(883, 424);
            dataGridViewCliente.TabIndex = 11;
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
            textBoxEmpresaId.TextChanged += textBoxEmpresaId_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Location = new Point(12, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(891, 452);
            tabControl1.TabIndex = 16;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewCliente);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(883, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CLIENTES";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewTelCliente);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(883, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TEL. CLIENTES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTelCliente
            // 
            dataGridViewTelCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTelCliente.Location = new Point(0, 3);
            dataGridViewTelCliente.Name = "dataGridViewTelCliente";
            dataGridViewTelCliente.Size = new Size(883, 421);
            dataGridViewTelCliente.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewFornecedor);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(883, 424);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "FORNECEDORES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFornecedor
            // 
            dataGridViewFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedor.Location = new Point(0, 0);
            dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            dataGridViewFornecedor.Size = new Size(881, 424);
            dataGridViewFornecedor.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewTelFornecedor);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(883, 424);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "TEL. FORNECEDORES";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTelFornecedor
            // 
            dataGridViewTelFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTelFornecedor.Location = new Point(3, 3);
            dataGridViewTelFornecedor.Name = "dataGridViewTelFornecedor";
            dataGridViewTelFornecedor.Size = new Size(880, 421);
            dataGridViewTelFornecedor.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridViewGrupoProd);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(883, 424);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "GRUPO PRODUTOS";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrupoProd
            // 
            dataGridViewGrupoProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupoProd.Location = new Point(-4, 0);
            dataGridViewGrupoProd.Name = "dataGridViewGrupoProd";
            dataGridViewGrupoProd.Size = new Size(885, 424);
            dataGridViewGrupoProd.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridViewMarca);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(883, 424);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "MARCA";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarca
            // 
            dataGridViewMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarca.Location = new Point(-4, 0);
            dataGridViewMarca.Name = "dataGridViewMarca";
            dataGridViewMarca.Size = new Size(887, 424);
            dataGridViewMarca.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridViewLinha);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(883, 424);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "LINHA";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLinha
            // 
            dataGridViewLinha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLinha.Location = new Point(3, 3);
            dataGridViewLinha.Name = "dataGridViewLinha";
            dataGridViewLinha.Size = new Size(877, 418);
            dataGridViewLinha.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(dataGridViewNcm);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(883, 424);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "NCM";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNcm
            // 
            dataGridViewNcm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNcm.Location = new Point(0, 0);
            dataGridViewNcm.Name = "dataGridViewNcm";
            dataGridViewNcm.Size = new Size(880, 421);
            dataGridViewNcm.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(dataGridViewProdutos);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(883, 424);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "PRODUTOS";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(0, 0);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(881, 424);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 609);
            Controls.Add(tabControl1);
            Controls.Add(textBoxEmpresaId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(TxtBoxDatabase);
            Controls.Add(LblDatabase);
            Controls.Add(TextBoxSenha);
            Controls.Add(LblSenha);
            Controls.Add(TextBoxUser);
            Controls.Add(LblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EXPORTAÇÃO DE DADOS";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTelCliente).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTelFornecedor).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupoProd).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarca).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinha).EndInit();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNcm).EndInit();
            tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
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
        private DataGridView dataGridViewCliente;
        private Button button2;
        private Label label1;
        private TextBox textBoxEmpresaId;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private DataGridView dataGridViewTelCliente;
        private DataGridView dataGridViewFornecedor;
        private DataGridView dataGridViewTelFornecedor;
        private DataGridView dataGridViewGrupoProd;
        private DataGridView dataGridViewMarca;
        private DataGridView dataGridViewLinha;
        private DataGridView dataGridViewNcm;
        private DataGridView dataGridViewProdutos;
    }
}
