using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class InstallerClassComposition
    {
        //Same on what we did on the DbMigratorComposition Class, we will create a
        //constructor, then the private field with the LoggerClassComposition Class as
        //the data type

        private readonly LoggerClassComposition _logger;
        public InstallerClassComposition(LoggerClassComposition logger)
        {
           _logger = logger;
        }

        //Now we can implement the methods of the LoggerClassComposition Class on the
        //Methods that we will be creating on this Class.
        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
