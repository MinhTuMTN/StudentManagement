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
        public int InsertStudent(string studentId, string studentName, DateTime birthDate, string sex, string nation, string address, int yearOfAdmission, string studentClassId, ref string error, bool isActived = true)
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
                        StudentClassId = studentClassId,
                        IsActive = isActived,
                    };
                    context.Students.Add(student);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.InnerException.Message;
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
        public int UpdateStudent(string studentId, string studentName, DateTime birthDate, string sex, string nation, string address, int yearOfAdmission, string studentClassId, ref string error, bool isActived = true)
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
        public int UpdateGPA(string studentId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var student = context.Students.Where(s => s.StudentId == studentId).FirstOrDefault();
                    float GPA = GetGPA(studentId, ref error);
                    student.GPA = GPA;

                    context.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    return context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public float GetGPA(string studentId, ref string error)
        {
            float tongDiem = 0;
            int tongSoTC = 0;
            try
            {
                using (var context = new Context())
                {
                    var student = context.Students.Find(studentId);

                    if(student.StudentSubjects.Count == 0)
                        return 0;

                    foreach (StudentSubject studentSubject in student.StudentSubjects)
                    {
                        float diemTK = (studentSubject.DiemCK + studentSubject.DiemGK) / 2;
                        int soTC = studentSubject.Subject.NumberOfCredits;
                        tongSoTC += soTC;
                        tongDiem += diemTK * soTC;
                    }

                    return tongDiem / tongSoTC;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public float GetTuition(string studentId, ref string error)
        {
            try
            {
                float amountPerCredit = 520000;
                int numberOfCredits = 0;
                using(var context = new Context())
                {
                    var student = context.Students.Find(studentId);

                    foreach(StudentSubject studentSubject in student.StudentSubjects)
                        if (!studentSubject.IsPaid)
                            numberOfCredits += studentSubject.Subject.NumberOfCredits;

                    return numberOfCredits * amountPerCredit;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public int TuitionPayment(string studentId, string subjectId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var studentSubject = context.StudentSubjects.Where(ss => ss.StudentId == studentId && ss.SubjectId == subjectId).SingleOrDefault();

                    if (studentSubject != null)
                    {
                        studentSubject.IsPaid = true;
                        return context.SaveChanges();
                    }
                    else
                        error = "Không tìm thấy môn học hoặc sinh viên này";
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
    }
}
