using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Methods
    {
        ////Using this Method WITHOUT THE PARAMS MODIFIER
        //public int Add(int[] numbers)
        //{
        //    return numbers[0];
        //}

        //Using this Method WITHV PARAMS MODIFIER
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
