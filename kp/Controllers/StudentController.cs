using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

using kp.Models;
using kp.EF;

namespace kp.Controllers
{
    public class StudentController : Controller
    {
        private AnaliticEntities1 db = new AnaliticEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Studack()
        {
            return View("Studack");
        }

        public ActionResult AssesmentList(int? Id)
        {
            
            List<Student> students = db.Student.Where(s => s.ID_student == Id).ToList();
            var ble = new AssesmentListViewModel();

            var student = students.First();
            var course = db.Course.FirstOrDefault(s => s.ID_student == student.ID);
            var assesments = new List<Assessment>();
            ble = new AssesmentListViewModel()
            {
                UserID = student.ID_student,
                Firstname = student.Firsname,
                Lastname = student.Lastname,

                Patronymic = student.Patronimic,
                Courses = course.Course1,
                Semester = course.Semester
            };

            foreach (var stud in students)
            {
                assesments.AddRange(db.Assessment.Include(sub => sub.Subject).Where(s => s.ID_student == stud.ID).ToList());
            }
            ble.AssesmentsList = assesments;
            return View(ble);


            // Subject subject = db.Subject.FirstOrDefault(s=>s.ID == Id);
            // List<Subject> subject=db.Subject.Include(sub => sub.ID).Where(s => s.ID_student == Id).ToList();
            //Student student = db.Student.FirstOrDefault(s => s.ID_student == Id);
            //Course course = db.Course.FirstOrDefault(s => s.ID_student == Id);
            //Subject subject = db.Subject.FirstOrDefault(s => s.ID_subject == Id);


            //    AssesmentListViewModel model = new AssesmentListViewModel()
            //{
            //    UserID = student.ID_student,
            //    Firstname = student.Firsname,
            //    Lastname = student.Lastname,
            //    Patronymic = student.Patronimic,
            //    //  ID_subject= subject.ID_subject,
            //    // SubjectList=subject,
            //    //  Name_subject=subject.Name_subject,
            //    AssesmentsList = assesments,
            //    Courses = course.Course1,
            //    Semester = course.Semester
            //};
        }

        public ActionResult Analize(int? Id)
        {
            List<Assessment> assesments = db.Assessment.Include(sub => sub.Subject).Where(s => s.ID_student == Id).ToList();

            //Оставить на лучише времена
            //List<Dictionary<string,Assesment>> listGroup = new List<Dictionary<string,Assesment>>();
            //for (int i = 0; i < 6; i++)
            //{
            //    Dictionary<string, Assesment> group = new Dictionary<string, Assesment>();
            //    foreach (var item in assesments)
            //    {
            //        if (item.Subject.ID_sub.ToString().Substring(1, 1) == (i + 1).ToString())
            //            group.Add((i+1).ToString(), item);
            //    }
            //    listGroup.Add(group);
            //}
            //foreach (var group in listGroup)
            //{
            //    if (group.Select(i => i.Value.Аssessments).Average() >= 6)
            //        group.Keys.First();
            //}

            IList<Assessment> groupMath = new List<Assessment>();
            IList<Assessment> groupNetwork = new List<Assessment>();
            IList<Assessment> groupProgramming = new List<Assessment>();
            IList<Assessment> groupForeignSubject = new List<Assessment>();
            IList<Assessment> groupData = new List<Assessment>();
            IList<Assessment> groupDB = new List<Assessment>();
            Student student = db.Student.FirstOrDefault(s => s.ID_student == Id);
            foreach (var item in assesments)
            {
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "1")
                    groupMath.Add(item);
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "2")
                    groupNetwork.Add(item);
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "3")
                    groupProgramming.Add(item);
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "4")
                    groupForeignSubject.Add(item);
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "5")
                    groupData.Add(item);
                if (item.Subject.ID_subject.ToString().Substring(1, 1) == "6")
                    groupDB.Add(item);
            }
            IList<string> nameGroup = new List<string>();
            //if (groupMath.Count() > 0) if (groupMath.Select(i => i.Аssessments).Average() < 5) { groupMath.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupNetwork.Count() > 0) if (groupNetwork.Select(i => i.Аssessments).Average() < 5) { groupNetwork.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupProgramming.Count() > 0) if (groupProgramming.Select(i => i.Аssessments).Average() < 5) { groupProgramming.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupForeignSubject.Count() > 0) if (groupForeignSubject.Select(i => i.Аssessments).Average() < 5) { groupForeignSubject.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupData.Count() > 0) if (groupData.Select(i => i.Аssessments).Average() < 5) { groupData.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupDB.Count() > 0) if (groupDB.Select(i => i.Аssessments).Average() < 5) { groupDB.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }


            // if (groupProgramming.Count() != 0) if (groupProgramming.Select(i => i.Аssessments).Average() < 5) { groupProgramming.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            // if (groupNetwork.Count() != 0 & groupNetwork.Select(i => i.Аssessments).Average() < 5) groupNetwork.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub));
            //if (groupProgramming.Count() != 0 & groupProgramming.Select(i => i.Аssessments).Average() < 5) groupProgramming.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub));
            //if (groupForeignSubject.Count() != 0 & groupForeignSubject.Select(i => i.Аssessments).Average() < 5) groupForeignSubject.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub));
            //if (groupData.Count() != 0 & groupData.Select(i => i.Аssessments).Average() < 5) groupData.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub));
            //if (groupDB.Count() != 0 & groupDB.Select(i => i.Аssessments).Average() < 5) groupDB.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub));

            if (groupMath.Count() != 0) if (groupMath.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("c математическим уклоном"); }
            if (groupNetwork.Count() != 0) if (groupNetwork.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("связанные с сетевым оборудованием"); }
            if (groupProgramming.Count() != 0) if (groupProgramming.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("связанные с языками программирования"); }
            if (groupForeignSubject.Count() != 0) if (groupForeignSubject.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("общеобразовательные предметы"); }
            if (groupData.Count() != 0) if (groupData.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("связанные с данными"); }
            if (groupDB.Count() != 0) if (groupDB.Select(i => i.Assessment1).Average() < 5) { nameGroup.Add("связанные с базами данных"); }
            //if (groupProgramming.Count() != 0) if (groupProgramming.Select(i => i.Аssessments).Average() > 5) { groupProgramming.ToList().ForEach(i => nameGroup.Add(i.Subject.Name_sub)); }
            //if (groupForeignSubject.Count() != 0) if (groupForeignSubject.Select(i => i.Аssessments).Average() <= 5) { nameGroup.Add("ForeignSubject"); }
            //if (groupData.Count() != 0) if (groupData.Select(i => i.Аssessments).Average() <= 5) { nameGroup.Add("Data"); }
            //if (groupDB.Count() != 0) if (groupDB.Select(i => i.Аssessments).Average() <= 5) { nameGroup.Add("DB"); }
            ViewBag.Group = nameGroup.ToList();
            return View();
        }
    }
}