using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    //We will implement the Interface ILogger here
    public class ConsoleLogger : ILogger, IShippingCalculator
    {
        //After the Implementation at the top (ConsoleLogger : ILogger) we need now to
        //IMPLEMENT the Methods inside the ILogger Interface
        public void LogError(string message)
        {
            //To chane the color of the font when we log it on the console we use this:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            //The value of the message variable here would be: "Migration started at " + DateTime.Now
            //The value of the message variable here would be: "Migration finished at " + DateTime.Now
            //We get this values from the DbMigrator Class earlier.
            //To chane the color of the font when we log it on the console we use this:
            Console.ForegroundColor = ConsoleColor.Green;
            //And now we call the Migrate Method of the DbMigrator.
            Console.WriteLine(message);
        }

        public float CalculateShipping(InterfaceOrder order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
