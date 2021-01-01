using MyMVC_App_With_DotNet.MathServiceReference;
using MyMVC_App_With_DotNet.NameServiceReference;
using MyMVC_App_With_DotNet.TestServiceReference;
using MyMVC_App_With_DotNet.WriterServiceReference;
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

            MathServiceSoapClient mathService = new MathServiceSoapClient();
            var sum = mathService.Add(2, 3);
            ViewBag.Sum = sum;

            WriterServiceClient writerService = new WriterServiceClient();
            List<Book> books = writerService.GetBooks("Shakespeare").ToList();
            ViewBag.Books = books;

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