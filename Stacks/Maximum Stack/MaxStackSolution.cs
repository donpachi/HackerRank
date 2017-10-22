using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Stack
{
    class MaxStackSolution
    {
        class MaxStack
        {
            private Stack<int> _maxStack;
            private Stack<int> _mainStack;

            public MaxStack()
            {
                _maxStack = new Stack<int>();
                _mainStack = new Stack<int>();
            }
            public void Push(int element)
            {
                _mainStack.Push(element);
                if (_maxStack.Count == 0)
                {
                    _maxStack.Push(element);
                }
                else if (element < _maxStack.Peek())
                {
                    _maxStack.Push(_maxStack.Peek());
                }
                else
                {
                    _maxStack.Push(element);
                }
            }

            public void Pop()
            {
                _mainStack.Pop();
                _maxStack.Pop();
            }

            public int Max()
            {
                return _maxStack.Peek();
            }
        }

        static void Main(String[] args)
        {
            int numQueries = Convert.ToInt32(Console.ReadLine());
            MaxStack stack = new MaxStack();
            for (int i = 0; i < numQueries; i++)
            {
                int[] query = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (query[0] == 1)
                    stack.Push(query[1]);
                else if (query[0] == 2)
                    stack.Pop();
                else if (query[0] == 3)
                    Console.WriteLine(stack.Max());
                else
                    throw new ArgumentException("Unexpected query type.");
            }
            Console.ReadKey();
        }
    }
}
