namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class DeleteSubject
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSubjectDetail = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.txtMaMHSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 88);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 26);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSubjectDetail
            // 
            this.lblSubjectDetail.AutoSize = true;
            this.lblSubjectDetail.Location = new System.Drawing.Point(16, 88);
            this.lblSubjectDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectDetail.Name = "lblSubjectDetail";
            this.lblSubjectDetail.Size = new System.Drawing.Size(0, 20);
            this.lblSubjectDetail.TabIndex = 56;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(128, 64);
            this.lblSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 20);
            this.lblSearchResult.TabIndex = 55;
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.Location = new System.Drawing.Point(381, 26);
            this.btnSearchSV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(92, 28);
            this.btnSearchSV.TabIndex = 54;
            this.btnSearchSV.Text = "Tìm kiếm";
            this.btnSearchSV.UseVisualStyleBackColor = true;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // txtMaMHSearch
            // 
            this.txtMaMHSearch.Location = new System.Drawing.Point(132, 26);
            this.txtMaMHSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaMHSearch.Name = "txtMaMHSearch";
            this.txtMaMHSearch.Size = new System.Drawing.Size(239, 26);
            this.txtMaMHSearch.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Mã môn học:";
            // 
            // DeleteSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 132);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSubjectDetail);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnSearchSV);
            this.Controls.Add(this.txtMaMHSearch);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteSubject";
            this.Text = "DeleteSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSubjectDetail;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaMHSearch;
        private System.Windows.Forms.Label label10;
    }
}