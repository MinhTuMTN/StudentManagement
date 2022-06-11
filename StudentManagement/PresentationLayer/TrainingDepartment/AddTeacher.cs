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

namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblYearOfBirthError.ResetText();
            try
            {
                BussinessTeacher bussiness = new BussinessTeacher();
                string error = "";

                string teacherId = txtMaGV.Text;
                string teacherName = txtHoTen.Text;
                string teacherAddress = txtDiaChi.Text;

                int teacherYearOfBirth = 0;
                try
                {
                    teacherYearOfBirth = int.Parse(txtNamSinh.Text);
                }
                catch (Exception ex)
                {
                    lblYearOfBirthError.Text = "Nhập đúng định dạng năm (số nguyên)";
                    return;
                }

                int result = bussiness.InsertTeacher(teacherId, teacherName, teacherYearOfBirth, teacherAddress, ref error);
                if (result > 0)
                    MessageBox.Show("Thêm giảng viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
