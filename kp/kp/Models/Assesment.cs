using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kp.Models
{
    public class Assesment
    {
        [Key]
        public int ID_assesment { get; set; }

        [ForeignKey("Subject")]
        public int ID_sub { get; set; }
        public Subject Subject { get; set; }

        [Range(0, 10, ErrorMessage = "Оценка выше возможной")]
        public int Аssessments { get; set; }

        [Range(1, 3, ErrorMessage = "Больше попыток невозможно")]
        public int Attempt { get; set; }

        [ForeignKey("Student")]
        public int ID_student { get; set; }
        public Student Student { get; set; }
    }
}