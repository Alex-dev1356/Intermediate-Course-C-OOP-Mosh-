using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Database_Connection_Exercise__Polymorphism_
{
    public class SqlConnectionDerivedClass : DbConnectionBaseClass
    {
        public string _connectionString { get; set; }
        public SqlConnectionDerivedClass(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void ConnectionOpen()
        {
            Console.WriteLine("Sql connection is open.");
        }

        public override void ConnectionClose()
        {
            Console.WriteLine("Sql connection is closed.");
        }
    }
}
