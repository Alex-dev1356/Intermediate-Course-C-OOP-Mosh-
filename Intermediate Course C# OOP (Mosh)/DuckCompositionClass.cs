using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class DuckCompositionClass
    {
        private readonly AnimalComposition _animal;
        private readonly SwimmableCompostionClass _swim;

        public DuckCompositionClass(AnimalComposition animal, SwimmableCompostionClass swim)
        {
            _animal = animal;
            _swim = swim;
        }

        public void DuckSwim()
        {
            _swim.Swimming("The duck is swimming at the current moment.");
        }

        public void DuckEat()
        {
            _animal.Eat("The duck is currently eating.");
        }

        public void DuckSleep()
        {
            _animal.Sleep("The duck is currently sleeping.");
        }
    }
}
