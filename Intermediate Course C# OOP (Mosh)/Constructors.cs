using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class Constructors
    {
        //Note: WE DO NOT SET FIELDS WITH ACCESS MODIFIERS THAT IS SET TO PUBLIC
        public int Id;
        public string Name;
        //Here we want to create a List of Order so we use the List Class
        //Note that data type Order(from Order Class) is a Generic parameter and is 
        //declared from System.C
        public List<Order> Orders;

        public Constructors()
        {
            //RULE OF THUMB OR BEST PRACTICE: Whenever you have a Class (Connstructors) that has
            //a List of object OF ANY TYPE (List<Order>), ALWAYS INITIALIZE THAT LIST TO AN EMPTY LIST.

            Orders = new List<Order>(); 

            //Now after initializing the Orders Field here in the default constructor which is the 
            //Constructor that has no parameters, when the user use the other constructors we also need
            //to initialize the Orders Field, and the best way to do that is by using the "this" keyword
            //on each of the other constructors.
        }

        //Here we declare an Constructor and a shortcut for that is the code snippet 'ctor'

        //METHOD OVERLOADING - meaning SAME NAME OF CONSTRUCTORS BUT DIFFERENT SIGNATURES (Number of parameters in
        //the Constructor, Data type of the parameters and also their order inside the Customer Parameter). We use
        //Method Overloading for easier initialization of the Class EASIER.
        public Constructors(int id)
            //by using this 'this' keyword, before this Constructors(int id) code will be read, it will first read the
            //DEFAULT CONSTRUCTOR and execute the INITIALIZATION OF THE Orders Field, before executing the this.Id = id;
            : this()
        {
            this.Id = id;
        }
        public Constructors(int id, string name)
            //Same goes here, before the code inside this constructor is executed it will first execute the Constructor
            //that has an id parameter, but since it has a 'this' keyword it will first call and execute the default 
            //Constructor that has no parameter and will execute the initialization of Orders Field that will then
            //be passed to Constructor w/ id paramter and then execute this.Id = id, and then finally execute the 
            //this.Name = name
            : this(id)
        {
            ////since we used the 'this' keyword here, we can now remove the this.Id = id
            //this.Id = id;
            this.Name = name;
        }
        //Now back to the Program Class.

        


    }
}
