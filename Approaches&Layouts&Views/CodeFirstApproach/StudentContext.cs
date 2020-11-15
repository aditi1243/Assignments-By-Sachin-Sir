using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data.Entity;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Models
{
    public class StudentContext :DbContext
    {
        public DbSet<Student> Students { get; set; }



    }
}