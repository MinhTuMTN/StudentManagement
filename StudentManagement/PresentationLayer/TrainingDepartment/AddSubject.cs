using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BussinessLayer;
using StudentManagement.DataAccessLayer;

namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                string subjectId = txtMaMH.Text;
                string subjectName = txtTenMH.Text;
                string teacherId = cbTeacher.SelectedValue.ToString();
                int numberOfCredits = 0;

                try
                {
                    numberOfCredits = int.Parse(txtSoTC.Text.Trim());
                }
                catch 
                {
                    return;
                }

                BussinessSubject bussiness = new BussinessSubject();
                int result = bussiness.InsertSubject(subjectId, subjectName, numberOfCredits, teacherId, ref error);
                if (result > 0)
                    MessageBox.Show("Thêm môn học thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTeacher()
        {
            try
            {
                using(var context = new Context())
                {
                    var teachers = (from t in context.Teachers
                                   where t.IsActive == true
                                   select t).ToList();

                    cbTeacher.DataSource = teachers;
                    cbTeacher.ValueMember = "TeacherId";
                    cbTeacher.DisplayMember = "TeacherName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }
    }
}
