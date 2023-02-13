using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
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
    internal class Assig3_2
    {
        public static void MainExecution()
        {
            try
            {
                MyStack stack = new MyStack(3);
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
               // stack.Push(4);

                MyStack clonedStack = (MyStack)stack.Clone();

                Console.WriteLine("Original Stack: ");
                for (int i = 0; i < stack.Size; i++)
                    Console.WriteLine(stack.stackArray[i]);

                Console.WriteLine("\nCloned Stack: ");
                for (int i = 0; i < clonedStack.Size; i++)
                    Console.WriteLine(clonedStack.stackArray[i]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
