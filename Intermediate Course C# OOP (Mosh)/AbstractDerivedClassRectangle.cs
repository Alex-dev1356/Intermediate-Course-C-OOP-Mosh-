using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class AbstractDerivedClassRectangle : AbstractBaseClass
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
}
