using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Stack_Exercise__Inheritance_
{
    public class StackBaseClassExercise
    {
        private readonly List<object> _stackList = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null object to stack");

            _stackList.Add(obj);
        }

        public object Pop()
        {
            if(_stackList.Count() == 0)
                throw new InvalidOperationException("Stack is empty");

            var lastItem = _stackList[_stackList.Count() - 1];
            Console.WriteLine(String.Format("This is the item that has been removed from the Stack List: {0}",lastItem));
            _stackList.RemoveAt(_stackList.Count() - 1);
            return lastItem;
        }

        public void Clear()
        {
            _stackList.Clear();
            Console.WriteLine($"The Stack List has been cleared successfully.");
        }

        public List<object> GetList()
        {
            return _stackList;
        }
    }
}
