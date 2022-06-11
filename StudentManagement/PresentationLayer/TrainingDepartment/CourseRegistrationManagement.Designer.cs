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
            this.dgvMonHocChuaThanhToan = new System.Windows.Forms.DataGridView();
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
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMonHocDaDK = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MaMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocChuaThanhToan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocDaDK)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(553, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học chưa thanh toán";
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
            this.dgvMonHocChuaThanhToan.Size = new System.Drawing.Size(537, 185);
            this.dgvMonHocChuaThanhToan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số tín chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số tín chỉ đậu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số tín chỉ rớt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng số tín chỉ chưa thanh toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng số tiền chưa thanh toán:";
            // 
            // lblTongSoTinChi
            // 
            this.lblTongSoTinChi.AutoSize = true;
            this.lblTongSoTinChi.Location = new System.Drawing.Point(177, 79);
            this.lblTongSoTinChi.Name = "lblTongSoTinChi";
            this.lblTongSoTinChi.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChi.TabIndex = 9;
            // 
            // lblTongSoTinChiDau
            // 
            this.lblTongSoTinChiDau.AutoSize = true;
            this.lblTongSoTinChiDau.Location = new System.Drawing.Point(177, 114);
            this.lblTongSoTinChiDau.Name = "lblTongSoTinChiDau";
            this.lblTongSoTinChiDau.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiDau.TabIndex = 10;
            // 
            // lblTongSoTinChiRot
            // 
            this.lblTongSoTinChiRot.AutoSize = true;
            this.lblTongSoTinChiRot.Location = new System.Drawing.Point(177, 147);
            this.lblTongSoTinChiRot.Name = "lblTongSoTinChiRot";
            this.lblTongSoTinChiRot.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiRot.TabIndex = 11;
            // 
            // lblTongSoTinChiChuaThanhToan
            // 
            this.lblTongSoTinChiChuaThanhToan.AutoSize = true;
            this.lblTongSoTinChiChuaThanhToan.Location = new System.Drawing.Point(748, 114);
            this.lblTongSoTinChiChuaThanhToan.Name = "lblTongSoTinChiChuaThanhToan";
            this.lblTongSoTinChiChuaThanhToan.Size = new System.Drawing.Size(0, 20);
            this.lblTongSoTinChiChuaThanhToan.TabIndex = 12;
            // 
            // lblTongSoTien
            // 
            this.lblTongSoTien.AutoSize = true;
            this.lblTongSoTien.Location = new System.Drawing.Point(748, 147);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMonHocDaDK);
            this.groupBox2.Location = new System.Drawing.Point(596, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(560, 238);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn học đã đăng ký";
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
            this.btnDelete});
            this.dgvMonHocDaDK.Location = new System.Drawing.Point(7, 30);
            this.dgvMonHocDaDK.Name = "dgvMonHocDaDK";
            this.dgvMonHocDaDK.ReadOnly = true;
            this.dgvMonHocDaDK.RowHeadersWidth = 51;
            this.dgvMonHocDaDK.RowTemplate.Height = 24;
            this.dgvMonHocDaDK.Size = new System.Drawing.Size(537, 185);
            this.dgvMonHocDaDK.TabIndex = 0;
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
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(13, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1143, 389);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đăng ký môn học";
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
            this.TenMH1.Width = 200;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 125;
            // 
            // CourseRegistrationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 844);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseRegistrationManagement";
            this.Text = "CourseRegistrationManagement";
            this.Load += new System.EventHandler(this.CourseRegistrationManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocChuaThanhToan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocDaDK)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH1;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}