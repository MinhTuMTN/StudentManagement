using StudentManagement.BussinessLayer;
using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;
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
    public partial class DeleteSubject : Form
    {
        private string subjectIdDelete;
        public DeleteSubject()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            lblSubjectDetail.ResetText();
            lblSearchResult.Text = "";
            string error = "";

            string subjectId = txtMaMHSearch.Text;

            try
            {
                using (var context = new Context())
                {
                    BussinessSubject bussiness = new BussinessSubject();
                    Subject subject = bussiness.GetSubject(subjectId, ref error);

                    if (subject != null)
                    {
                        btnDelete.Visible = true;
                        btnDelete.Enabled = true;
                        BussinessTeacher bussinessTeacher = new BussinessTeacher();
                        lblSubjectDetail.Text = String.Format("{0} - {1} - {2}"
                            , subject.SubjectName
                            , bussinessTeacher.GetTeacher(subject.TeacherId, ref error).TeacherName
                            , subject.NumberOfCredits);
                        subjectIdDelete = subject.SubjectId;
                    }
                    else
                        lblSearchResult.Text = "Không tìm thấy môn học này";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Bạn có chắc muốn xóa môn học {0} không?", lblSubjectDetail.Text), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;

            try
            {
                string error = "";
                using (var context = new Context())
                {
                    BussinessSubject bussiness = new BussinessSubject();
                    int resultDelete = bussiness.DeleteSubject(subjectIdDelete, ref error);
                    if (resultDelete > 0)
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
