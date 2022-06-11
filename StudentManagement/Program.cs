using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;
using StudentManagement.PresentationLayer.TrainingDepartment;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BussinessLayer;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new Initializer());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CourseRegistrationManagement());
            /*
            BussinessStudent bussinessStudent = new BussinessStudent();
            BussinessSubject bussinessSubject = new BussinessSubject();
            BussinessStudentSubject bussinessStudentSubject = new BussinessStudentSubject();
            string error = "";
            using (var context = new Context())
            {
                var student1 = context.Students.Find("20110741");
                var student = context.Students.Find("20110748");

                //bussinessStudentSubject.AddSubject("20110748", "MATH01", ref error);

                //bussinessSubject.InsertSubject("MATH02","Toán 2", 2, "GV001", ref error);
                bussinessStudentSubject.AddSubject("20110748", "MATH02", ref error);

                bussinessStudent.TuitionPayment("20110748", "MATH02", ref error);

                bussinessStudentSubject.UpdateScore("20110748", "MATH01", 10, 10, ref error);
                float result = student.GPA;
                float tution = bussinessStudent.GetTuition("20110748", ref error);

            }

            using (var context = new Context())
            {
                var student = context.Students.Find("20110748");
            }
            */
        }
    }
}
