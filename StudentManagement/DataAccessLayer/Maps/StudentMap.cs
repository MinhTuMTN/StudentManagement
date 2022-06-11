using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.DataAccessLayer.Maps
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            Property(s => s.StudentId).IsRequired()
                .HasMaxLength(8).IsFixedLength().IsUnicode(false);
            Property(s => s.Name).IsRequired()
                .HasMaxLength(200).IsUnicode(true);
            Property(s => s.Address).HasMaxLength(200).IsUnicode(true);
            Property(s => s.Sex).IsRequired()
                .HasMaxLength(3).IsUnicode(true).IsFixedLength();

            /*
            HasMany(s => s.Subjects)
                .WithMany(su => su.Students)
                .Map(m =>
                {
                    m.MapLeftKey("StudentId");
                    m.MapRightKey("SubjectId");
                });
            */
        }
    }
}
