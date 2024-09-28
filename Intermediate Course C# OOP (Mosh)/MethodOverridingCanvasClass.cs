using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class MethodOverridingCanvasClass
    {
        //Here we have a method that has a parameter of List Type Base Class, meaning 
        //all the items that will be stored inside the shapes list will be of type
        //Base Class, means that we it could be an object instantiated from the derrived
        //class like Circle and Rectangle.
        public void DrawShapes(List<MethodOverridingBaseClass> shapes)
        {
            //Here we will iterate over the shapes list, and what we may have is a circle 
            //in the first element or a rectangle in the second element of this list
            foreach (var shape in shapes)
            {
                //Here it could be MethodOverridingDerivedClassCircle.Draw() or 
                //MethodOverridingDerivedClassRectangle.Draw() will be called.
                //This is the concept of POLYMORPHISM, Poly meaning MANY and Morph  meaning
                // FORMS, MANY FORMS that's what Polymorphism means.

                shape.Draw();
            }

        }
    }
}
