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
    public partial class StudentClassManagement : Form
    {
        public StudentClassManagement()
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
                dgvLopSinhVien.DataSource = studentClasses;
            else
                dgvLopSinhVien.DataSource = null;
        }
        private void StudentClassManagement_Load(object sender, EventArgs e)
        {
            dgvLopSinhVien.AutoGenerateColumns = false;
            LoadFaculty();
            LoadStudentClass(cbKhoa.SelectedValue.ToString());
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentClass(cbKhoa.SelectedValue.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string khoaId = cbKhoa.SelectedValue.ToString();
            string lopSinhVienId = txtLopSinhVienId.Text;

            string error = "";
            BussinessStudentClass bussiness = new BussinessStudentClass();
            if (bussiness.InsertStudentClass(lopSinhVienId, khoaId, ref error) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentClass(cbKhoa.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
