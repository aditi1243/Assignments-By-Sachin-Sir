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

        static object _lock = new object();

        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Monitor.Enter(_lock);//Monitor Class provides a mechanism that synchronizes access to objects
                try                 //Enter keyword allows only one thread to acquire Exclusive lock  
                {
                    Total++;
                }
                finally//To throws the exception we used this keyword
                {
                    Monitor.Exit(_lock);//Exclusive lock is released
                }
            }
        }
    }
}
    