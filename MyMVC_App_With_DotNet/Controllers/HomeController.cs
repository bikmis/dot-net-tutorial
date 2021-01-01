using MyMVC_App_With_DotNet.NameServiceReference;
using MyMVC_App_With_DotNet.TestServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC_App_With_DotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NameServiceClient nameService = new NameServiceClient();
            string name = nameService.GetName("Mike");
            ViewBag.Name = name;

            TestServiceClient testService = new TestServiceClient();
            var somethingSaid = testService.SaySomething("Hello There!");
            ViewBag.SomethingSaid = somethingSaid;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}