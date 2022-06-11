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
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrainingHomePage());
            */
            BussinessStudent bussinessStudent = new BussinessStudent();
            string error = "";
            using(var context = new Context())
            {
                var student1 = context.Students.Find("20110741");
                var student = context.Students.Find("20110748");

                //bussinessStudent.AddSubject("20110748", "MATH01", ref error);
                int result = bussinessStudent.UpdateScoreGK("20110748","MATH01", 10.5f, ref error);
            }

        }
    }
}
