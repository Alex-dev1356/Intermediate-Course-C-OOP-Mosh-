using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class DbMigratorComposition
    {
        //This Class is responsible for Migrating our database.

        //We need to create a private readonly field logger using the LoggerClassComposition Class
        //as the data type of the _logger field. This here we are using the Composition.
        private readonly LoggerClassComposition _logger;

        //Now we create a constructor, and a parameter of Type Logger,
        //and now we want to create an association to the Logger Class.
        public DbMigratorComposition(LoggerClassComposition logger)
        {
            _logger = logger;
        }

        //Now lets create a Method called Migrate
        public void Migrate()
        {
            //Here we need to do some logging so all we need to do is to call the
            //Log Method of the LoggerClassComposition. This is the example using the 
            //Composition because we are able to use the Log method from the LoggerClassComposition Class
            _logger.Log("We are migrating blah blah blah.......");
        }
    }
}
