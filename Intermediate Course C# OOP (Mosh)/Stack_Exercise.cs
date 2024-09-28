using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class Stack_Exercise
    {
        private List<object> _stackList = new List<object>();
        public void Push(object obj)
        {
            var stacklist = _stackList;
            stacklist.Add(obj);
            if (stacklist[_stackList.Count - 1] == null)
            {
                throw new ArgumentNullException("You cannot put null value");
            }
        }

        public void Pop()
        {
            var countList = _stackList.Count;
            if (countList <= 0 || countList == null)
            {
                throw new Exception("The list is already empty.");
            }

            Console.WriteLine(_stackList[countList-1]);
            _stackList.RemoveAt(countList - 1);
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}
