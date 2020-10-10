using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DeadLock
{
    public class Account
    {
        double _balance; int _id;

        public Account(int id, double balance)//Constructor for initializing the above declared fields

        {
            this._id = id;
            this._balance = balance;
        }

        public int ID
        {
            get
            {
                return _id;//Returns Account ID
            }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }

    public class AccountManager//Responsible for transferring the money between two accounts
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)//Constructor
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;

        }

        public void Transfer()//Withdrawing and Depositing
        {
            Console.WriteLine(Thread.CurrentThread.Name + "trying to acquire lock on " +  _fromAccount.ID.ToString());//Reterive the name of current thread
            lock (_fromAccount)//Locking the Account
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + _fromAccount.ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "suspended for 1 sec");//Going to sleep for 1 sec
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in the action and trying to acquire lock on " + _toAccount.ID.ToString());
                lock (_toAccount)//Locking the Account---Deadlock Occured here
                {
                    Console.WriteLine("this code will not be executed");//Will never be executed because deadlock has ovcured
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Withdraw(_amountToTransfer);

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);//Instantiating 
            Account accountB = new Account(102, 3000);//Instantiating

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);//Class instantiating
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";//Providing Name to a thread


            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerA.Transfer);
            T2.Name = "T2";

            T1.Start();//Calling threads
            T2.Start();//Calling threads

            T1.Join();//Join() method which allows one thread to wait until another thread completes its execution.
            T2.Join();
            Console.WriteLine("Main Completed");//Will never executed because the threads are under Deadlock

        }
    }
}
