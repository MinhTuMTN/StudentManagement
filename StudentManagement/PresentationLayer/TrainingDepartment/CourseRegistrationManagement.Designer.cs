namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class CourseRegistrationManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSVSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.dgvMonHocChuaThanhToan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongSoTinChi = new System.Windows.Forms.Label();
            this.lblTongSoTinChiDau = new System.Windows.Forms.Label();
            this.lblTongSoTinChiRot = new System.Windows.Forms.Label();
            this.lblTongSoTinChiChuaThanhToan = new System.Windows.Forms.Label();
            this.lblTongSoTien = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMonHocDaDK = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbThemMH = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.cbXoaMH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocChuaThanhToan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocDaDK)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // txtMSSVSearch
            // 
            this.txtMSSVSearch.Location = new System.Drawing.Point(77, 6);
            this.txtMSSVSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSSVSearch.Name = "txtMSSVSearch";
            this.txtMSSVSearch.Size = new System.Drawing.Size(266, 26);
            this.txtMSSVSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(378, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDaThanhToan);
            this.groupBox1.Controls.Add(this.dgvMonHocChuaThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(535, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học chưa thanh toán";
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaThanhToan.Location = new System.Drawing.Point(55, 100);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(441, 57);
            this.lblDaThanhToan.TabIndex = 1;
            this.lblDaThanhToan.Text = "Đã thanh toán học phí";
            // 
            // dgvMonHocChuaThanhToan
            // 
            this.dgvMonHocChuaThanhToan.AllowUserToAddRows = false;
            this.dgvMonHocChuaThanhToan.AllowUserToDeleteRows = false;
            this.dgvMonHocChuaThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMonHocChuaThanhToan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonHocChuaThanhToan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMonHocChuaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonHocChuaThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHocChuaThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaMH,
            this.TenMH,
            this.SoTC});
            this.dgvMonHocChuaThanhToan.Location = new System.Drawing.Point(7, 30);
            this.dgvMonHocChuaThanhToan.Name = "dgvMonHocChuaThanhToan";
            this.dgvMonHocChuaThanhToan.ReadOnly = true;
            this.dgvMonHocChuaThanhToan.RowHeadersWidth = 51;
            this.dgvMonHocChuaThanhToan.RowTemplate.Height = 24;
            this.dgvMonHocChuaThanhToan.Size = new System.Drawing.Size(517, 185);
            this.dgvMonHocChuaThanhToan.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Số thứ tự";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 105;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 130;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            this.TenMH.Width = 135;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.MinimumWidth = 6;
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            this.SoTC.Width = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số tín chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số tín chỉ đậu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số tín chỉ rớt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng số tín chỉ chưa thanh toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng số tiền chưa thanh toán:";
            // 
            // lblTongSoTinChi
            // 
            this.lblTongSoTinChi.AutoSize = true;
            this.lblTongSoTinChi.Location = new System.Drawing.Point(512, 89);
            this.lblTongSoTinChi.Name = "lblTongSoTinChi";
            this.lblTongSoTinChi.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChi.TabIndex = 9;
            // 
            // lblTongSoTinChiDau
            // 
            this.lblTongSoTinChiDau.AutoSize = true;
            this.lblTongSoTinChiDau.Location = new System.Drawing.Point(512, 123);
            this.lblTongSoTinChiDau.Name = "lblTongSoTinChiDau";
            this.lblTongSoTinChiDau.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiDau.TabIndex = 10;
            // 
            // lblTongSoTinChiRot
            // 
            this.lblTongSoTinChiRot.AutoSize = true;
            this.lblTongSoTinChiRot.Location = new System.Drawing.Point(512, 156);
            this.lblTongSoTinChiRot.Name = "lblTongSoTinChiRot";
            this.lblTongSoTinChiRot.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiRot.TabIndex = 11;
            // 
            // lblTongSoTinChiChuaThanhToan
            // 
            this.lblTongSoTinChiChuaThanhToan.AutoSize = true;
            this.lblTongSoTinChiChuaThanhToan.Location = new System.Drawing.Point(865, 123);
            this.lblTongSoTinChiChuaThanhToan.Name = "lblTongSoTinChiChuaThanhToan";
            this.lblTongSoTinChiChuaThanhToan.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiChuaThanhToan.TabIndex = 12;
            // 
            // lblTongSoTien
            // 
            this.lblTongSoTien.AutoSize = true;
            this.lblTongSoTien.Location = new System.Drawing.Point(865, 156);
            this.lblTongSoTien.Name = "lblTongSoTien";
            this.lblTongSoTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTien.TabIndex = 13;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(73, 36);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 20);
            this.lblSearchResult.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.dgvMonHocDaDK);
            this.groupBox2.Location = new System.Drawing.Point(6, 438);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(760, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn học đã đăng ký";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(557, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(664, 223);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 40);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMonHocDaDK
            // 
            this.dgvMonHocDaDK.AllowUserToAddRows = false;
            this.dgvMonHocDaDK.AllowUserToDeleteRows = false;
            this.dgvMonHocDaDK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMonHocDaDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonHocDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHocDaDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH1,
            this.TenMH1,
            this.DiemGK,
            this.DiemCK,
            this.DiemTK,
            this.KQ});
            this.dgvMonHocDaDK.Location = new System.Drawing.Point(13, 26);
            this.dgvMonHocDaDK.Name = "dgvMonHocDaDK";
            this.dgvMonHocDaDK.RowHeadersWidth = 51;
            this.dgvMonHocDaDK.RowTemplate.Height = 24;
            this.dgvMonHocDaDK.Size = new System.Drawing.Size(742, 191);
            this.dgvMonHocDaDK.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.cbThemMH);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(569, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 113);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đăng ký môn học";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(314, 79);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 26);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbThemMH
            // 
            this.cbThemMH.FormattingEnabled = true;
            this.cbThemMH.Location = new System.Drawing.Point(162, 34);
            this.cbThemMH.Name = "cbThemMH";
            this.cbThemMH.Size = new System.Drawing.Size(243, 28);
            this.cbThemMH.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Chọn môn học";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(113, 156);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(0, 20);
            this.lblKhoa.TabIndex = 22;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(113, 123);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 20);
            this.lblHoTen.TabIndex = 21;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(113, 89);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(0, 20);
            this.lblMSSV.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Khoa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Họ tên:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "MSSV:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaMH);
            this.groupBox3.Controls.Add(this.cbXoaMH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(569, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 125);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa môn học";
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(314, 79);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(91, 26);
            this.btnXoaMH.TabIndex = 23;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // cbXoaMH
            // 
            this.cbXoaMH.FormattingEnabled = true;
            this.cbXoaMH.Location = new System.Drawing.Point(162, 34);
            this.cbXoaMH.Name = "cbXoaMH";
            this.cbXoaMH.Size = new System.Drawing.Size(243, 28);
            this.cbXoaMH.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chọn môn học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(772, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Điểm trung bình";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(905, 471);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(0, 20);
            this.lblDiemTB.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.shudhangshu_malakar_education_school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(804, 531);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MaMH1
            // 
            this.MaMH1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaMH1.DataPropertyName = "MaMH";
            this.MaMH1.HeaderText = "Mã môn học";
            this.MaMH1.MinimumWidth = 6;
            this.MaMH1.Name = "MaMH1";
            this.MaMH1.ReadOnly = true;
            this.MaMH1.Width = 130;
            // 
            // TenMH1
            // 
            this.TenMH1.DataPropertyName = "TenMH";
            this.TenMH1.HeaderText = "Tên môn học";
            this.TenMH1.MinimumWidth = 6;
            this.TenMH1.Name = "TenMH1";
            this.TenMH1.ReadOnly = true;
            this.TenMH1.Width = 135;
            // 
            // DiemGK
            // 
            this.DiemGK.DataPropertyName = "DiemGK";
            this.DiemGK.HeaderText = "Điểm GK";
            this.DiemGK.MinimumWidth = 6;
            this.DiemGK.Name = "DiemGK";
            this.DiemGK.Width = 106;
            // 
            // DiemCK
            // 
            this.DiemCK.DataPropertyName = "DiemCK";
            this.DiemCK.HeaderText = "Điểm CK";
            this.DiemCK.MinimumWidth = 6;
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.Width = 105;
            // 
            // DiemTK
            // 
            this.DiemTK.DataPropertyName = "DiemTK";
            this.DiemTK.HeaderText = "Điểm TK";
            this.DiemTK.MinimumWidth = 6;
            this.DiemTK.Name = "DiemTK";
            this.DiemTK.ReadOnly = true;
            this.DiemTK.Width = 103;
            // 
            // KQ
            // 
            this.KQ.DataPropertyName = "KQ";
            this.KQ.HeaderText = "Kết quả";
            this.KQ.MinimumWidth = 6;
            this.KQ.Name = "KQ";
            this.KQ.ReadOnly = true;
            this.KQ.Width = 95;
            // 
            // CourseRegistrationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.lblTongSoTien);
            this.Controls.Add(this.lblTongSoTinChiChuaThanhToan);
            this.Controls.Add(this.lblTongSoTinChiRot);
            this.Controls.Add(this.lblTongSoTinChiDau);
            this.Controls.Add(this.lblTongSoTinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMSSVSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseRegistrationManagement";
            this.Text = "CourseRegistrationManagement";
            this.Load += new System.EventHandler(this.CourseRegistrationManagement_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CourseRegistrationManagement_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocChuaThanhToan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocDaDK)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSSVSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongSoTinChi;
        private System.Windows.Forms.Label lblTongSoTinChiDau;
        private System.Windows.Forms.Label lblTongSoTinChiRot;
        private System.Windows.Forms.Label lblTongSoTinChiChuaThanhToan;
        private System.Windows.Forms.Label lblTongSoTien;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.DataGridView dgvMonHocChuaThanhToan;
        private System.Windows.Forms.Label lblDaThanhToan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMonHocDaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbXoaMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbThemMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn KQ;
    }
}