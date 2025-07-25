using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectExpNet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
     public static class DbContextExtensions
    {
        public static DataTable ExecuteSqlToDataTable(string user, string pass, string data , string sql)
        {
            var dt = new DataTable();

            var optionsBuilder = new DbContextOptionsBuilder<ContextDb>();
            optionsBuilder.UseOracle($"User Id={user};Password={pass};Data Source={data}:1521/ORCL;");
            using var context = new ContextDb(optionsBuilder.Options);

            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

                command.Connection.Close();
            }

            return dt;
        }
    }
}
