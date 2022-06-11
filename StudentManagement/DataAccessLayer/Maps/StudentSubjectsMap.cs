using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;


namespace StudentManagement.DataAccessLayer.Maps
{
    public class StudentSubjectsMap : EntityTypeConfiguration<StudentSubject>
    {
        public StudentSubjectsMap()
        {
        }
    }
}
