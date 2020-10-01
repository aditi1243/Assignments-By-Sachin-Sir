using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__pattern_printing_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, space = 1;
            for (i = 6; i >= 1; i--)
            {
                for (j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (j = i -1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
                space++;
            }
            Console.ReadLine();
        }
    }
}
