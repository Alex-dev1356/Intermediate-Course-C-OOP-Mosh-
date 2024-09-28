using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class MethodOverridingDerivedClassCircle : MethodOverridingBaseClass
    {
        //Here since we inherit from MethodOverridingBaseClass and we want to override
        //the Draw Method
        public override void Draw()
        {
            ////YOU CAN PUT ANY CODE SPECIFIC TO THE CIRCLE CLASS ITSELF and then
            ////pass the implementation BEFORE OR AFTER to the base.Draw(), but since
            ////base.Draw() is an empty method we don't really need it here for our
            ////example.

            ////by default once you override the Draw Method, VS by default put this 
            ////base.Draw() here, because we are inheriting it to our Base Class.
            //base.Draw();

            Console.WriteLine("Draw a circle");
        }

    }

    public class MethodOverridingDerivedClassRectangle : MethodOverridingBaseClass
    {
        public override void Draw()
        {
            ////we don't need this base.Draw() for now so let's just remove it.
            //base.Draw();

            Console.WriteLine("Draw a rectangle");
        }
    }

    //Creating a new class for Triangle w/o affecting other classes, this is possible through the use
    //of POLYMORPHISM
    public class MethodOverridingDerivedClassTriangle : MethodOverridingBaseClass
    {
        public override void Draw()
        {
            //base.Draw();

            Console.WriteLine("Draw a triangle.");
        }
    }

    public class MethodOverridingBaseClass
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //This ShapeType Class is a Enum of different shapes(Ex. Circle, Rectangle)
        public ShapeType Type { get; set; }

        //Using the Method Overriding here on the Draw Method by declaring it to be
        //"virtual", once MethodOverridingBaseClass is inherited by Circle and Rectangle
        //Class you can override the Draw Method but if you will not override it, the
        //default implementation of the Draw Method will be implemented.
        public virtual void Draw()
        {

        }
    }
}
