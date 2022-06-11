using StudentManagement.DataAccessLayer;
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
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    public partial class UpdateSubject : Form
    {
        public UpdateSubject()
        {
            InitializeComponent();
        }
        private void LoadTeacher()
        {
            try
            {
                using (var context = new Context())
                {
                    var teachers = (from teacher in context.Teachers
                                    select teacher).ToList();

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
        private void UpdateSubject_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }

        private void btnMaMHSearch_Click(object sender, EventArgs e)
        {
            lblSearchResult.Text = "";
            lblNumberOfCreditsError.Text = "";
            try
            {
                string error = "";
                string subjectIdSearch = txtMaMHSearch.Text;

                BussinessSubject bussiness = new BussinessSubject();
                Subject subjectSearch = bussiness.GetSubject(subjectIdSearch, ref error);

                if(subjectSearch != null)
                {
                    txtMaMH.Text = subjectSearch.SubjectId;
                    txtTenMH.Text = subjectSearch.SubjectName;
                    txtSoTC.Text = subjectSearch.NumberOfCredits.ToString();
                    cbTeacher.SelectedValue = subjectSearch.TeacherId;
                }
                else
                {
                    lblSearchResult.Text = "Không tồn tại";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lblNumberOfCreditsError.Text = "";
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
                    lblNumberOfCreditsError.Text = "Vui lòng nhập số nguyên";
                    return;
                }

                BussinessSubject bussiness = new BussinessSubject();
                int result = bussiness.UpdateSubject(subjectId, subjectName, numberOfCredits, teacherId, ref error);
                if (result > 0)
                    MessageBox.Show("Cập nhật môn học thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
