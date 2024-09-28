using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Point
    {
        public int X;
        public int Y;

        //Creating Constructors to initialize this fields
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Here we will Create a Method to Move this points into different location
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Overloading the Move Method
        public void Move(Point newLocation)
        {
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            //For best practices, for us to not redanduntly assign this.X and this.Y to newLocation.X
            //and newLocation.Y we will instead use this one.
            //Here we will use this defensive programming to make this class in A VALID STATE
            if(newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X,newLocation.Y);
        }
    }
}
