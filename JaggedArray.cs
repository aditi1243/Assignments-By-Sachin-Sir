using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            //its demonstration of 2-d array//the jagged array will be of 2-d array
            int[][] arr = new int[2][];//declared the array -Multi dimensional

            //making the above array into jagged
            arr[0] = new int[3];//initializing the value to the jagged array
            arr[1] = new int[5];

            int[][] Jaggedarray = new int[5][];
            Jaggedarray[0] = new int[3];
            Jaggedarray[1] = new int[5];
            Jaggedarray[2] = new int[7];
            Jaggedarray[3] = new int[9];
            Jaggedarray[4] = new int[11];

            //another way of assigning the values to jagged array

            Jaggedarray[0] = new int[] { 3, 5, 7, 9 };
            Jaggedarray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Jaggedarray[2] = new int[] { 1, 0, 4, 5, 8, 9, 6, 5, 4 };

            //Shorthand of jagged Array
            int[][] Jaggedarray1 =
            {new int[]{1,2,3,4,5 },
            new int[]{2,4,6,8,2, }
            Console.ReadKey();
        }
            }
        }
    
}
