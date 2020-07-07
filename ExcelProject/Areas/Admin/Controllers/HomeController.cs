using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExcelProject.Areas.Admin.Models;
using System.Web.Services.Description;

namespace ExcelProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase upload)
        {
            if (Path.GetExtension(upload.FileName) == ".xlsx" || Path.GetExtension(upload.FileName) == ".xls")
            {
                ExcelPackage pakage = new ExcelPackage(upload.InputStream);
                DataTable dt = ExcelPakageExtensions.ToDataTable(pakage);
                return View(dt);
            }
            return View();
        }

        public ActionResult ReadExcelUsingEpplus()
        {
            return View();
        }
    }
}