using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }
        public string TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
