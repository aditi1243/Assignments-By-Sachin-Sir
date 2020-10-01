using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n,d;
            Console.WriteLine("Enter the value of n :");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                d = i * i * i;
                Console.WriteLine("{0}",d);
                Console.WriteLine(" \n ");
            }
            Console.ReadKey();
        }
    }
}
