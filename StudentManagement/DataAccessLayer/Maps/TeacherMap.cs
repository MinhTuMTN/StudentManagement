using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.DataAccessLayer.Maps
{
    public class TeacherMap : EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            Property(t => t.TeacherId).IsRequired().HasMaxLength(8).IsFixedLength().IsUnicode(false);
            Property(t => t.TeacherName).IsRequired().HasMaxLength(100).IsUnicode(true);
            Property(t => t.Address).IsRequired().HasMaxLength(100).IsUnicode(true);

            HasMany(t => t.Subjects).WithOptional(s => s.Teacher).HasForeignKey(s => s.TeacherId);
        }
    }
}
