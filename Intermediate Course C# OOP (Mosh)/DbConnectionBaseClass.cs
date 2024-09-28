using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public abstract class DbConnectionBaseClass
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnectionBaseClass(string connectionString)
        {
            ConnectionString = connectionString;
            if (ConnectionString == null || ConnectionString.Length == 0)
            {
                    
            }
        }

        public abstract void Open();
        public abstract void Closed();
    }

    //Derived Classes the Sql Connection and Oracle Connection
    public class SqlConnection : DbConnectionBaseClass
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            connectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine("Opening Sql Connection.");
        }

        public override void Closed()
        {
            Console.WriteLine("Closing Sql Connection.");
        }


    }

    public class OracleConnection : DbConnectionBaseClass
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            connectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle Connection.");
        }

        public override void Closed()
        {
            Console.WriteLine("Closing Oracle Connection.");
        }
    }

    public class DbCommand : DbConnectionBaseClass
    {
        private string _instruction;
        public DbCommand(string connectionString, string instruction) : base (connectionString)
        {
            _instruction = instruction;
            if (_instruction == null || _instruction.Length == 0)
            {
                throw new NullReferenceException (nameof(_instruction));
            }
        }

        public override void Open()
        {
            if (ConnectionString.Contains("Sql"))
            {
                var sql = new SqlConnection(ConnectionString);
                sql.Open();
            }

            if (ConnectionString.Contains("Oracle"))
            {
                var oracle = new OracleConnection(ConnectionString);
                oracle.Open();
            }
        }

        public override void Closed()
        {
            if (ConnectionString.Contains("Sql"))
            {
                var sql = new SqlConnection(ConnectionString);
                sql.Closed();
            }

            if (ConnectionString.Contains("Oracle"))
            {
                var oracle = new OracleConnection(ConnectionString);
                oracle.Closed();
            }
        }

        public void Execute()
        {
            Open();
            Console.WriteLine(_instruction);
            Closed();
        }
    }
}
