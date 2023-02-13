using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class StackException : Exception
    {
        public StackException(string message) : base(message) { }
    }
    public class MyStack : ICloneable
    {
        public int[] stackArray;
        private int top;
        private int size;
        public int Top { get; set; }
        public int Size { get { return size; } }

        public MyStack(int size)
        {
            this.size = size;
            stackArray = new int[size];
            top = -1;
        }

        public void Push(int item)
        {
            if (top == size - 1)
                throw new StackException("Stack is full!");
            else
                stackArray[++top] = item;
        }

        public int Pop()
        {
            if (top == -1)
                throw new StackException("Stack is empty!");
            else
                return stackArray[top--];
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public bool IsFull()
        {
            return top == size - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
    internal class Assig4_1
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
