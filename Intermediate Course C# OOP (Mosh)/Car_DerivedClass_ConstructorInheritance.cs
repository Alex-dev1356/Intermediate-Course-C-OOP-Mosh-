using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{    


    public class Car_DerivedClass_ConstructorInheritance : Vehicle_BaseClass_ConstructorInheritance
    {

        //example using a contructor that has no parameter
        public void car_derivedclass_constructorinheritance()
        {
            Console.WriteLine("car is being initialized.");
        }

        ////For this example, we can see that the Constructor FROM the Base Class CANNOT be inherited
        ////by the Derived Class.
        //public Car_DerivedClass_ConstructorInheritance(string registrationNumber)
        //{
        //    _registrationNumber = registrationNumber;
        //}

        ////If we want to inherit the Base Class Constructor we need to Redefine our Constructor here.
        ////We redefine our code by using the Base Keyword
        //public Car_DerivedClass_ConstructorInheritance(string registrationNumber)
        //    : base(registrationNumber)
        //{
        //    Console.WriteLine("Car is being initialized.{0}", registrationNumber);
        //}
    }
}
