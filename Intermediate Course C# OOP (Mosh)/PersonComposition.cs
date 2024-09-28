using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class PersonComposition
    {
        private readonly AnimalComposition _animal;
        private readonly WalkableClassComposittion_cs _walk;
        public PersonComposition(AnimalComposition animal, WalkableClassComposittion_cs walk)
        {
            _animal = animal;
            _walk = walk;
        }

        public void SetAge(int age)
        {
            Console.WriteLine("The person's age is {0}.",_animal.SetAge(age));

        }

        public void PersonEating()  
        {
            _animal.Eat("The person is currently eating.");
        }

        public void PersonSleeping()
        {
            _animal.Sleep("The person is currently sleeping.");
        }

        public void PersonWalking()
        {
            _walk.Walk("The person is currently walking.");
        }
    }
}
