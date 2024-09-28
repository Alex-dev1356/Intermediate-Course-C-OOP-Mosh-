using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public abstract class AbstractBaseClass
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //Declaring an Abstract Memeber or Method
        public abstract void Draw();

        //Declaring common methods
        public void Copy()
        {
            Console.WriteLine("Copy shape into the clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
