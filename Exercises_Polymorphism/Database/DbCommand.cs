using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class DbCommand
    {
        private readonly string _instructions;
        private DbConnection _dbConnection;
        
        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (dbConnection == null)
            {
                throw new ArgumentException("Database Connection cannot be null!");
            }
            if(string.IsNullOrWhiteSpace(instructions))
            {
                throw new ArgumentException("Instrunctions cannot be null or empty!");
            }

            _dbConnection = dbConnection;
            _instructions = instructions;
        }

        public void Execute()
        {       
            _dbConnection.Open();          

            Console.WriteLine(_instructions);

            _dbConnection.Close();
        }
    }
}
