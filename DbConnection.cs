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
            // ensure class is always in valid state
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException();
            }
            
            ConnectionString = connectionString;
        }
    }
}
