﻿using HelloServiceReference;
using MathService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCoreApp.Models;
using NameServiceReference;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WriterServiceReference;

namespace MyCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MathServiceSoapClient mathService = new MathServiceSoapClient(MathServiceSoapClient.EndpointConfiguration.MathServiceSoap);
            var sum = mathService.Add(1, 3);
            ViewBag.Sum = sum;

            NameServiceClient nameService = new NameServiceClient();
            FullName fullName = nameService.GetFullName("Michael", "Jackson");
            ViewBag.FullName = fullName;

            WriterServiceClient writerService = new WriterServiceClient();
            var books = writerService.GetBooks("Shakespeare");
            ViewBag.books = books;

            HelloServiceClient helloService = new HelloServiceClient();
            var helloMessage = helloService.SayHello();
            ViewBag.HelloMessage = helloMessage;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
