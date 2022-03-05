using System;
using System.Collections.Generic;

namespace Stack_Exercise
{
    public interface IStackTask
    {
        void Push(object obj);
        object Pop();
    }

    public class Stack : IStackTask
    {
        private readonly List<object> _lists;
        public Stack()
        {
            _lists = new List<object>();
        }

        public object Pop()
        {
            if (_lists.Count == 0)
                throw new InvalidOperationException("The Count List Is Empty");

            var index = _lists.Count - 1;
            var toReturn = _lists[index];
            _lists.RemoveAt(index);
            return toReturn;
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                _lists.Add(obj);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var min = 1;
            var max = 5;

            for (int i = min; i <= max; i++)
            {
                stack.Push(i);
            }

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
