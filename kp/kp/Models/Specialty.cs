using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kp.Models
{
    public class Specialty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int SpecialtyId { get; set; }

        [StringLength(50)]
        public string Name_Specialty { get; set; }
    }
}