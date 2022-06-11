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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
            txtMSSV.Enabled = false;
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
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
                        txtMSSV.Text = student.StudentId;
                        txtHoTen.Text = student.Name;
                        dtNgaySinh.Value = student.BirthDate;
                        cbGioiTinh.Text = student.Sex;
                        txtDiaChi.Text = student.Address;
                        cbDanToc.Text = student.Nation;
                        txtNamNhapHoc.Text = student.YearOfAdmission.ToString();
                        cbKhoa.SelectedValue = student.FacultyId;
                        LoadStudentClass(student.FacultyId);
                        cbLopSinhVien.Text = student.StudentClassId;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadFaculty()
        {
            BussinessFaculty bussinessKhoa = new BussinessFaculty();
            string error = "";
            List<Faculty> lstKhoa = bussinessKhoa.GetFaculty(ref error);
            if (lstKhoa != null)
            {
                cbKhoa.DataSource = lstKhoa;
                cbKhoa.DisplayMember = "FacultyName";
                cbKhoa.ValueMember = "FacultyId";
            }
        }
        private void LoadStudentClass(string facultyId)
        {
            string error = "";
            BussinessStudentClass bussiness = new BussinessStudentClass();
            List<StudentClass> studentClasses = bussiness.GetStudentClasses(facultyId, ref error);
            if (studentClasses != null)
            {
                cbLopSinhVien.DataSource = studentClasses;
                cbLopSinhVien.DisplayMember = "StudentClassId";
                cbLopSinhVien.ValueMember = "StudentClassId";
            }
            else
                cbLopSinhVien.DataSource = null;
        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            LoadFaculty();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentClass(cbKhoa.SelectedValue.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                string studentId = txtMSSV.Text;
                string studentName = txtHoTen.Text;
                DateTime birthDate = dtNgaySinh.Value;
                string sex = cbGioiTinh.Text;
                string nation = cbDanToc.Text;
                int yearOfAdmission = int.Parse(txtNamNhapHoc.Text);
                string facultyId = cbKhoa.SelectedValue.ToString();
                string studentClassId = cbLopSinhVien.SelectedValue.ToString();
                string address = txtDiaChi.Text;

                BussinessStudent bussiness = new BussinessStudent();
                if (bussiness.UpdateStudent(studentId, studentName, birthDate, sex, nation, address, yearOfAdmission, facultyId, studentClassId, ref error) > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
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
