using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCSharp
{
    class FactoryMethod
    {
        static void Main(string[] args)  //We haven't told to the Client program that we are creating the object of Teacher Class or Student Class
        {
            Console.WriteLine("Enter Your Object Type");
            string type = Console.ReadLine();//The value entered by user should get store under type variable
            I1 obj =CreateObj.getObject(type); //I1 will get refernce of which class to call
            Console.WriteLine(obj.getfname()); //Creating Object through common interface
            Console.ReadLine();


        }

    }
    class CreateObj          //This is a Factory and here we are creating objects
    {
        public static I1 getObject(string typeofobj)//This getObject will returns the objects of Teacher Class and Student Class
        {
            I1 obj = null;
            if(typeofobj.ToLower()=="student")
            {
                obj = new Student(); //If condition true the our obj should get initialized with Student Class
            }
            else
            {
                obj = new Teacher();
            }
            return obj;
        }
    }

    interface I1 //in interface only methods declaration can be done no defintion can be written
    {
        string getname();
        string getfname();
    }
    class Teacher : I1  //Classes Defined
    {
        public string getname()  //Declaration of methods
        {
            return "Teacher's Name";
        }
        public string getfname()
        {
            return "Teacher's Father Name";
        }
    }
    class Student : I1
    {
        public string getname()
        {
            return "Student's Name";
        }
        public string getfname()
        {
            return "Student's Father Name";
        }
    }
}
