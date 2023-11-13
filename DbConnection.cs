using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_intermediate_polymorphism
{
    class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
