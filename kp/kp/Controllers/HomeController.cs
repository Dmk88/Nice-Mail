using kp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Microsoft.AspNet.Identity.EntityFramework;

namespace kp.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        [Authorize]
        public ActionResult Index()
        {
            IList<string> roles = new List<string> { "Роль не определена" };
            ApplicationUserManager userManager = HttpContext.GetOwinContext()
                                                    .GetUserManager<ApplicationUserManager>();
            ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            if (user != null)
                roles = userManager.GetRoles(user.Id);
            return View(roles);
           // return View();
        }


         [Authorize(Roles = "admin")]
        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Filling()
        {
            //IEnumerable<Course> course = db.Courses;
            //ViewBag.Courses = course;
            //IEnumerable<Student> student = db.Students;
            //ViewBag.Students = student;
            //IEnumerable<Subject> subject = db.Subjects;
            //ViewBag.Subjects = subject;
            //IEnumerable<Specialty> specialty = db.Specialtys;
            //ViewBag.Specialtys = specialty;

            return View();
        }


        public ActionResult Export()
        {
            ExcelHelper helper = new ExcelHelper();
            var path=helper.CreateDirectory();
            var files = Request.Files;
            var f = files[0];
            for(int i=0; i< files.Count; i++)
            {
                helper.SaveFilte(path, files[i]);
            }
            var list = helper.ReadAllExcelFiles(path);

            foreach (var item in list)
            {
                db.Assesments.Add(item.GetAssesment());
                db.SaveChanges();
            }
            return View("Index");
        }

        public ActionResult Startup()
        {
            return View();
        }

        public ActionResult List()
        {
            IEnumerable<Course> course = db.Courses;
            ViewBag.Courses = course;
            //IEnumerable<Student> student = db.Students;
            ViewBag.Students = db.Students.ToList();
            IEnumerable<Subject> subject = db.Subjects;
            ViewBag.Subjects = subject;
            IEnumerable<Specialty> specialty = db.Specialtys;
            ViewBag.Specialtys = specialty;

            IEnumerable<Assesment> assesments = db.Assesments.ToList();
            ViewBag.Assesments = assesments;

            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles() {
          
            return View("List");
        }
        //public ActionResult Course()
        //{
        //    // получаем из бд все объекты Book
        //    IEnumerable<Book> books = db.Books;
        //    // передаем все объекты в динамическое свойство Books в ViewBag
        //    ViewBag.Books = books;
        //    // возвращаем представление
        //    return View();
        //}
    }
}