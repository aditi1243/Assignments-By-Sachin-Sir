using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__eg2
{
   
        class lists
        {
            static void Main(string[] args)
            {
                var user = new List<int>();
                user.Add(1);
                user.Add(2);
                user.Add(3);
                user.Add(4);
                foreach (var x in user)
                {
                    Console.WriteLine("the elements are::" + x);
                }
                //Accessing Elements are using Index
                Console.WriteLine("the 1st index is::" + user[0]);
                Console.WriteLine("the 1st index is::" + user[1]);
                Console.WriteLine("the 1st index is::" + user[2]);
                Console.WriteLine("the 1st index is:;" + user[3]);

                //Insert the values
                user.Insert(4, 5);
                Console.WriteLine("inserted elements is" + user[4]);

                //contains//Return the Boolean value
                Console.WriteLine(user.Contains(2));

                //Remove
                Console.WriteLine(user.Remove(1));
                Console.ReadKey();

            }
        }
    }

