using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_Yr.AndDate1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, next, num_digits;
            int[] a = new int[10];
            string[] words = {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
         };
            Console.WriteLine("Enter the value: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number: " + value);
            Console.Write("Number (words): ");
            next = 0;
            num_digits = 0;
            do
            {
                next = value % 10;
                a[num_digits] = next;
                num_digits++;
                value = value / 10;
            } while (value > 0);
            num_digits--;
            for (; num_digits >= 0; num_digits--)
                Console.Write(words[a[num_digits]] + " ");
            Console.ReadLine();

        }
    }
}
