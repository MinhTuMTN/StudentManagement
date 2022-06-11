
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.DataAccessLayer.Maps
{
    public class SubjectMap : EntityTypeConfiguration<Subject>
    {
        public SubjectMap()
        {
            Property(s => s.SubjectId).IsRequired().HasMaxLength(15).IsFixedLength().IsUnicode(false);
            Property(s => s.SubjectName).IsRequired().HasMaxLength(100).IsUnicode(true);
            Property(s => s.NumberOfCredits).IsRequired();
        }
    }
}
