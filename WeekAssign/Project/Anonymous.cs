using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    public delegate int AddNumDelegate(int n);
    public delegate int MultNumDelegate(int n);

    class Program
    {
        //Main Function

        static void Main(string[] args)
        {
            //********Instantiating the Delegate***********

            AddNumDelegate nc1 = delegate (int n)//Return type----Anonymous----Unamed
            {
                num += n;
                return num;
            };
            int result = nc1.Invoke(45);//Delegate in my method----new variable to store my value
            Console.WriteLine(result);

            MultNumDelegate nc2 = delegate (int n)
            {
                num *= n;
                return num;
            };
            int result1 = nc2.Invoke(45);
            Console.WriteLine(result);


        }

    }
}