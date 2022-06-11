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
    public partial class SubjectManagement : Form
    {
        public SubjectManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateSubject updateSubject = new UpdateSubject();
            updateSubject.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSubject deleteSubject = new DeleteSubject();
            deleteSubject.ShowDialog();
        }
    }
}
