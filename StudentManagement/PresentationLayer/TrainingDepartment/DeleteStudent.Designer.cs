namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class DeleteStudent
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
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.txtMaSVSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(172, 52);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 16);
            this.lblSearchResult.TabIndex = 49;
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.Location = new System.Drawing.Point(394, 26);
            this.btnSearchSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(122, 28);
            this.btnSearchSV.TabIndex = 48;
            this.btnSearchSV.Text = "Tìm kiếm";
            this.btnSearchSV.UseVisualStyleBackColor = true;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // txtMaSVSearch
            // 
            this.txtMaSVSearch.Location = new System.Drawing.Point(169, 26);
            this.txtMaSVSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSVSearch.Name = "txtMaSVSearch";
            this.txtMaSVSearch.Size = new System.Drawing.Size(192, 22);
            this.txtMaSVSearch.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Mã số sinh viên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(18, 88);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 16);
            this.lblHoTen.TabIndex = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 82);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 28);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 141);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnSearchSV);
            this.Controls.Add(this.txtMaSVSearch);
            this.Controls.Add(this.label10);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaSVSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnDelete;
    }
}