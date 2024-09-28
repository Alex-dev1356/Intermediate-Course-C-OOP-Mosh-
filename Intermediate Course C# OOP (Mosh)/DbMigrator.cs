using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        private readonly IShippingCalculator _shippingCalculator;

        //Now we want to change DB migrator to get an ILogger Interface. In order to do that
        //WE NEED TO CREATE A CONSTRUCTOR HERE AND INJECT THAT INTERFACE, this is called
        //"DEPENDENCY INJECTION". So we need a Private Field of type ILogger and an object
        //of Type ILogger inside a constructor. Dependency Injection Technique means we are
        //SPECIFYING THE DEPENDENCIES WHERE THIS DbMigrator class and later in the MAIN METHOD
        //We're going to SPECIFY A CONCRETE CLASS that IMPLEMENTS THAT INTERFACE.

        //public DbMigrator(ILogger logger, IShippingCalculator shippingCalculator)
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            ////Details of migrating the database.
            ////Here we want to display the time the migrating started and the time it is finished.
            ////We also want to log some messages on the console.
            //Console.WriteLine("Migration started at {0}", DateTime.Now);
            //Console.WriteLine("Migration finished at {0}", DateTime.Now);
            ////The problem with this implementation is if tomorrow we decide to use a file or a database
            ////instead of the console, we have to come back to this method and change it. W/c means this 
            ////class should be recompiled and re-deployed. IN THE REAL WORLD, WE WOULD LIKE TO DESIGN OR
            ////SUFFER SUCH THAT WE CAN CHANGE ITS BEHAVIOR W/O CHANGING ITS CODE. We can do this by using
            ////EXTENSIBILITY.

            //Instead of using the Console directly here, we should use an INTERFACE like Logger.
            //Now that we have an Interface, this Migrate Method will be talking to the Logger and not
            //directly to the console.
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
            //Now let's create a CONCRETE CLASS that IMPLEMENTS ILogger Interface. We will create ConsoleLogger Class
        }

        //Just Added this IShippingCalculator Interface for better understanding of the concept.
        public float Compute(InterfaceOrder order)
        {
            order.Shipment = new InterfaceShipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
            //var totalCost =  _shippingCalculator.CalculateShipping(order);
            return order.Shipment.Cost;
        }
        //public float Compute()
        //{
        //    var order = new InterfaceOrder{DatePlaced = DateTime.Now, TotalPrice = 300f };
        //    order.Shipment = new InterfaceShipment
        //    {
        //        Cost = _shippingCalculator.CalculateShipping(order),
        //        ShippingDate = DateTime.Today.AddDays(1)
        //    };
        //    return order.Shipment.Cost;
        //}
    }
}
