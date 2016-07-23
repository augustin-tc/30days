using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day18
{
    class Solution
    {
        Stack<char> stack;
        Queue<char> queue;
        public Solution()
        {
            stack = new Stack<char>();
            queue = new Queue<char>();
        }
       
        internal void pushCharacter(char c)
        {
            stack.Push(c);
        }

        internal void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        internal char popCharacter()
        {
            return stack.Pop();
        }

        internal char dequeueCharacter()
        {
            return queue.Dequeue();
        }
    }
}
