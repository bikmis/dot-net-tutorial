using MyDataWithEF6.Implementations;
using MyDataWithEF6.Interfaces;
using MyMVCAppWithDotNet.HelloServiceReference;
using MyMVCAppWithDotNet.MathServiceAsmxReference;
using MyMVCAppWithDotNet.NameServiceReference;
using MyMVCAppWithDotNet.TestServiceReference;
using MyMVCAppWithDotNet.WriterServiceReference;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace MyMVC_App_With_DotNet.Controllers
{

    public class MathViewModel {
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public decimal DivideResult { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly string connectionString;
        private readonly IUnitOfWork unitOfWork;

        public HomeController() {
            connectionString = ConfigurationManager.ConnectionStrings["SchoolDb"].ToString();
            unitOfWork = new UnitOfWork(connectionString);
        }

        public ActionResult Index()
        {
            NameServiceClient nameService = new NameServiceClient();
            string name = nameService.GetName("Mike");
            ViewBag.Name = name;

            TestServiceClient testService = new TestServiceClient();
            var somethingSaid = testService.SaySomething("Hello There!");
            ViewBag.SomethingSaid = somethingSaid;

            MathServiceSoapClient mathServiceAsmx = new MathServiceSoapClient();
            ViewBag.MathServiceAsmx = mathServiceAsmx;
            var sum = mathServiceAsmx.Add(2, 3);
            ViewBag.Sum = sum;

            WriterServiceClient writerService = new WriterServiceClient();
            List<Book> books = writerService.GetBooks("Shakespeare").ToList();
            ViewBag.Books = books;

            HelloServiceClient helloService = new HelloServiceClient();
            var helloMessage = helloService.SayHello();
            ViewBag.HelloMessage = helloMessage;

            var students = unitOfWork.StudentRepository.GetAll().ToList();
            ViewBag.Students = students;

            var student = unitOfWork.RegisterStudent(1);

            return View();
        }

        public ActionResult Math(MathViewModel viewModel) {
          //  if (viewModel.Number2 != 0) {
                MathServiceSoapClient mathServiceAsmx = new MathServiceSoapClient();
                var divideResult = mathServiceAsmx.Divide((int)viewModel.Number1, (int)viewModel.Number2);
                viewModel.DivideResult = divideResult;
         //   }
            return View(viewModel);
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