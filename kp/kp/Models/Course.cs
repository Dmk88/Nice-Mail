using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace kp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CourseId { get; set; }

        [Range(1, 4, ErrorMessage = "Больше курсов не существует")]
        public int Cour { get; set; }

        [Range(1, 2, ErrorMessage = "Больше семестров не существует")]
        public int Semester { get; set; }

        [Range(1, 10, ErrorMessage = "Больше групп нету на потоке")]
        public int Group { get; set; }

        [ForeignKey("Specialty")]
        public int ID_Specialty { get; set; }
        public Specialty Specialty { get; set; }

        [ForeignKey("Student")]
        public int ID_Student { get; set; }
        public Student Student { get; set; }
    }
}