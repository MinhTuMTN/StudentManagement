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
        public CourseRegistrationManagement()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblDaThanhToan.Visible = false;
            dgvMonHocChuaThanhToan.DataSource = null;
            lblTongSoTinChi.Text = "";
            lblTongSoTinChiDau.Text = "";
            lblTongSoTinChiRot.Text = "";
            lblTongSoTinChiChuaThanhToan.Text = "";
            lblTongSoTien.Text = "";
            lblSearchResult.ResetText(); 

            string error = "";
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

                    int tongSoTinChi = 0;
                    int tongSoTinChiDau = 0;
                    int tongSoTinChiChuaThanhToan = 0;
                    float hocPhi = 0;

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
                    if(dataTable1.Rows.Count > 0)
                        dgvMonHocDaDK.DataSource = dataTable1;
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
    }
}
