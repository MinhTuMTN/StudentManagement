using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.DataAccessLayer.Maps
{
    public class StudentClassMap : EntityTypeConfiguration<StudentClass>
    {
        public StudentClassMap()
        {
            Property(sc => sc.StudentClassId).IsRequired().IsUnicode(false)
                .HasMaxLength(7).IsFixedLength();

            HasMany(sc => sc.Students).WithOptional(s => s.StudentClass)
                .HasForeignKey(s => s.StudentClassId);
        }
    }
}
