using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    ID = 101,
                    Email="abc@gmail.com",
                    Name="Aditi"
                    
                },
                 new Employee()
                {
                    ID = 102,
                    Email="asr@gmail.com",
                    Name="Arti"

                },
                  new Employee()
                {
                    ID = 103,
                    Email="ssdf@gmail.com",
                    Name="Jacklin"

                },
                   new Employee()
                {
                    ID = 104,
                    Email="abc123@gmail.com",
                    Name="Akansha"

                }
             };
            return View(emp);
        }
    }
}