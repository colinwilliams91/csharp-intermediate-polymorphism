using System;

namespace csharp_intermediate_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("colin/sql/db");

            //sql.OpenConnection();
            //sql.CloseConnection();

            // polymorphism: works with SqlConnection class or OracleConnection class
            var command = new DbCommand(dbConnection: new OracleConnection("colin/sql/db"), queryType: "INSERT");
            command.Execute();
        }
    }
}
