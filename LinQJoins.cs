using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQJoins
{
    

        public class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeDesignation { get; set; }
            public string EmployeeName { get; set; }
            public int EmployeeSalary { get; set; }
        }

    class LinQ
    {

        static void Main(string[] args)
        {

            List<Employee> emp1 = new List<Employee>() {



            new Employee() { EmployeeID = 1, EmployeeName= "Aadi",  EmployeeSalary = 30000, EmployeeDesignation = "Associate" },
            new Employee() { EmployeeID = 2, EmployeeName= "Aditi",  EmployeeSalary = 20000, EmployeeDesignation = "HR" },
            new Employee () { EmployeeID = 3, EmployeeName = "Priscilla", EmployeeSalary = 45000, EmployeeDesignation= "Manager" },
            new Employee() { EmployeeID = 4, EmployeeName = "Aish", EmployeeSalary = 79000, EmployeeDesignation = "Software Engg." },
            new Employee() { EmployeeID = 5, EmployeeName = "Anu", EmployeeSalary = 85000, EmployeeDesignation = "Trainer" },


            };


              List<Employee> emp2 = new List<Employee>() { 

            new Employee() { EmployeeID = 2, EmployeeName= "ABC",  EmployeeSalary = 1000, EmployeeDesignation = "Associate1" },
            new Employee() { EmployeeID = 3, EmployeeName= "XYZ",  EmployeeSalary = 2000, EmployeeDesignation = "TechnicalManager" },
            new Employee () { EmployeeID = 4, EmployeeName = "PQR", EmployeeSalary = 3000, EmployeeDesignation= "HR" },
            new Employee() { EmployeeID = 5, EmployeeName = "LMN", EmployeeSalary = 7000, EmployeeDesignation = "Software Engg." },
            new Employee() { EmployeeID = 6, EmployeeName = "RST", EmployeeSalary = 5000, EmployeeDesignation = "Manager" },




            };

            var innerJoinQuery = from e1 in emp1
                                 join e2 in emp2
                                 on e1.EmployeeID equals e2.EmployeeID
                                 select new
                                 { EmployeeName = e1.EmployeeName, EmployeeDesignation = e2.EmployeeDesignation };

        

            foreach (var x in innerJoinQuery) 
            
            {
                Console.WriteLine("Employee {0} EmployeeDesignation{1}", x.EmployeeName, x.EmployeeDesignation);
            }
            Console.ReadKey();




        }
    }
}
