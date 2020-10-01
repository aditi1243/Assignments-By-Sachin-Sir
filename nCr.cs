using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, ncr;
            Console.WriteLine("enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of r");
            r = Convert.ToInt32(Console.ReadLine());
            ncr = (fact(n) / (fact(n - r) * fact(r)));
            Console.WriteLine("the output: {0}", ncr);
            Console.ReadLine();
        }

        static int fact(int num)
        {
            int i = 1, fact = 1;

            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}
