using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_intermediate_polymorphism
{
    class DbCommand
    {
        public string Instruction { get; set; }
        public string QueryType { get; set; }
        public string CommandType { get; set; }
        public DbConnection DbConnection { get; set; }

        public DbCommand(DbConnection dbConnection, string queryType)
        {
            if (dbConnection == null)
                throw new ArgumentNullException(nameof(dbConnection));

            if (string.IsNullOrEmpty(dbConnection.DbType) || string.IsNullOrEmpty(queryType))
                throw new ArgumentNullException();

            this.DbConnection = dbConnection;
            this.CommandType = dbConnection.DbType;
            this.QueryType = queryType;
            this.Instruction = $"Sending {this.CommandType} {this.QueryType} query to DB...";
        }

        public void Execute()
        {
            this.DbConnection.OpenConnection();
            Console.WriteLine(this.Instruction);
            this.DbConnection.CloseConnection();
        }
    }
}
