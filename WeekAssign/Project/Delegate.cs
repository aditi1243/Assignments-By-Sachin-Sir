using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate int AddNumDelegate(int n);
public delegate int MultNumDelegate(int n);
namespace DelegateAppl
{

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int n)
        {
            num += n;
            return num;
        }
        public static int MultNum(int n)
        {
            num *= n;
            return num;
        }
        
        static void Main(string[] args)
        {
            //create delegate instances
            AddNumDelegate nc1 = new AddNumDelegate(AddNum);
            {
                int result = nc1.Invoke(45);//Delegate in my method----new variable to store my value
                Console.WriteLine(result);
            }

            MultNumDelegate nc2 = new MultNumDelegate(MultNum);
            {
                int result1 = nc2.Invoke(45);//Delegate in my method----new variable to store my value
                Console.WriteLine(result1);
            }
            

           Console.ReadKey();
        }
    }
}