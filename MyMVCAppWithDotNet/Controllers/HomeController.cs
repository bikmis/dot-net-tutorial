using MyDataWithEF6.Implementations;
using MyDataWithEF6.Interfaces;
using MyMVCAppWithDotNet.HelloServiceReference;
using MyMVCAppWithDotNet.MathServiceAsmxReference;
using MyMVCAppWithDotNet.MathServiceWcfReference;
using MyMVCAppWithDotNet.Models;
using MyMVCAppWithDotNet.NameServiceReference;
using MyMVCAppWithDotNet.TestServiceReference;
using MyMVCAppWithDotNet.WriterServiceReference;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Web.Mvc;

namespace MyMVCAppWithDotNet.Controllers
{
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

        public ActionResult MathAsmx(MathViewModel viewModel, string button) {
            if (button == "Clear") {
                ModelState.Clear();
                viewModel = new MathViewModel();
            }

            if (!string.IsNullOrEmpty(viewModel.Number2)) {
                MathServiceSoapClient mathServiceAsmx = new MathServiceSoapClient();
                var divideResult = mathServiceAsmx.Divide(Convert.ToDecimal(viewModel.Number1), Convert.ToDecimal(viewModel.Number2));
                viewModel.DivideResult = divideResult.ToString();
            }
            return View(viewModel);
        }

        public ActionResult MathWcf(MathViewModel viewModel, string button)
        {
            if (button == "Clear")
            {
                ModelState.Clear();
                viewModel = new MathViewModel();
                return View(viewModel);
            }

            try
            {
                if (viewModel.Number2 != null)
                {
                    MathServiceClient mathServiceClient = new MathServiceClient();
                    var divideResult = mathServiceClient.Divide(Convert.ToDecimal(viewModel.Number1), Convert.ToDecimal(viewModel.Number2));
                    viewModel.DivideResult = divideResult.ToString();
                }
            }
            catch (FaultException<Error> ex)
            {
                ViewBag.error = ex.Detail.ErrorMessage;
            }
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