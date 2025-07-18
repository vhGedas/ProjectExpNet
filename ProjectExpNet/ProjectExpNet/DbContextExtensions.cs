using Microsoft.EntityFrameworkCore;
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
        public static DataTable ExecuteSqlToDataTable(this DbContext context, string sql)
        {
            var dt = new DataTable();

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
