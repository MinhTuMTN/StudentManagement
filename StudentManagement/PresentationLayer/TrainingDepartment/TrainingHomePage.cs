using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    public partial class TrainingHomePage : Form
    {
        public TrainingHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FStudentManagement fStudent = new FStudentManagement();
            fStudent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherManagement teacher = new TeacherManagement();
            teacher.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubjectManagement subject = new SubjectManagement();
            subject.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacultyManagement fac = new FacultyManagement();
            fac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentClassManagement studentClass = new StudentClassManagement();
            studentClass.Show();
        }

        private void btnDKMH_Click(object sender, EventArgs e)
        {

        }
    }
}
