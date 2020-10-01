using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Pattern_Prints
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; ++j)
                    Console.Write(j);

                for (k = 5 - i; k >= 1; k--)
                    Console.Write(" ");

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
