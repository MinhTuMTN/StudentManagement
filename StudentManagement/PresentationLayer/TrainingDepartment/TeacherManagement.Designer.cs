namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class TeacherManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.shudhangshu_malakar_education_school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(351, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateGV
            // 
            this.btnUpdateGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateGV.BackgroundImage")));
            this.btnUpdateGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateGV.Location = new System.Drawing.Point(36, 150);
            this.btnUpdateGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGV.Name = "btnUpdateGV";
            this.btnUpdateGV.Size = new System.Drawing.Size(297, 85);
            this.btnUpdateGV.TabIndex = 2;
            this.btnUpdateGV.Text = "                          Cập nhật thông tin\r\n                          giảng viê" +
    "n";
            this.btnUpdateGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateGV.UseVisualStyleBackColor = true;
            this.btnUpdateGV.Click += new System.EventHandler(this.btnUpdateGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaGV.BackgroundImage")));
            this.btnXoaGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaGV.Location = new System.Drawing.Point(36, 276);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(297, 85);
            this.btnXoaGV.TabIndex = 1;
            this.btnXoaGV.Text = "Xóa giảng viên";
            this.btnXoaGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemGV.BackgroundImage")));
            this.btnThemGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemGV.Location = new System.Drawing.Point(36, 32);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(297, 85);
            this.btnThemGV.TabIndex = 0;
            this.btnThemGV.Text = "Thêm giảng viên";
            this.btnThemGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // TeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateGV);
            this.Controls.Add(this.btnXoaGV);
            this.Controls.Add(this.btnThemGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherManagement";
            this.Text = "TeacherManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnUpdateGV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}