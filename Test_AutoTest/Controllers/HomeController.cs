using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test_AutoTest.Common;
using Test_AutoTest.Models;
using Test_AutoTest.Services;

namespace Test_AutoTest.Controllers
{
    public class HomeController : Controller
    {
        IRepository _rep;

        public HomeController(IRepository repository)
        {
            _rep = repository;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Test_AutoTest";
            ViewBag.Users = _rep.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Test"] = "Приложение для тестирования";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
