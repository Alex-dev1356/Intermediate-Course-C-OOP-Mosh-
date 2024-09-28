using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public interface IReplicatedLogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }

    public class ReplicatedDbMigrator
    {
        private readonly IReplicatedLogger _logger;

        //Dependency Injection
        public ReplicatedDbMigrator(IReplicatedLogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started " + DateTime.Now);
            _logger.LogInfo("Migration finished " + DateTime.Now);
            _logger.LogError("There was an error encountered : " + DateTime.Now);
        }
    }

    //Now we will create a class that will implement the IReplicatedLogger
    public class ReplicatedConsoleLogger : IReplicatedLogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("ERROR : " + message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("INFO : " + message);
        }

        //Now we are ready to call the Migrate Method on the Main Method.
    }
}
