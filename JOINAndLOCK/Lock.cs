using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lock
{
    class Program
    {
        static int Total = 0;

        static void Main(string[] args)
        {
            Thread T1 = new Thread(Program.AddOneMillion);
            Thread T2 = new Thread(Program.AddOneMillion);
            Thread T3 = new Thread(Program.AddOneMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total = " + Total);
            Console.ReadKey();


        }

        static object _lock = new object();//To avoid inconsistency we used Locking

        public static void AddOneMillion()
        {
            for (int i = 1; i<=1000000; i++)
            {
                lock(_lock)//With the help of this lock only one thread can enter and will get executed
                {
                    Total++;
                }
            }
        }
    }
}
