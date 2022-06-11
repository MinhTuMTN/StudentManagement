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
    public partial class FacultyManagement : Form
    {
        private bool update = false; 
        public FacultyManagement()
        {
            InitializeComponent();
        }

        private void LoadFaculty()
        {
            string error = "";
            BussinessFaculty bussiness = new BussinessFaculty();
            List<Faculty> faculties = bussiness.GetFaculty(ref error);
            if (faculties != null)
                dgvKhoa.DataSource = faculties;
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FacultyManagement_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            dgvKhoa.AutoGenerateColumns = false;
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            LoadFaculty();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BussinessFaculty bussiness = new BussinessFaculty();
            string error = "";
            string id = txtId.Text;
            string tenKhoa = txtTenKhoa.Text;
            if (!update)
            {
                if (bussiness.InsertFaculty(id, tenKhoa, ref error) > 0)
                {
                    MessageBox.Show(string.Format("Thêm khoa {0} thành công", tenKhoa), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFaculty();
                }
                else
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bussiness.UpdateFaculty(id, tenKhoa, ref error) > 0)
                {
                    MessageBox.Show(string.Format("Cập nhật khoa {0} thành công", tenKhoa), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFaculty();
                }
                else
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (update)
            {
                int currentRow = e.RowIndex;
                txtId.Text = dgvKhoa.Rows[currentRow].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[currentRow].Cells[1].Value.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            string text = radio.Text;
            if (text == "Cập nhật")
            {
                update = true;
                txtId.Enabled = false;
            }
            else
            {
                update = false;
                txtId.Enabled = true;
            }
            btnThem.Text = radio.Text.ToString();
        }

        private void txtTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnThem_Click(sender, e);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtTenKhoa.Focus();
        }
    }
}
