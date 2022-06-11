using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.BussinessLayer
{
    public class BussinessSubject
    {
        public Subject GetSubject(string subjectId, ref string error)
        {
            try
            {
                using(var context = new Context())
                {
                    var subjectSelect = from subject in context.Subjects
                                        where subject.SubjectId == subjectId && subject.IsActive == true
                                        select subject;
                    return subjectSelect.FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return null;
        }
        public int InsertSubject(string subjectId, string subjectName, int numberOfCredits, string teacherId, ref string error, bool isActive = true)
        {
            try
            {
                using(var context = new Context())
                {
                    var subject = new Subject()
                    {
                        SubjectId = subjectId,
                        SubjectName = subjectName,
                        NumberOfCredits = numberOfCredits,
                        TeacherId = teacherId,
                        IsActive = isActive
                    };
                    context.Subjects.Add(subject);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public int UpdateSubject(string subjectId, string subjectName, int numberOfCredits, string teacherId, ref string error, bool isActive = true)
        {
            try
            {
                using(var context = new Context())
                {
                    var subjectUpdate = GetSubject(subjectId, ref error);
                    context.Entry(subjectUpdate).State = System.Data.Entity.EntityState.Modified;

                    context.Entry(subjectUpdate).State = System.Data.Entity.EntityState.Modified;
                    if(subjectUpdate != null)
                    {
                        subjectUpdate.SubjectName = subjectName;
                        subjectUpdate.NumberOfCredits = numberOfCredits;
                        subjectUpdate.TeacherId = teacherId;
                        subjectUpdate.IsActive = isActive;

                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "Không tồn tại môn học này";
                        return -1;
                    }
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        public int DeleteSubject(string subjectId, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var subjectDelete = GetSubject(subjectId, ref error);
                    context.Entry(subjectDelete).State = System.Data.Entity.EntityState.Modified;

                    if (subjectDelete != null)
                    {
                        subjectDelete.IsActive = false;

                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "Không tồn tại môn học này";
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
