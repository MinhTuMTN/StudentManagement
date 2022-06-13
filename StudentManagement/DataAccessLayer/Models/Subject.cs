using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace StudentManagement.DataAccessLayer.Models
{
    public class Subject
    {
        public Subject()
        {
            StudentSubjects = new HashSet<StudentSubject>();
        }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }
        public bool IsActive { get; set; } 

        public string TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
