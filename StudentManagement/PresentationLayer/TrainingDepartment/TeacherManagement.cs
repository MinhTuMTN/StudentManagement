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
    public partial class TeacherManagement : Form
    {
        public TeacherManagement()
        {
            InitializeComponent();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
        }

        private void btnUpdateGV_Click(object sender, EventArgs e)
        {
            UpdateTeacher updateTeacher = new UpdateTeacher();
            updateTeacher.ShowDialog();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DeleteTeacher deleteTeacher = new DeleteTeacher();
            deleteTeacher.ShowDialog();
        }
    }
}
