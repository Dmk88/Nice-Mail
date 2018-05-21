using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kp.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ID_sub { get; set; }

        [StringLength(300)]
        public string Name_sub { get; set; }

        [Range(1, 3, ErrorMessage = "Предмет более не изучается")]
        public int Quantity { get; set; }
    }
}