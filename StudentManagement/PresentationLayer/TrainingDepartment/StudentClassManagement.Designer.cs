namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class StudentClassManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLopSinhVienId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopSinhVien = new System.Windows.Forms.DataGridView();
            this.StudentClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtLopSinhVienId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(441, 525);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý lớp sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.shudhangshu_malakar_education_school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(122, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(234, 440);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 440);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLopSinhVienId
            // 
            this.txtLopSinhVienId.Location = new System.Drawing.Point(108, 360);
            this.txtLopSinhVienId.Margin = new System.Windows.Forms.Padding(4);
            this.txtLopSinhVienId.Name = "txtLopSinhVienId";
            this.txtLopSinhVienId.Size = new System.Drawing.Size(248, 26);
            this.txtLopSinhVienId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID lớp SV:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(108, 292);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(320, 28);
            this.cbKhoa.TabIndex = 2;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khoa:";
            // 
            // dgvLopSinhVien
            // 
            this.dgvLopSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentClassId,
            this.FacultyId});
            this.dgvLopSinhVien.Location = new System.Drawing.Point(482, 15);
            this.dgvLopSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLopSinhVien.Name = "dgvLopSinhVien";
            this.dgvLopSinhVien.RowHeadersWidth = 51;
            this.dgvLopSinhVien.RowTemplate.Height = 24;
            this.dgvLopSinhVien.Size = new System.Drawing.Size(501, 532);
            this.dgvLopSinhVien.TabIndex = 5;
            // 
            // StudentClassId
            // 
            this.StudentClassId.DataPropertyName = "StudentClassId";
            this.StudentClassId.HeaderText = "Tên lớp";
            this.StudentClassId.MinimumWidth = 6;
            this.StudentClassId.Name = "StudentClassId";
            this.StudentClassId.Width = 125;
            // 
            // FacultyId
            // 
            this.FacultyId.DataPropertyName = "FacultyId";
            this.FacultyId.HeaderText = "Mã khoa";
            this.FacultyId.MinimumWidth = 6;
            this.FacultyId.Name = "FacultyId";
            this.FacultyId.Width = 125;
            // 
            // StudentClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLopSinhVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentClassManagement";
            this.Text = "StudentClassManagement";
            this.Load += new System.EventHandler(this.StudentClassManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLopSinhVienId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyId;
    }
}