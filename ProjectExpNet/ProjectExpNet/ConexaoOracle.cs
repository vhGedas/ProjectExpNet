using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectExpNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
    public class ConexaoOracle
    {
        public static ContextDb GetConexao(string user, string pass, string data) {

            var optionsBuilder = new DbContextOptionsBuilder<ContextDb>();
            optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
            using var context = new ContextDb(optionsBuilder.Options);
            return context;
        }

    }
}
