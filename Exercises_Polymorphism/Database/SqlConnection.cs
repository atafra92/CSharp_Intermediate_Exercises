using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Database
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (stopwatch.Elapsed.TotalSeconds < TimeOut.Seconds)
            {
                Console.WriteLine("Database connection to MS SQL is opened");
            }
            else
            {
                throw new TimeoutException("Connection to database was not opened in time");
            }

            stopwatch.Stop();
        }

        public override void Close ()
        {
            Console.WriteLine("Database connection to MS SQL is closed");
        }
    }
}
