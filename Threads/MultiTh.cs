
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace MultiThreading
{
    class Program
    {
        public string Thread1(string str)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread1 at position " + i);
            }
            return str;
        }

        public string Thread2(string strr)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Thread2 at position " + i);
                Console.WriteLine("Thread 2 ended here");
            }
            return strr;
        }

       public int Thread3(int x,int y)
        {
            Console.WriteLine("This is Thread3 ");
            Console.WriteLine("The sum is {0}", (x + y));
            Console.WriteLine("Thread 3 ended");
            return x + y;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            Thread T1 = new Thread(() => obj.Thread1("Thread1 ends here"));

            Thread T2 = new Thread(() => obj.Thread2("Thread2 executed"));

            Thread T3 = new Thread(() => obj.Thread3(20, 40));

            T1.Start(); T2.Start(); T3.Start();

            Console.ReadKey();
        }
    }
}