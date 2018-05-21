using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kp.Controllers
{
    public class ExportController : Controller
    {
        // GET: Export
        public ActionResult Index()
        {
            ExcelHelper helper = new ExcelHelper();
           // var list = helper.ReadAllExcelFiles();

            return View();
        }

    }
}