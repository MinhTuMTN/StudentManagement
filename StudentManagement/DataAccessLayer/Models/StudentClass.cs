using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class StudentClass
    {
        public StudentClass()
        {
            Students = new HashSet<Student>();
        }
        public string StudentClassId { get; set; }

        public string FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
