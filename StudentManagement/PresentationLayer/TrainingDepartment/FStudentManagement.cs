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
    public partial class FStudentManagement : Form
    {
        public FStudentManagement()
        {
            InitializeComponent();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.ShowDialog();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
        }
    }
}
