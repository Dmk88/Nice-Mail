using kp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Models
{
    public class AssesmentListViewModel
    {
        public int? UserID { get; set; }
      //  public List<Student> StudentList { get; set;}
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
       // public int ID_subject { get; set; }
        //public string Name_subject { get; set; }
       // public List<Subject> SubjectList { get; set; }
        public List<Assessment> AssesmentsList { get; set; }
        public int Courses { get; set; }
        public int Semester { get; set; }

        //public AssesmentListViewModel(int id,string firstname, string lastname, string middlename, List<Assesment> assesments, int course, int semester)
        //{
        //    UserID = id;
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Middlename = middlename;
        //    AssesmentsList = assesments;
        //    Course = course;
        //    Semester = semester;
        //}

        //public AssesmentListViewModel()
        //{
        //}
    }
}