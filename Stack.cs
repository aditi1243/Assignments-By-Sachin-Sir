using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Stack<int> MyStack = new Stack<int>();
        MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Push(10);
            MyStack.Push(12);
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            MyStack.Push(20);
            Console.WriteLine("the topmost element of the stack is {0} ", MyStack.Peek());

            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
    Console.WriteLine("Removing 6 pop oprations");
            Console.WriteLine("the elements after popping" + MyStack.Pop()); 
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("after 6 pop oprations");
            Console.WriteLine("the top ele of stack is{0}" + MyStack.Peek());
            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
Console.WriteLine("pushing here!!!!!");
            MyStack.Push(1);
            Console.WriteLine("removing 5 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            MyStack.Push(20);
            MyStack.Push(1);
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            Console.WriteLine("removing 3 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push(14);
            MyStack.Push(16);
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }

            // Console.WriteLine(MyStack.Contains(2));
            Console.ReadKey();

        }
    }
}

    

