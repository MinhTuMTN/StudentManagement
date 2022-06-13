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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
            txtMaGV.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchGV_Click(object sender, EventArgs e)
        {
            lblYearOfBirthError.ResetText();
            lblSearchResult.Text = "";
            string error = "";

            string teacherId = txtMaGVSearch.Text;

            try
            {
                using (var context = new Context())
                {
                    BussinessTeacher bussiness = new BussinessTeacher();
                    Teacher teacher = bussiness.GetTeacher(teacherId, ref error);

                    if(teacher != null)
                    {
                        txtMaGV.Text = teacher.TeacherId;
                        txtHoTen.Text = teacher.TeacherName;
                        txtNamSinh.Text = teacher.YearOfBirth.ToString();
                        txtDiaChi.Text = teacher.Address;
                    }
                    else
                        lblSearchResult.Text = "Không tìm thấy giảng viên này";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblYearOfBirthError.ResetText();
            try
            {
                string error = "";
                string teacherId = txtMaGV.Text;
                string teacherName = txtHoTen.Text;
                string address = txtDiaChi.Text;
                int yearOfBirth = 0;
                try
                {
                    yearOfBirth = int.Parse(txtNamSinh.Text);
                }
                catch
                {
                    lblYearOfBirthError.Text = "Nhập đúng định dạng năm (số nguyên)";
                    return;
                }
                BussinessTeacher bussiness = new BussinessTeacher();
                int result = bussiness.UpdateTeacher(teacherId, teacherName, yearOfBirth, address, ref error);

                if(result > 0)
                    MessageBox.Show("Cập nhật thông tin thành công","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
