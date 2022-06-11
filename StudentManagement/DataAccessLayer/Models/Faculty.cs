using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class Faculty
    {
        public Faculty()
        {
            Students = new HashSet<Student>();
            StudentClasses = new HashSet<StudentClass>();
        }
        public string FacultyId { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
