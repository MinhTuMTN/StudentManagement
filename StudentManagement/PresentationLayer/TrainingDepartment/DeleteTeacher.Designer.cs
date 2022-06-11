namespace StudentManagement.PresentationLayer.TrainingDepartment
{
    partial class DeleteTeacher
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.txtMaGVSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 79);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 35);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(22, 94);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 20);
            this.lblHoTen.TabIndex = 56;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(128, 49);
            this.lblSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 20);
            this.lblSearchResult.TabIndex = 55;
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.Location = new System.Drawing.Point(397, 15);
            this.btnSearchSV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(152, 35);
            this.btnSearchSV.TabIndex = 54;
            this.btnSearchSV.Text = "Tìm kiếm";
            this.btnSearchSV.UseVisualStyleBackColor = true;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // txtMaGVSearch
            // 
            this.txtMaGVSearch.Location = new System.Drawing.Point(129, 23);
            this.txtMaGVSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaGVSearch.Name = "txtMaGVSearch";
            this.txtMaGVSearch.Size = new System.Drawing.Size(239, 27);
            this.txtMaGVSearch.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Mã GV:";
            // 
            // DeleteTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 137);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnSearchSV);
            this.Controls.Add(this.txtMaGVSearch);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteTeacher";
            this.Text = "DeleteTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.TextBox txtMaGVSearch;
        private System.Windows.Forms.Label label10;
    }
}