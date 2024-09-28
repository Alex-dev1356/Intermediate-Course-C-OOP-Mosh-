using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Fields
    {
        //Declaring fields
        public int Id;
        public string Name;

        ////The best way to initialize the Orders Field is with this, without the need to create a constructor:
        //public List<Order> Orders = new List<Order>();

        //Now this is the example of the READ ONLY FIELDS:
        //NOTE: We use this readonly modifier TO MAKE SURE THAT THE FIELDS IS ONLY ASSIGNED ONCE.The reason we
        //do this is TO CREATE A SAFETY TO OUR APPLICATION, TO IMPROVE THE ROBUSTNESS OF THE CODE.Through this
        //we could avoid the re-initialization of this Orders field ACCIDENTALLY AND THE DATA THAT IS FIRST 
        //STORED IN THE ORDERS LIST TO BE LOST.
        public readonly List<Order> Orders = new List<Order>();

        //Creating Constructor for the fields
        public Fields(int id)
        {
            this.Id = id;
        }

        public Fields(int id, string name)
            //Here we DID NOT USE THE 'this' KEYWORD. BECAUSE IT IS NOT A GOOD PRACTICE.
        {
            this.Id= id;
            this.Name = name;
        }

        //Lets Create another Method which is Promote and just leave the implementation here
        public void Promote()
        {
            ////If I accidentally re-enitialize the Orders List here, then all the data first stored
            ////in the Orders List WILL BE LOST. That is the reason why we use 'readonly' modifier at
            ////the first declaration at the TOP.
            //Orders = new List<Order>();

        }
    }
}
