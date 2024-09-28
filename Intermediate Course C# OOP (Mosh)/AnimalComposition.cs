using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class AnimalComposition
    {
        private int _age;

        public int SetAge(int age)
        {
            _age = age;
            return _age;
        }

        public void Eat(string eating)
        {
            Console.WriteLine(eating);
        }

        public void Sleep(string sleeping)
        {
            Console.WriteLine(sleeping);
        }
    }
}
