using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;

namespace StudentManagement.BussinessLayer
{
    public class BussinessStudent
    {
        public int InsertStudent(string studentId, string studentName, DateTime birthDate, string sex, string nation, string address, int yearOfAdmission, string facultyId, string studentClassId, ref string error, bool isActived = true)
        {
            try
            {
                using (var context = new Context())
                {
                    BussinessStudentClass studentClass = new BussinessStudentClass();
                    var student = new Student()
                    {
                        StudentId = studentId,
                        Name = studentName,
                        BirthDate = birthDate,
                        Sex = sex,
                        Nation = nation,
                        Address = address,
                        YearOfAdmission = yearOfAdmission,
                        FacultyId = facultyId,
                        StudentClassId = studentClassId,
                        IsActive = isActived,
                    };
                    context.Students.Add(student);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public Student GetStudentById(string studentId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var selectStudent = (from student in context.Students
                                         where student.StudentId.Trim() == studentId.Trim()
                                                 && student.IsActive == true
                                         select student).FirstOrDefault();

                    return (Student)selectStudent;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return null;
        }
        public List<Student> GetStudentsByFacultyId(string facultyId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var students = from student in context.Students
                                   where student.FacultyId == facultyId && student.IsActive == true
                                   select student;
                    return students.ToList();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return null;
        }
        public List<Student> GetStudentsByStudentClassId(string studentClassId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var students = from student in context.Students
                                   where student.StudentClassId == studentClassId && student.IsActive == true
                                   select student;
                    return students.ToList();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return null;
        }
        public int UpdateStudent(string studentId, string studentName, DateTime birthDate, string sex, string nation, string address, int yearOfAdmission, string facultyId, string studentClassId, ref string error, bool isActived = true)
        {
            try
            {
                using (var context = new Context())
                {
                    var updateStudent = (from student in context.Students
                                         where student.StudentId == studentId
                                         select student).FirstOrDefault();
                    if (updateStudent != null)
                    {
                        updateStudent.Name = studentName;
                        updateStudent.BirthDate = birthDate;
                        updateStudent.Sex = sex;
                        updateStudent.Nation = nation;
                        updateStudent.Address = address;
                        updateStudent.YearOfAdmission = yearOfAdmission;
                        updateStudent.FacultyId = facultyId;
                        updateStudent.StudentClassId = studentClassId;
                        updateStudent.IsActive = isActived;

                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "There are no students with a student ID of " + studentId;
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
        public int DeleteStudent(string studentId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var deleteStudent = (from student in context.Students
                                         where student.StudentId.Equals(studentId)
                                         select student).FirstOrDefault();
                    if (deleteStudent != null)
                    {
                        deleteStudent.IsActive = false;
                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "There are no students with a student ID of " + studentId;
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
        public int AddSubject(string studentId, string subjectId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    Student student = context.Students.Find(studentId);
                    if (student != null)
                    {
                        Subject subject = context.Subjects.Find(subjectId);

                        if (subject != null)
                        {
                            try
                            {
                                var studentSubject = new StudentSubject()
                                {
                                    Student = student,
                                    Subject = subject
                                };
                                context.StudentSubjects.Add(studentSubject);
                                int result = context.SaveChanges();
                                return result;
                            }
                            catch (Exception ex)
                            {
                                error = ex.Message;
                                return -1;
                            }
                        }
                        else
                        {
                            error = "Không tồn tại môn học này";
                            return -1;
                        }
                    }
                    else
                    {
                        error = "Không tồn tại sinh viên này";
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
        public int RemoveSubject(string studentId, string subjectId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var studentSubject = context.StudentSubjects.Where(ss => ss.StudentId == studentId && ss.SubjectId == subjectId).SingleOrDefault();

                    if (studentSubject != null)
                    {
                        context.StudentSubjects.Remove(studentSubject);
                        return context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public int UpdateScoreGK(string studentId, string subjectId, float diemGK, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var studentSubject = context.StudentSubjects.Where(ss => ss.StudentId == studentId && ss.SubjectId == subjectId).SingleOrDefault();

                    if (studentSubject != null)
                    {
                        studentSubject.DiemGK = diemGK;
                        context.StudentSubjects.AddOrUpdate(studentSubject);
                        return context.SaveChanges();
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        // get the error message 
                       error = validationError.ErrorMessage;
                    }
                }
            }
            return -1;
        }
        public int UpdateScoreCK(string studentId, string subjectId, float diemCK, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var studentSubject = context.StudentSubjects.Where(ss => ss.StudentId == studentId && ss.SubjectId == subjectId).SingleOrDefault();

                    if (studentSubject != null)
                    {
                        studentSubject.DiemCK = diemCK;

                        return context.SaveChanges();
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        // get the error message 
                        error = validationError.ErrorMessage;
                    }
                }
            }
            return -1;
        }
        public int UpdateScore(string studentId, string subjectId, float diemGK, float diemCK, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var studentSubject = context.StudentSubjects.Where(ss => ss.StudentId == studentId && ss.SubjectId == subjectId).SingleOrDefault();

                    if (studentSubject != null)
                    {
                        studentSubject.DiemCK = diemCK;
                        studentSubject.DiemGK = diemGK;
                        return context.SaveChanges();
                    }
                }   
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        // get the error message 
                        error = validationError.ErrorMessage;
                    }
                }
            }
            return -1;
        }

    }
}
