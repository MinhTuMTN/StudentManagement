using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class StudentSubject
    {
        [Key, Column(Order = 0)]
        public string StudentId { get; set; }
        [Key, Column(Order = 1)]
        public string SubjectId { get; set; }

        [Range(typeof(float), "0","10", ErrorMessage ="Điểm không hợp lệ")]
        public float DiemGK { get; set; }
        [Range(typeof(float), "0", "10", ErrorMessage = "Điểm không hợp lệ")]
        public float DiemCK { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
