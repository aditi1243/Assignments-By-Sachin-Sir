using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S_DepositAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            string account;
            int choice;
            Console.WriteLine("Enter account number");
            account = Console.ReadLine();
            Account acc = new Account();
            acc.acc = account;
            do
            {

                Console.WriteLine("press 1 to deposit amount ");
                Console.WriteLine("press 2 to withdraw amount ");
                Console.WriteLine("press 3 to Account information ");
                Console.WriteLine("press 4 to Exit ");


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            acc.balance = acc.makedeposit(acc.balance);
                            Console.WriteLine(" Deposit Sucessfull");
                            Console.WriteLine("Bank balance = {0} \n", acc.balance);
                            break;
                        }
                    case 2:
                        {
                            acc.balance = acc.withdraw(acc.balance);
                            Console.WriteLine("Bank balance = {0} \n", acc.balance);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----- Account information----- ");
                            Console.WriteLine("Account Number = {0}", acc.acc);
                            Console.WriteLine("Bank balance = {0}\n", acc.balance);

                            break;
                        }
                    case 4:
                        {
                            break;
                        }

                }
            } while (choice < 4);

        }
    }
        public class Account
        {
            public string account;
            public int balance =0;

          

            public int makedeposit(int balance)
            {
                Console.WriteLine("Enter the deposit amount");
                int add = Convert.ToInt32(Console.ReadLine());
                balance = balance + add;
                return balance;
            }

            public int withdraw(int balance)
            {
                Console.WriteLine("Enter the withdraw amount");
                int add = Convert.ToInt32(Console.ReadLine());
                if (add > balance)
                {
                    Console.WriteLine("Not sufficeint balance");
                    return balance;
                }
                else
                {
                    Console.WriteLine("Amount withdrawn successfully");
                    return balance - add;
                }

            }
        }


        }
    
