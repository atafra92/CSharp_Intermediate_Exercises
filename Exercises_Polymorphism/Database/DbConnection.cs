using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Database
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan TimeOut
        {
            get
            {              
                var timeout = DateTime.Now.Subtract(DateTime.Now.AddSeconds(-15));
                return timeout;    
            }
        }

        public DbConnection(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or empty!");
            }

            _connectionString = connectionString;
           
        }

        public abstract void Open();

        //public virtual void Open()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    if (stopwatch.Elapsed.TotalSeconds < TimeOut.Seconds)
        //    {
        //        Console.WriteLine("Database connection is opened");
        //    }
        //    else
        //    {
        //        throw new TimeoutException("Connection to database was not opened in time");
        //    }

        //    stopwatch.Stop();
        //}

        public abstract void Close();

    }
}
