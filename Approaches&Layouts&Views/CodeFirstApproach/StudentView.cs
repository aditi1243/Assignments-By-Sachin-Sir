using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class StudentView
    {
        public List<Student> getAllRecord()
        {
            StudentContext obj = new StudentContext();
            return obj.Students.ToList();
        }
    }
}