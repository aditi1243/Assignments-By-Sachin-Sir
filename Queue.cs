using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue1
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<string> Myqueue = new Queue<string>();
            Myqueue.Enqueue(2);
            Myqueue.Enqueue(4);
            Myqueue.Enqueue(6);
            Myqueue.Enqueue(8);

            Myqueue.Enqueue(10);

            Myqueue.Enqueue(12);

            Myqueue.Enqueue(14);

            Myqueue.Enqueue(16);
            Myqueue.Enqueue(18);

            Myqueue.Enqueue(20);





            Console.WriteLine("the topmost element of the stack is {0} ", Myqueue.Peek());

            foreach (int x in Myqueue)
            {
                Console.WriteLine("elements are in queue are" + x);


            }
            Console.WriteLine("Removing 6 pop oprations");
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("after 6 pop oprations");
            Console.WriteLine("the top ele of stack is{0}" + Myqueue.Peek());
            foreach (int x in Myqueue)
            {
                Console.WriteLine("elements are in queue are" + x);


            }
            Console.WriteLine("pushing here!!!!!");
            Myqueue.Enqueue(1);
            Console.WriteLine("removing 5 elements");
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            foreach (int x in Myqueue)
            {
                Console.WriteLine("elements are in queue are" + x);


            }
            Console.WriteLine("pushing here!!!!!");
            Myqueue.Enqueue(14);
            Myqueue.Enqueue(16);
            Myqueue.Enqueue(18);
            Myqueue.Enqueue(20);
            Myqueue.Enqueue(1);
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("pushing here!!!!!");
            Myqueue.Enqueue(14);
            Myqueue.Enqueue(16);
            Myqueue.Enqueue(18);
            Console.WriteLine("removing 3 elements");
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("pushing here!!!!!");
            Myqueue.Enqueue(14);
            Myqueue.Enqueue(16);
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            Console.WriteLine("the elements after popping" + Myqueue.Dequeue());
            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }



            Console.ReadKey();
        }
    }
}