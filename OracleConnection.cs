using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_intermediate_polymorphism
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) {}

        public override void OpenConnection()
        {
            Console.WriteLine($"Connection to Oracle Database {this.ConnectionString} opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"Connection to Oracle Database {this.ConnectionString} closed");
        }
    }
}
