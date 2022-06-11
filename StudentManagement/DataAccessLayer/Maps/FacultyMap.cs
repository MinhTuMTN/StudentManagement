using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.DataAccessLayer.Maps
{
    public class FacultyMap : EntityTypeConfiguration<Faculty>
    {
        public FacultyMap()
        {
            Property(f => f.FacultyId).IsRequired().IsUnicode(false)
                .HasMaxLength(10).IsFixedLength();

            HasMany(f => f.Students).WithOptional(s => s.Faculty)
                .HasForeignKey(s => s.FacultyId);
            HasMany(f => f.StudentClasses).WithOptional(sc => sc.Faculty)
                .HasForeignKey(sc => sc.FacultyId);
        }
    }
}
