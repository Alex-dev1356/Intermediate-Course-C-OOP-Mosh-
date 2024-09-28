using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //Naming Convention: METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new InterfaceOrderProcessor(IShippi);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {

    }
}
