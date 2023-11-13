using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_intermediate_polymorphism
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) {}

        public override void OpenConnection()
        {
            Console.WriteLine($"Connection to SQL Database: {this.ConnectionString} opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"Connection to SQL Database {this.ConnectionString} closed");
        }
    }
}
