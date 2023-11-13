using System;

namespace csharp_intermediate_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("colin/sql/db");

            sql.OpenConnection();
            sql.CloseConnection();
        }
    }
}
