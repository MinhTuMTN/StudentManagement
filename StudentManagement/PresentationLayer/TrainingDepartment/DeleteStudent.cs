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
    public partial class DeleteStudent : Form
    {
        private string studentIdDelete;
        public DeleteStudent()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            lblHoTen.ResetText();
            lblSearchResult.Text = "";
            string error = "";

            string studentId = txtMaSVSearch.Text;

            try
            {
                using (var context = new Context())
                {
                    BussinessStudent bussiness = new BussinessStudent();
                    Student student = bussiness.GetStudentById(studentId, ref error);

                    if (student != null)
                    {
                        btnDelete.Visible = true;
                        btnDelete.Enabled = true;
                        lblHoTen.Text = student.Name;
                        studentIdDelete = student.StudentId;
                    }
                    else
                        lblSearchResult.Text = "Không tìm thấy sinh viên này";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Bạn có chắc muốn xóa sinh viên {0} - {1} không?", lblHoTen.Text, studentIdDelete), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Cancel)
                return;

            try
            {
                string error = "";
                using (var context = new Context())
                {
                    BussinessStudent bussiness = new BussinessStudent();
                    int resultDelete = bussiness.DeleteStudent(studentIdDelete, ref error);
                    if(resultDelete > 0)
                        MessageBox.Show("Xóa thành công","Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
