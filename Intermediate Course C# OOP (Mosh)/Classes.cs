using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class Classes
    {
        //Defining a field
        public string Name;

        //Defining a Method - in defining a method first is the ACCESS MODIFIER, 
        //second would be the RETURN TYPE and lastly the METHOD NAME
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'am {1}", to, Name);
        }

        //-----------------------------SECOND PART----------------------------------------------
        //The Parse Method to create a classes object and as well show an example of 
        //using STATIC Property
        public static Classes Parse(string str)
        {
            //Here we need to create a Classes object nd set the Name Field based on the str argument.
            //The return type is at Type Class since we use the Classes Class as the return type of this
            //Parse Method
            var classes = new Classes();
            classes.Name = str;
            return classes;
        }
    }
}
