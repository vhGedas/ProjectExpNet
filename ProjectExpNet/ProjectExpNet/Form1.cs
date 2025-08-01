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
        private string user;
        private string pass;
        private string data;
        public string empresaid;


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            user = TextBoxUser.Text.ToUpper();
            pass = TextBoxSenha.Text.ToUpper();
            data = TxtBoxDatabase.Text.ToUpper();
            empresaid = textBoxEmpresaId.Text.ToUpper();

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



        private bool validaVazio()
        {

            if (TextBoxUser.Text.Length > 0)
            {
                return true;
            }

            return false;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = tabControl1.SelectedIndex;
            Processar(x);
        }
        private void Processar(int index)
        {
            try
            {
                string sql = "";
                DataTable resultado = null;

                if (user.Length == 0 && pass.Length == 0 && data.Length == 0 && empresaid.Length == 0)
                {

                    return;
                }



                if (index == 0)
                {
                    sql = String.Format(Dados.Clientes, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewCliente.DataSource = resultado;
                }
                else if (index == 1)
                {
                    sql = String.Format(Dados.TelefoneCliente, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewTelCliente.DataSource = resultado;

                }

                else if (index == 2)
                {
                    sql = String.Format(Dados.Fornecedor, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewFornecedor.DataSource = resultado;
                }
                else if (index == 3)
                {
                    sql = String.Format(Dados.TelefoneFornecedor, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewTelFornecedor.DataSource = resultado;
                }

                else if (index == 4)
                {
                    sql = String.Format(Dados.GrupoProd, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewGrupoProd.DataSource = resultado;
                }

                else if (index == 5)
                {
                    sql = String.Format(Dados.Marca, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewMarca.DataSource = resultado;
                }

                else if (index == 6)
                {
                    sql = String.Format(Dados.Linha, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewLinha.DataSource = resultado;
                }

                else if (index == 7)
                {
                    sql = String.Format(Dados.Ncm, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewNcm.DataSource = resultado;
                }

                else if (index == 8)
                {

                    sql = String.Format(Dados.Produtos, empresaid);
                    resultado = DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sql);
                    dataGridViewProdutos.DataSource = resultado;
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show($"Erro: {ex.Message}", "Erro ao carregar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro: {ex.Message}", "Erro ao carregar dados");
                return;
            }

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
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlClientes, empresaid)), "Clientes");
                }

                string sqlNcm = Dados.Ncm;
                if (sqlNcm.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, sqlNcm), "Ncm");
                }
                string sqlFornecedores = Dados.Fornecedor;
                if (sqlFornecedores.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlFornecedores, empresaid)), "Fornecedores");
                }
                string sqlGrupoProdutos = Dados.GrupoProd;
                if (sqlGrupoProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlGrupoProdutos, empresaid)), "GrupoProdutos");
                }
                string sqlLinhaProdutos = Dados.Linha;
                if (sqlLinhaProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlLinhaProdutos, empresaid)), "LinhaProdutos");
                }
                string sqlMarcaProdutos = Dados.Marca;
                if (sqlMarcaProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlMarcaProdutos, empresaid)), "MarcaProdutos");
                }
                string sqlProdutos = Dados.Produtos;
                if (sqlProdutos.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlProdutos, empresaid)), "Produtos");
                }
                string sqlTelefoneClientes = Dados.TelefoneCliente;
                if (sqlTelefoneClientes.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlTelefoneClientes, empresaid)), "TelefoneClientes");
                }
                string sqlTelefoneFornecedores = Dados.TelefoneFornecedor;
                if (sqlTelefoneFornecedores.Count() != 0)
                {
                    ExportarDataTableParaCSV(DbContextExtensions.ExecuteSqlToDataTable(user, pass, data, String.Format(sqlTelefoneFornecedores, empresaid)), "TelefoneFornecedores");
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






        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {

            user = TextBoxUser.Text.ToUpper();


        }

        private void TextBoxSenha_TextChanged(object sender, EventArgs e)
        {

            pass = TextBoxSenha.Text.ToUpper();

        }

        private void TxtBoxDatabase_TextChanged(object sender, EventArgs e)
        {

            data = TxtBoxDatabase.Text.ToUpper();

        }

        private void textBoxEmpresaId_TextChanged(object sender, EventArgs e)
        {

            empresaid = textBoxEmpresaId.Text.ToUpper();

        }
    }
}