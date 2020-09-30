using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersBetweenrange
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.Write("\n\n");
            Console.Write("Display the numbers between 100 to 200:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            //Console.WriteLine("The first 10 natural number are:");

            for (i = 101; i < 200; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n\n");
            Console.ReadLine();



        }
    }
}
