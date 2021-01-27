using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand db = new DbCommand(new SqlConnection("Sample Sql connection string"), "INSERT INTO dbo.Students VALUES (1, 'Antonio', 'Tafra')");

            db.Execute();

            Console.ReadLine();
        }
    }
}
