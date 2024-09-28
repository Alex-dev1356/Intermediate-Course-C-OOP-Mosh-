using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Database_Connection_Exercise__Polymorphism_
{
    public abstract class DbConnectionBaseClass
    {
        public string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnectionBaseClass(string connectionString)
        {
            _connectionString = connectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string cannot be null or empty.");
            }
        }

        public abstract void ConnectionOpen();

        public abstract void ConnectionClose();
    }
}
