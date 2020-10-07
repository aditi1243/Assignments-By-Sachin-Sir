using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgnOnLinq
{
    public class Program
    {
        static void Main(string[] args)
        {

            IList<Employee> employeeList = new List<Employee>() {



            new Employee() { EmployeeID = 1, EmployeeName= "Aadi",  EmployeeSalary = 30000, EmployeeDesignation = "Associate" },
            new Employee() { EmployeeID = 2, EmployeeName= "Aditi",  EmployeeSalary = 20000, EmployeeDesignation = "HR" },
            new Employee () { EmployeeID = 3, EmployeeName = "Priscilla", EmployeeSalary = 45000, EmployeeDesignation= "Manager" },
            new Employee() { EmployeeID = 4, EmployeeName = "Aish", EmployeeSalary = 79000, EmployeeDesignation = "Software Engg." },
            new Employee() { EmployeeID = 5, EmployeeName = "Anu", EmployeeSalary = 85000, EmployeeDesignation = "Trainer" },

            };

            var name = employeeList.Where(e => e.EmployeeSalary > 20000).Select(e => e).Where(e => e.EmployeeID > 1).Select(e => e.EmployeeName);

            var name1 = employeeList.Where(e => e.EmployeeDesignation == "HR").Select(e => e).Where(e => e.EmployeeID > 3).Select(e => e.EmployeeID);

            var name2 = from e in employeeList
                        where e.EmployeeID > 1 && e.EmployeeID < 4
                        select new { e.EmployeeName };

            //--------------Sorting the names--------------using GroupBy clause

            var group = from e in employeeList
                        group e by e.EmployeeName into em
                        orderby em.Key
                        select new { em.Key, em };




            foreach (var x in name)//Priscilla,Aish,Anu
            {
                Console.WriteLine(x);
            }
            foreach (var y in name1)
            {
                Console.WriteLine(y);//Aditi,Priscilla
            }
            foreach (var z in name2)
            {
                Console.WriteLine(z);//Aadi,Aditi,Aish,Anu,Priscilla
            }
            foreach (var a in group)
            {
                Console.WriteLine("EmpName{0}", a.Key);
            }
            Console.ReadKey();
        }






        public class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeDesignation { get; set; }
            public string EmployeeName { get; set; }
            public int EmployeeSalary { get; set; }
        }
    }
}
    








