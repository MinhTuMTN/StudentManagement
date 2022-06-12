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
    public partial class CourseRegistrationManagement : Form
    {
        private string studentId;
        public CourseRegistrationManagement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {            
            dgvMonHocChuaThanhToan.DataSource = null;
            dgvMonHocDaDK.DataSource = null;
            cbXoaMH.DataSource = null;
            cbThemMH.DataSource = null;

            lblDaThanhToan.Visible = false;

            lblDiemTB.ResetText();
            lblTongSoTinChi.ResetText();
            lblTongSoTinChiDau.ResetText();
            lblTongSoTinChiRot.ResetText();
            lblTongSoTinChiChuaThanhToan.ResetText();
            lblTongSoTien.ResetText();
            lblSearchResult.ResetText();
            lblHoTen.ResetText();
            lblKhoa.ResetText();
            lblMSSV.ResetText();

            string error = "";

            try
            {
                int tongSoTinChi = 0;
                int tongSoTinChiDau = 0;
                int tongSoTinChiChuaThanhToan = 0;
                float hocPhi = 0;
                using (var context = new Context())
                {
                    var student = context.Students.Find(studentId); 
                    foreach (StudentSubject studentSubject in student.StudentSubjects)
                    {
                        tongSoTinChi += studentSubject.Subject.NumberOfCredits;
                        if (studentSubject.Result)
                            tongSoTinChiDau += studentSubject.Subject.NumberOfCredits;
                        if (!studentSubject.IsPaid)
                            tongSoTinChiChuaThanhToan += studentSubject.Subject.NumberOfCredits;
                    }
                    BussinessStudent bussinessStudent = new BussinessStudent();
                    hocPhi = bussinessStudent.GetTuition(studentId, ref error);

                    lblTongSoTinChi.Text = tongSoTinChi.ToString();
                    lblTongSoTinChiDau.Text = tongSoTinChiDau.ToString();
                    lblTongSoTinChiRot.Text = (tongSoTinChi - tongSoTinChiDau).ToString();
                    lblTongSoTinChiChuaThanhToan.Text = tongSoTinChiChuaThanhToan.ToString();
                    lblTongSoTien.Text = hocPhi.ToString();
                    lblMSSV.Text = student.StudentId;
                    lblHoTen.Text = student.Name;
                    lblKhoa.Text = student.Faculty.FacultyName;
                    lblDiemTB.Text = student.GPA.ToString();

                    BussinessStudentSubject bussinessStudentSubject = new BussinessStudentSubject();

                    DataTable dataTable = bussinessStudentSubject.GetUnpaidCourse(studentId, ref error);
                    if (dataTable.Rows.Count > 0)
                    {
                        lblDaThanhToan.Visible = false;
                        dgvMonHocChuaThanhToan.DataSource = dataTable;
                    }
                    else
                        lblDaThanhToan.Visible = true;

                    DataTable dataTable1 = bussinessStudentSubject.GetRegistedCourse(studentId, ref error);
                    if (dataTable1.Rows.Count > 0)
                    {
                        dgvMonHocDaDK.DataSource = dataTable1;
                        cbXoaMH.DataSource = dataTable1;
                        cbXoaMH.DisplayMember = "TenMH";
                        cbXoaMH.ValueMember = "MaMH";
                    }

                    DataTable dataTable2 = bussinessStudentSubject.GetUnregistedCourse(studentId, ref error);
                    if(dataTable2.Rows.Count > 0)
                    {
                        cbThemMH.DataSource = dataTable2;
                        cbThemMH.DisplayMember = "TenMH";
                        cbThemMH.ValueMember = "MaMH";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentId = txtMSSVSearch.Text;
            try
            {
                using (var context = new Context())
                {
                    var student = context.Students.Find(studentId);
                    if (student == null)
                    {
                        lblSearchResult.Text = "Không tìm thấy sinh viên này";
                        return;
                    }

                    this.studentId = studentId.Trim();

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CourseRegistrationManagement_Load(object sender, EventArgs e)
        {
            lblDaThanhToan.Visible = false;
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            string tenMH = cbXoaMH.Text;
            DialogResult result = MessageBox.Show(string.Format("Bạn có chắc muốn xóa môn học {0} của sinh viên {1} không?",tenMH,studentId),"Xóa môn học", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
                return;

            string error = "";
            try
            {
                BussinessStudentSubject bussinessStudentSubject = new BussinessStudentSubject();
                bussinessStudentSubject.RemoveSubject(studentId, cbXoaMH.SelectedValue.ToString().Trim(), ref error);
                LoadData();
            }
            catch
            {
                MessageBox.Show(error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                BussinessStudentSubject bussinessStudentSubject = new BussinessStudentSubject();
                bussinessStudentSubject.AddSubject(studentId, cbThemMH.SelectedValue.ToString().Trim(), ref error);
                LoadData();
            }
            catch
            {
                MessageBox.Show(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string error = "";
            BussinessStudentSubject bussiness = new BussinessStudentSubject();
            foreach(DataGridViewRow data in dgvMonHocDaDK.Rows)
            {
                bussiness.UpdateScore(studentId,data.Cells[0].Value.ToString(), 
                    float.Parse(data.Cells[2].Value.ToString()), 
                    float.Parse(data.Cells[3].Value.ToString()), 
                    ref error);
            }
            LoadData();
        }

        private void CourseRegistrationManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }
    }
}
