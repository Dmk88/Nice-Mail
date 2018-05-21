using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using kp.Models;

namespace kp.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Studack()
        {
            return View("Studack");
        }

        [HttpPost]
        public ActionResult Studack(int studentId)
        {
           // List<Assesment> assesment = db.Assesments.Include(s=>ыыю)
            return View();
        }
    }
}