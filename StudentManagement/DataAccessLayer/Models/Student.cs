using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class Student
    {
        public Student()
        {
            Subjects = new HashSet<Subject>();
            StudentSubjects = new HashSet<StudentSubject>();
        }
        public string StudentId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public string Nation { get; set; }
        public string Address { get; set; }
        public int YearOfAdmission { get; set; }
        public float GPA { get; set; }
        public bool IsActive { get; set; }


        public string FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public string StudentClassId { get; set; }
        public virtual StudentClass StudentClass { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
