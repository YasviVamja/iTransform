using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class StackException : Exception
    {
        public StackException(string message) : base(message) { }
    }
    internal class Assig3_3
    {
        public static void MainExecution()
        {
            MyStack stack = new MyStack(5);
            try
            {
                for (int i = 1; i <= stack.Size; i++)
                {
                    stack.Push(i);
                }

                MyStack clonedStack = (MyStack)stack.Clone();
                
                Console.WriteLine("Original stack:");
                //clonedStack.Push(6);
                while (!stack.IsEmpty())
                {
                    Console.WriteLine(stack.Pop());
                }

                Console.WriteLine("Cloned stack:");
                while (!clonedStack.IsEmpty())
                {
                    Console.WriteLine(clonedStack.Pop());
                }
                //clonedStack.Pop();
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
