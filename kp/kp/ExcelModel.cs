using kp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp
{
    public class ExcelModel
    {
        public int StudentId { get; set; }
        public string Fulllname { get; set; }
        public int Cours { get; set; }
        public int Semester { get; set; }
        public string Speciality { get; set; }
        public int SubId { get; set; }
        public string SubName { get; set; }
        public int Mark { get; set; }
        public int Attempt { get; set; }
        public int SemesterCount { get; set; }

        public Assesment GetAssesment()
        {
            var assesment = new Assesment();

            assesment.ID_sub = SubId;
            assesment.Attempt = Attempt;
            assesment.Аssessments = Mark;
            assesment.ID_student = StudentId;

            return assesment;
        }
    }
}