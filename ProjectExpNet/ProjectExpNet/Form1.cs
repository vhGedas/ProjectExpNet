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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<Context>();
            //optionsBuilder.UseOracle("User Id=VH_NET;Password=MANAGER;Data Source=192.168.1.237:1521/ORCL;");

            //using var context = new Context(optionsBuilder.Options);
            //var cidades = context.Cidades.ToList();
            //int x = 0;
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

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
            using var context = new Context(optionsBuilder.Options);

            //List<Cidade> cidades = context.Cidades.FromSqlRaw("SELECT TRUNC (SYSDATE) FROM DUAL").ToList();
            //var dt = DbContextExtensions.ExecuteSqlToDataTable(context, "SELECT TRUNC (SYSDATE) FROM DUAL");
            

            var dt = DbContextExtensions.ExecuteSqlToDataTable(context, "SELECT SYSDATE AS DATA_ATUAL FROM DUAL");

            if (dt.Rows.Count > 0)
            {
                DateTime dataAtual = Convert.ToDateTime(dt.Rows[0]["DATA_ATUAL"]);

                MessageBox.Show($"Data atual (Oracle): {dataAtual:dd/MM/yyyy}",
                                "Resultado da Query",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum dado retornado da consulta.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            int x = 0;

        }

       
    }

}