using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.BussinessLayer
{
    public class BussinessFaculty
    {
        public int InsertFaculty(string facultyId, string facultyName, ref string error)
        {
            int result = -1;
            try
            {
                using (var context = new Context())
                {
                    var faculty = new Faculty()
                    {
                        FacultyId = facultyId,
                        FacultyName = facultyName
                    };
                    context.Faculties.Add(faculty);
                    result = context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return result;
        }
        public int DeleteFaculty(string facultyId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var deleteFaculty = context.Faculties.Find(facultyId);
                    context.Faculties.Remove(deleteFaculty);
                    return context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return -1;
        }
        public int UpdateFaculty(string facultyId, string facultyName, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var updateFaculty = context.Faculties.Find(facultyId);
                    updateFaculty.FacultyName = facultyName;
                    return context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return -1;
        }
        public List<Faculty> GetFaculty(ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var faculties = from faculty in context.Faculties
                                    select faculty;
                    return faculties.ToList();
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
