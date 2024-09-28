using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class DogComposition
    {
        private readonly AnimalComposition _animal;
        private readonly WalkableClassComposittion_cs _walk;
        
        public DogComposition(AnimalComposition animal, WalkableClassComposittion_cs walk)
        {
            _animal = animal;
            _walk = walk;
        }

        public void SetAge(int age)
        {
            Console.WriteLine("The dog's age is {0}.", _animal.SetAge(age));
        }
        public void DogEat()
        {
            _animal.Eat("The dog is currently eating.");
        }
        public void DogSleep()
        {
            _animal.Sleep("The dog is currently sleeping.");
        }

        public void DogWalk()
        {
            _walk.Walk("The dog is walking.");
        }
    }
}
