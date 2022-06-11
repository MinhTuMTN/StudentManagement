using StudentManagement.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            List<String> listFaculty = new List<String>
            {
                "Khoa Lý luận Chính trị",
                "Khoa Khoa học ứng dụng",
                "Khoa Cơ khí Chế tạo máy",
                "Khoa Điện - Điện tử",
                "Khoa Cơ khí Động Lực",
                "Khoa Kinh tế",
                "Khoa Công nghệ thông tin",
                "Khoa In và Truyền thông",
                "Khoa Công nghệ May và Thời Trang",
                "Khoa Công nghệ Hóa học và Thực phẩm",
                "Khoa Xây dựng",
                "Khoa Ngoại ngữ",
                "Khoa Đào tạo Chất lượng cao"
            };
            List<String> listFacultyId = new List<String>
            {
                "FPI",
                "FAS",
                "FME",
                "FEEE",
                "FAE",
                "FE",
                "FIT",
                "FGAM",
                "FGTFD",
                "FCFT",
                "FCEAM",
                "FFL",
                "FHQ"
            };
            for (int i = 0; i < listFaculty.Count; i++)
                context.Faculties.Add(new Models.Faculty()
                {
                    FacultyId = listFacultyId[i],
                    FacultyName = listFaculty[i]
                });

            context.StudentClasses.Add(new Models.StudentClass()
            {
                StudentClassId = "201102A",
                FacultyId = "FIT"
            });
            context.StudentClasses.Add(new Models.StudentClass()
            {
                StudentClassId = "201103A",
                FacultyId = "FIT"
            });
            context.StudentClasses.Add(new Models.StudentClass()
            {
                StudentClassId = "201101A",
                FacultyId = "FIT"
            });

            Student studentMT = new Student()
            {
                StudentId = "20110741",
                Name = "Nguyễn Minh Tú",
                BirthDate = DateTime.Parse("2002/05/30"),
                Sex = "Nam",
                Address = "Tiền Giang",
                Nation = "Kinh",
                YearOfAdmission = 2020,
                FacultyId = "FIT",
                StudentClassId = "201102A",
                IsActive = true
            };
            Student studentTV = new Student()
            {
                StudentId = "20110748",
                Name = "Nguyễn Ngọc Tuyết Vi",
                BirthDate = DateTime.Parse("2001/01/12"),
                Sex = "Nữ",
                Address = "Lâm Đồng",
                Nation = "Kinh",
                YearOfAdmission = 2020,
                FacultyId = "FIT",
                StudentClassId = "201102A",
                IsActive = true
            };
            Student studentQB = new Student()
            {
                StudentId = "20110179",
                Name = "Nguyễn Quốc Bảo",
                BirthDate = DateTime.Parse("2002/01/27"),
                Sex = "Nam",
                Address = "Sóc Trăng",
                Nation = "Kinh",
                YearOfAdmission = 2020,
                FacultyId = "FIT",
                StudentClassId = "201103A",
                IsActive = true
            };
            context.Students.Add(studentQB);
            context.Students.Add(studentMT);
            context.Students.Add(studentTV);

            Teacher teacher = new Teacher()
            {
                TeacherId = "GV001",
                TeacherName = "Nguyễn Trường Phát",
                YearOfBirth = 1985,
                Address = "Tp Hồ Chí Minh",
                IsActive = true
            };

            Subject subject = new Subject()
            {
                SubjectId = "MATH01",
                SubjectName = "Toán 1",
                NumberOfCredits = 3,
                TeacherId = teacher.TeacherId,
                IsActive = true
            };
            teacher.Subjects.Add(subject);            
            context.Teachers.Add(teacher);

            StudentSubject studentSubject = new StudentSubject()
            {
                Student = studentMT,
                Subject = subject
            };
            context.StudentSubjects.Add(studentSubject);
            context.SaveChanges();
        }
    }
}
