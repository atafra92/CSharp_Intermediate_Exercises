using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Database
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (stopwatch.Elapsed.TotalSeconds < TimeOut.Seconds)
            {
                Console.WriteLine("Connection to Oracle database is opened");
            }
            else
            {              
                throw new TimeoutException("Connection to database was not opened in time");
            }
            stopwatch.Stop();
        }

        public override void Close()
        {
            Console.WriteLine("Connection to Oracle database is closed");
        }
    }
}
