using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BussinessLayer
{
    public class BussinessStudentClass
    {
        public int InsertStudentClass(string studentClassId, string facultyId, ref string error)
        {
            int result = -1;
            try
            {
                using (var context = new Context())
                {
                    var studentClass = new StudentClass()
                    {
                        StudentClassId = studentClassId,
                        FacultyId = facultyId
                    };
                    context.StudentClasses.Add(studentClass);
                    result = context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return result;
        }
        public List<StudentClass> GetStudentClasses(string facultyId, ref string error)
        {

            try
            {
                using (var context = new Context())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var studentClasses = (from studentClass in context.StudentClasses
                                          where studentClass.FacultyId == facultyId
                                          select studentClass).ToList();
                    return studentClasses.ToList();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return null;
        }
    }
}
