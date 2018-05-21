using kp.EF;
using kp.Interfaces;
using kp.Models;
using kp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp
{
    public class ExcelModel
    {
        public int SubId { get; set; }
        public int Assessments { get;  set; }
        public int Attempt { get; set; }
        public int StudentId { get; set; }

        public int Cours { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int SpecialityID { get; set; }


        public string Name_Specialty { get; set; }
        // public string Fullname { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        
        
        
       
        public string SubName { get; set; }
       // public byte[] Docum { get; set; }
        //public int Quantity { get; set; }
      
      //  public int SemesterCount { get; set; }

        

        public Assessment GetAssesment()
        {
            var assesment = new Assessment();

            assesment.ID_subject = SubId;
            assesment.Assessment1 = Assessments;
           // assesment.Attempt = Attempt;           
            assesment.ID_student = StudentId;


            return assesment;
        }
    }
}