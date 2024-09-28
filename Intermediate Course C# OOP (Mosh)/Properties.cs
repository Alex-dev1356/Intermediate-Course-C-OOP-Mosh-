using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Properties
    {
        //Properties- are class member that ENCAPSULATES A SETTER AND A GETTER FOR ACCESSING A FIELD.
        //We need this Property TO CREATE A GETTER AND A SETTER WITH LESS LINE OF CODES.

        //Using an AUTO-IMPLEMENTED PROPERTY
        //public DateTime Birthdate { get; set; }

        //----------------------------------------------------------------------------------------------------------

        //Using the AUTO-IMPLEMENTED PROPERTY WITH PRIVATE MODIFIER ON THE SET Method for us to be able
        //TO SET THE Birthdate Field ONLY ONCE.
        public DateTime Birthdate { get; private set; }

        //With this AUTO-IMPLEMENTED PROPERTY WITH PRIVATE MODIFIER ON THE SET Method we need to 
        //set the Birthdate to the constructor
        public Properties(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //------------------------------------------------------------------------------------------------------------
        
        //Creating another property, but this time it has a LOGIC ON IT.
        public int Age 
        { 
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

    }
}
