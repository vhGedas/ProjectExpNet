using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ProjectExpNet.Data;


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
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseOracle("User Id=VH_NET;Password=MANAGER;Data Source=192.168.1.237:1521/ORCL;"); 

            using var context = new Context(optionsBuilder.Options);
            var clientes = context.Cidades.ToList();
            int x = 0;
        }
        
        
      
    }
}
