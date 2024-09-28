using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Database_Connection_Exercise__Polymorphism_
{
    public class DbCommandExercise
    {
        private readonly DbConnectionBaseClass _dbConnection;
        public DbCommandExercise(DbConnectionBaseClass dbConnection)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Database connection cannot be null.");

            _dbConnection = dbConnection;
        }

        public void Execute()
        {
            _dbConnection.ConnectionOpen();
            Console.WriteLine("Command: " + _dbConnection._connectionString);
            _dbConnection.ConnectionClose();
        }

    }
}
