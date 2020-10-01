using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Prime_2_17_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 17; i++)
            {
                for (int j = 2; j <= 17; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
           

        }
    }

