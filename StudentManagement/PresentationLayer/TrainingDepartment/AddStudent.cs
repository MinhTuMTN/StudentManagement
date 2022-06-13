using StudentManagement.BussinessLayer;
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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
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
        private void AddStudent_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            LoadStudentClass(cbKhoa.SelectedValue.ToString());
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentClass(cbKhoa.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                if (bussiness.InsertStudent(studentId, studentName, birthDate, sex, nation, address, yearOfAdmission, studentClassId, ref error) > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
