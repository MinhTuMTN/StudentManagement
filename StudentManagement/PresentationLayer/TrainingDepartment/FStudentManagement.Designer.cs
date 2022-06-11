namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class FStudentManagement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnUpdateSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.shudhangshu_malakar_education_school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(282, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackgroundImage = global::StudentManagement.Properties.Resources.DeleteStudent;
            this.btnXoaSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaSV.Location = new System.Drawing.Point(12, 231);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(222, 81);
            this.btnXoaSV.TabIndex = 2;
            this.btnXoaSV.Text = "Xóa sinh viên";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnUpdateSV
            // 
            this.btnUpdateSV.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateSV.BackgroundImage = global::StudentManagement.Properties.Resources.UpdateStudent;
            this.btnUpdateSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateSV.Location = new System.Drawing.Point(12, 132);
            this.btnUpdateSV.Name = "btnUpdateSV";
            this.btnUpdateSV.Size = new System.Drawing.Size(222, 81);
            this.btnUpdateSV.TabIndex = 1;
            this.btnUpdateSV.Text = "            Cập nhật thông tin \r\n            sinh viên";
            this.btnUpdateSV.UseVisualStyleBackColor = false;
            this.btnUpdateSV.Click += new System.EventHandler(this.btnUpdateSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackgroundImage = global::StudentManagement.Properties.Resources.AddStudentIcon;
            this.btnThemSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemSV.Location = new System.Drawing.Point(12, 32);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(222, 81);
            this.btnThemSV.TabIndex = 0;
            this.btnThemSV.Text = "Thêm Sinh Viên";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // FStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnUpdateSV);
            this.Controls.Add(this.btnThemSV);
            this.Name = "FStudentManagement";
            this.Text = "StudentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnUpdateSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}