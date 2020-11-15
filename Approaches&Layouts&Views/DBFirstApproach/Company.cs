using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DBFirstApproach.Models;

namespace DBFirstApproach.Models
{
    public class Company
    {
      
      
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}