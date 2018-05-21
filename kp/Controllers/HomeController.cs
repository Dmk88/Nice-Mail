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
using kp.Interfaces;
using kp.Repositories;
using kp.EF;

namespace kp.Controllers
{
    public class HomeController : Controller
    {
        //StudentContext db = new StudentContext();
        AnaliticEntities1 db = new AnaliticEntities1();
        private readonly IAssessment _assRepos;
        private readonly ICourse _courRepos;
        private readonly ISpeciality _specRepos;
        private readonly IStudents _studRepos;
        private readonly ISubjects _subRepos;
        //   public HomeController() { }

        /* public HomeController(AssesmentsRepositories assRepos,CoursesRepositories courRepos, SpecialtiesRepositories specRepos,  StudentsRepositories studRepos, SubjectsRepositories subRepos)
         {
             _assRepos = assRepos;
             _courRepos = courRepos;
             _specRepos = specRepos;
             _studRepos = studRepos;
             _subRepos = subRepos;
         }*/
        public HomeController() : base()
        {
            _assRepos = new AssesmentsRepositories(db);
            _courRepos = new CoursesRepositories(db);
            _specRepos = new SpecialityRepositories(db);
            _studRepos = new StudentsRepositories(db);
            _subRepos = new SubjectsRepositories(db);

        }

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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
        [HttpPost]
        public ActionResult Export()
        {
            ExcelHelper helper = new ExcelHelper();
            var path = helper.CreateDirectory();
            var files = Request.Files;
            var f = files[0];
            for (int i = 0; i < files.Count; i++)
            {
                helper.SaveFilte(path, files[i]);
            }
            var list = helper.ReadAllExcelFiles(path);

            foreach (var item in list)
            {
                Student st = new Student
                {
                    ID_student = item.StudentId,
                    Firsname = item.FirstName,
                    Lastname = item.LastName,
                    Patronimic = item.Patronimic
                };
                if (_studRepos != null)
                {
                    _studRepos.AddStudents(st);
                }
                Subject sub = new Subject
                {
                    ID_subject=item.SubId,
                    Name_subject = item.SubName,
                };
                if (_subRepos != null)
                {
                    _subRepos.AddSubjects(sub);
                }

                Speciality spec = new Speciality
                {
                    ID_speciality = item.SpecialityID,
                    Name_speciality = item.Name_Specialty
                };
                if (_specRepos != null)
                {
                    _specRepos.AddSpecialties(spec);
                }

                Course cours = new Course
                {
                    Course1=item.Cours,
                    Semester=item.Semester,
                   Group=item.Group,
                    ID_speciality = spec.ID,
                    ID_student = st.ID
                    
                };
                if (_courRepos != null)
                {
                    _courRepos.AddCourse(cours);
                }

                Assessment ass = new Assessment
                {
                    Assessment1 = item.Assessments,
                    ID_student = st.ID,
                    ID_subject = sub.ID,
                };
                if (_assRepos != null)
                {
                    _assRepos.AddAssesments(ass);
                }



            }
            return RedirectToAction("Studack","Student");
        }

        public ActionResult Startup()
        {
            return View();
        }

        public ActionResult List()
        {
            IEnumerable<Course> course = db.Course;
            ViewBag.Courses = course;
            //IEnumerable<Student> student = db.Student;
            ViewBag.Student = db.Student.ToList();
            IEnumerable<Subject> subject = db.Subject;
            ViewBag.Subjects = subject;
            IEnumerable<Speciality> specialty = db.Speciality;
            ViewBag.Specialtys = specialty;

            IEnumerable<Assessment> assesments = db.Assessment.ToList();
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