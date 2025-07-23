using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Oracle.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using ProjectExpNet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;


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
            var user = TextBoxUser.Text.ToUpper();
            var pass = TextBoxSenha.Text.ToUpper();
            var data = TxtBoxDatabase.Text.ToUpper();
            var empresaid = textBoxEmpresaId.Text.ToUpper();


            var optionsBuilder = new DbContextOptionsBuilder<ContextDb>();
            optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
            using var context = new ContextDb(optionsBuilder.Options);

            try
            {

                DataTable resultado = DbContextExtensions.ExecuteSqlToDataTable(context,
                    sql: $@"SELECT C.BAIRRO,
                                   C.CEP,
                                   C.NOME_CIDADE,
                                   E.NOME,
                                   C.ESTADOID,
                                   C.CNPJ_CPF,
                                   C.E_MAIL,
                                   C.ENDERECO,
                                   C.RAZAO_SOCIAL,
                                   C.COMPLEMENTO,
                                   C.NUMERO,
                                   C.SITE,
                                   C.INSCRICAO_ESTADUAL,
                                   C.INSCRICAO_MUNICIPAL,
                                   C.NOME_FANTASIA,
                                   C.TIPO_CLIENTE,
                                   C.OPTANTE_SIMPLES,
                                   C.DOC_IDENTIDADE,
                                   C.ORGAO_EXPEDIDOR,
                                   C.UF_ORGAO_EXPEDIDOR,
                                   C.NATURALIDADE,
                                   C.SEXO,
                                   C.ESTADO_CIVIL,
                                   C.NACIONALIDADE,
                                   C.GRUPOID,
                                   G.NOME,
                                   C.TABELA_PRECOID,
                                   C.NOME_TABELA_PRECO,
                                   C.VENDEDORID,
                                   C.CONDICAOID, 
                                   C.NOME_CONDICAO
                              FROM VW_CLIENTES C, ESTADOS E, GRUPO_CLIENTES G
                             WHERE  C.ESTADOID = E.ESTADOID
                               AND C.GRUPOID = G.GRUPOID
                               AND C.EMPRESAID = G.EMPRESAID
                               AND C.EMPRESAID = {empresaid}"

                    );

                dataGridView1.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro ao carregar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     

   



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Nenhum dado para exportar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Salvar como Excel",
                FileName = "Relatorio.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dt = (DataTable)dataGridView1.DataSource;

                        using (var wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "Consulta");
                            wb.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        
    }
}