using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Oracle.EntityFrameworkCore;
using Oracle.EntityFrameworkCore.Storage.Internal;
using Oracle.ManagedDataAccess.Client;
using ProjectExpNet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Text;


namespace ProjectExpNet
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
            //dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            Processar(0);
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }




        }

        private void TextBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }




        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxDatabase_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Arrumando colunas linhas na aba de CLIENTES

            dataGridViewCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCliente.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Telefone de Clientes
            dataGridViewTelCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTelCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTelCliente.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Fornecedores
            dataGridViewFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFornecedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFornecedor.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Telefone de Fornecedores
            dataGridViewTelFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTelFornecedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTelFornecedor.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Grupo de produtos.
            dataGridViewGrupoProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGrupoProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewGrupoProd.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Marca
            dataGridViewMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMarca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMarca.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Linha
            dataGridViewLinha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLinha.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLinha.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de NCM
            //dataGridViewNcm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridViewNcm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridViewNcm.AutoResizeColumns();

            //Arrumando colunas e linhas na aba de Produtos
            //dataGridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridViewProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridViewProdutos.AutoResizeColumns();

        }

        public void ExportarDataTableParaCSV(DataTable tabela, string nomeArquivo)
        {
            if (tabela == null || tabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para exportar!");
                return;
            }

            string pastaExportacao = @"C:\MeusExports";

            if (!Directory.Exists(pastaExportacao))
            {
                Directory.CreateDirectory(pastaExportacao);
            }
            string hash = Guid.NewGuid().ToString("N").Substring(0, 6);
            string caminhoArquivo = Path.Combine(pastaExportacao, $"{nomeArquivo}.csv");
            try
            {
                var linhas = new List<string>();
                // Cabeçalho
                string cabecalho = string.Join(";", tabela.Columns.Cast<DataColumn>().Select(col => col.ColumnName));
                linhas.Add(cabecalho);
                // Dados
                foreach (DataRow row in tabela.Rows)
                {
                    string linha = string.Join(";", row.ItemArray.Select(valor => valor?.ToString()?.Replace(";", ",") ?? ""));
                    linhas.Add(linha);
                }
                File.WriteAllLines(caminhoArquivo, linhas, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar: {ex.Message}");
            }
        }

        private DataTable getDataDb(string sql)
        {

            try
            {
                var user = TextBoxUser.Text.ToUpper();
                var pass = TextBoxSenha.Text.ToUpper();
                var data = TxtBoxDatabase.Text.ToUpper();
                var empresaid = textBoxEmpresaId.Text.ToUpper();


                var optionsBuilder = new DbContextOptionsBuilder<ContextDb>();
                optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
                using var context = new ContextDb(optionsBuilder.Options);


                sql = String.Format(Dados.Clientes, empresaid);
                return DbContextExtensions.ExecuteSqlToDataTable(context, sql);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private bool validaVazio()
        {

            if (TextBoxUser.Text.Length > 0)
            {
                return true;
            }

            return false;

        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validaVazio())
                {
                    MessageBox.Show("Nada a exportar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pastaExportacao = @"C:\MeusExports";
                // Cria a pasta, se não existir
                if (!System.IO.Directory.Exists(pastaExportacao))
                {
                    System.IO.Directory.CreateDirectory(pastaExportacao);
                }
                else
                {
                    // Limpa todos os arquivos da pasta
                    string[] arquivosExistentes = System.IO.Directory.GetFiles(pastaExportacao);
                    foreach (string arquivo in arquivosExistentes)
                    {
                        System.IO.File.Delete(arquivo);
                    }
                }
                string sqlClientes = Dados.Clientes;
                if (sqlClientes.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlClientes), "Clientes");
                }

                string sqlNcm = Dados.Ncm;
                if (sqlNcm.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlNcm), "Ncm");
                }
                string sqlFornecedores = Dados.Fornecedor;
                if (sqlFornecedores.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlFornecedores), "Fornecedores");
                }
                string sqlGrupoProdutos = Dados.GrupoProd;
                if (sqlGrupoProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlGrupoProdutos), "GrupoProdutos");
                }
                string sqlLinhaProdutos = Dados.Linha;
                if (sqlLinhaProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlLinhaProdutos), "LinhaProdutos");
                }
                string sqlMarcaProdutos = Dados.Marca;
                if (sqlMarcaProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlMarcaProdutos), "MarcaProdutos");
                }
                string sqlProdutos = Dados.Produtos;
                if (sqlProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlProdutos), "Produtos");
                }
                string sqlTelefoneClientes = Dados.TelefoneCliente;
                if (sqlTelefoneClientes.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlTelefoneClientes), "TelefoneClientes");
                }
                string sqlTelefoneFornecedores = Dados.TelefoneFornecedor;
                if (sqlTelefoneFornecedores.Count() != 0)
                {
                    ExportarDataTableParaCSV(getDataDb(sqlTelefoneFornecedores), "TelefoneFornecedores");
                }

                MessageBox.Show($"Exportação concluída com sucesso!\nArquivo salvo em: {pastaExportacao}", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var resultado = MessageBox.Show("Deseja abrir o arquivo agora?", "Abrir arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = pastaExportacao,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = tabControl1.SelectedIndex;
            Processar(x);
        }
        private void Processar(int index)
        {
            var user = TextBoxUser.Text.ToUpper();
            var pass = TextBoxSenha.Text.ToUpper();
            var data = TxtBoxDatabase.Text.ToUpper();
            var empresaid = textBoxEmpresaId.Text.ToUpper();


            var optionsBuilder = new DbContextOptionsBuilder<ContextDb>();
            optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
            using var context = new ContextDb(optionsBuilder.Options);

            try
            {
                string sql = "";
                DataTable resultado = null;

                if (index == 0)
                {
                    sql = String.Format(Dados.Clientes, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewCliente.DataSource = resultado;
                }
                else if (index == 1)
                {
                    sql = String.Format(Dados.TelefoneCliente, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewTelCliente.DataSource = resultado;

                }

                else if (index == 2)
                {
                    sql = String.Format(Dados.Fornecedor, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewFornecedor.DataSource = resultado;
                }
                else if (index == 3)
                {
                    sql = String.Format(Dados.TelefoneFornecedor, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewTelFornecedor.DataSource = resultado;
                }

                else if (index == 4)
                {
                    sql = String.Format(Dados.GrupoProd, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewGrupoProd.DataSource = resultado;
                }

                else if (index == 5)
                {
                    sql = String.Format(Dados.Marca, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewMarca.DataSource = resultado;
                }

                else if (index == 6)
                {
                    sql = String.Format(Dados.Linha, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewLinha.DataSource = resultado;
                }

                else if (index == 7)
                {
                    sql = String.Format(Dados.Ncm, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewNcm.DataSource = resultado;
                }

                else if (index == 8)
                {

                    sql = String.Format(Dados.Produtos, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(context, sql);
                    dataGridViewProdutos.DataSource = resultado;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro ao carregar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}