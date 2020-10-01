using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 3, 7, 8, 9, 9 };
            int n = arr.Length;
            n = removeDuplicate(arr, n);
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + "");

            Console.ReadKey();
        }


            static int removeDuplicate(int[] arr, int n)
            {
                if (n == 0 || n == 1)
                    return n;

                int[] temp = new int[n];
                int j = 0;
                for (int i = 0; i < n - 1; i++)
                    if (arr[i] != arr[i + 1])
                        temp[j++] = arr[i];
                temp[j++] = arr[n - 1];
                for (int i = 0; i < j; i++)
                    arr[i] = temp[i];
                return j;

            }
           
         
    }
}
