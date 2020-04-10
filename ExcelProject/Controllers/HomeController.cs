using ExcelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcelProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var hello = new MessageModel();
            hello.Hello = "Xin chào các con giời!!!";
            return View(hello);
        }
    }
}