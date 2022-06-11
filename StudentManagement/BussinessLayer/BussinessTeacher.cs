using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.BussinessLayer
{
    public class BussinessTeacher
    {
        public int InsertTeacher(string teacherId, string teacherName, int yearOfBirth, string address, ref string error, bool isActive = true)
        {
            try
            {
                using (var context = new Context())
                {
                    var teacher = new Teacher()
                    {
                        TeacherId = teacherId,
                        TeacherName = teacherName,
                        YearOfBirth = yearOfBirth,
                        Address = address,
                        IsActive = true
                    };
                    context.Teachers.Add(teacher);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public Teacher GetTeacher(string teacherId, ref string error)
        {
            try
            {
                using(var context = new Context())
                {
                    var teacherSelect = from teacher in context.Teachers
                                        where teacher.TeacherId == teacherId && teacher.IsActive == true
                                        select teacher;
                    return teacherSelect.FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return null; 
        }
        public int DeleteTeacher(string teacherId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var teacher = GetTeacher(teacherId, ref error);
                    context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;

                    if (teacher != null)
                    {
                        teacher.IsActive = false;
                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "Không tồn tại giảng viên";
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public int UpdateTeacher(string teacherId, string teacherName, int yearOfBirth, string address, ref string error, bool isActive = true)
        {
            try
            {
                using (var context = new Context())
                {
                    var teacher = GetTeacher(teacherId, ref error);
                    context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                    if (teacher != null)
                    {
                        teacher.TeacherId = teacherId;
                        teacher.TeacherName = teacherName;
                        teacher.YearOfBirth = yearOfBirth;
                        teacher.Address = address;
                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "Không tồn tại giảng viên";
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
    }
}
