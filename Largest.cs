using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int large = 0;
            //array declaration
            int[] arr = new int[5];

            //reading array elements 
            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //assigning first element to the array
            large = arr[0];
            //loop to compare value of large with other elements
            for (i = 1; i < arr.Length; i++)
            {
                //if large is smaller than other element
                //assig that element to the large
                if (large < arr[i])
                    large = arr[i];
            }
            //finally, we will have largest element, printing here
            Console.WriteLine("Largest element in array : " + large);
            Console.ReadKey();
        }
       
    }
    }
