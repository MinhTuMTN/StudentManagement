using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Data;

namespace StudentManagement.BussinessLayer
{
    public class BussinessStudentSubject
    {
        BussinessStudent bussinessStudent = new BussinessStudent();
        public DataTable GetRegistedCourse(string studentId, ref string error)
        {
            DataTable dataTable = new DataTable();

            DataColumn column = new DataColumn();
            column.ColumnName = "MaMH";
            column.DataType = typeof(string);
            dataTable.Columns.Add(column);

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "TenMH";
            column2.DataType = typeof(string);
            dataTable.Columns.Add(column2);

            using (var context = new Context())
            {
                var subjectsOfStudent = (from studentSubject in context.StudentSubjects
                                         where studentSubject.StudentId == studentId
                                         select studentSubject.Subject).ToList();
                var allSubject = from subject in context.Subjects
                                 select subject;

                foreach (var subject in allSubject)
                {
                    if (!subjectsOfStudent.Contains(subject))
                        continue;
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = subject.SubjectId;
                    dataRow[1] = subject.SubjectName;
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        public DataTable GetUnregistedCourse(string studentId, ref string error)
        {
            DataTable dataTable = new DataTable();

            DataColumn column = new DataColumn();
            column.ColumnName = "MaMH";
            column.DataType = typeof(string);
            dataTable.Columns.Add(column); 

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "TenMH";
            column2.DataType = typeof(string);
            dataTable.Columns.Add(column2);

            using(var context = new Context())
            {
                var subjectsOfStudent = (from studentSubject in context.StudentSubjects
                                        where studentSubject.StudentId == studentId
                                        select studentSubject.Subject).ToList();
                var allSubject = from subject in context.Subjects 
                                 select subject;

                foreach(var subject in allSubject)
                {
                    if (subjectsOfStudent.Contains(subject))
                        continue;
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = subject.SubjectId;
                    dataRow[1] = subject.SubjectName;
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        public DataTable GetUnpaidCourse(string studentId, ref string error)
        {
            DataTable dataTable = new DataTable();

            DataColumn column = new DataColumn();
            column.ColumnName = "STT";
            column.DataType = typeof(int);
            dataTable.Columns.Add(column);

            DataColumn column1 = new DataColumn();
            column1.ColumnName = "MaMH";
            column1.DataType = typeof(string);
            dataTable.Columns.Add(column1);

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "TenMH";
            column2.DataType = typeof(string);
            dataTable.Columns.Add(column2);

            DataColumn column3 = new DataColumn();
            column3.ColumnName = "SoTC";
            column3.DataType = typeof(int);
            dataTable.Columns.Add(column3);

            using(var context = new Context())
            {
                var studentSubjectUnpaid = (from studentSubject in context.StudentSubjects
                                           where studentSubject.IsPaid == false && studentSubject.StudentId == studentId
                                           select studentSubject).ToList();
                int stt = 1;
                foreach(StudentSubject studentSubject in studentSubjectUnpaid)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = stt++;
                    dataRow[1] = studentSubject.SubjectId;
                    dataRow[2] = studentSubject.Subject.SubjectName;
                    dataRow[3] = studentSubject.Subject.NumberOfCredits;
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        public int AddSubject(string studentId, string subjectId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    Student student = context.Students.Find(studentId);
                    if(student.StudentSubjects.Where(ss => ss.SubjectId.Trim() == subjectId).Any())
                    {
                        error = "Đã tồn tại môn học này";
                        return -1;
                    }

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
                                    Subject = subject,
                                    IsPaid = false
                                };
                                context.StudentSubjects.Add(studentSubject);
                                bussinessStudent.UpdateGPA(studentId, ref error);
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
                        int result = context.SaveChanges();
                        bussinessStudent.UpdateGPA(studentId, ref error);
                        return result;
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
                        int result = context.SaveChanges();
                        bussinessStudent.UpdateGPA(studentId, ref error);
                        return result;
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                    foreach (var validationError in errors.ValidationErrors)
                        error = validationError.ErrorMessage;
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
                        context.StudentSubjects.AddOrUpdate(studentSubject);
                        int result = context.SaveChanges();
                        bussinessStudent.UpdateGPA(studentId, ref error);
                        return result;
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                    foreach (var validationError in errors.ValidationErrors)
                        error = validationError.ErrorMessage;
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
                        context.StudentSubjects.AddOrUpdate(studentSubject);
                        int result = context.SaveChanges();
                        bussinessStudent.UpdateGPA(studentId, ref error);
                        return result;
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                    foreach (var validationError in errors.ValidationErrors)
                        error = validationError.ErrorMessage;
            }
            return -1;
        }
    }
}
