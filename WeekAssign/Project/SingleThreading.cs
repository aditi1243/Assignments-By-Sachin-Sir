using System;
using System.Threading;

public class SingleT
{

     
    public static void method1()
    {

     
        for (int I = 0; I <= 10; I++)
        {

            Console.WriteLine("Method1 is : {0}", I);

            if (I == 5)
            {
                Thread.Sleep(6000);
            }
        }
    }

 
    public static void method2()
    {

 
        for (int J = 0; J <= 10; J++)
        {

            Console.WriteLine("Method2 is : {0}", J);
        }
    }
}

 
public class Single
{

   
    static public void Main()
    {

        
        SingleT.method1();
        SingleT.method2();
    }
}