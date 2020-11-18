using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorsINMvc.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }
        public ActionResult Index1()
        {
            throw new Exception("Something went wrong");
        }
    }
}