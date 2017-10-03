using DependencyInjectionUnity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionUnity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyProvider myProvider;

        public HomeController(IMyProvider provider)
        {
            myProvider = provider;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = myProvider.GetMessage();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}