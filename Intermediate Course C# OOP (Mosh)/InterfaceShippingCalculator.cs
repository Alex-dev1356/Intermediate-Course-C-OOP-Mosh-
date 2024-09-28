using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public interface IShippingCalculator
    {
        //Here we have one Method (By default it is abstract, because it has no implementation and only 
        //declared) the implementation will be depending on the class where this Interface will be IMPLEMENTED.
        float CalculateShipping(InterfaceOrder order);
    }

    public class InterfaceShippingCalculator : IShippingCalculator
    {
        //Since InterfaceShippingCalculator Class Implements the IShippingCalculator Interface, it is 
        //MANDATORY TO OVERRIDE OR IMPLEMENT the CalculateShipping Method
        public float CalculateShipping(InterfaceOrder order)
        {
            if (order.TotalPrice > 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
