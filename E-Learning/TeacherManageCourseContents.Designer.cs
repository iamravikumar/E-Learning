
namespace E_Learning
{
	partial class TeacherManageCourseContents
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
			this.coursesComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.courseContentComboBox = new System.Windows.Forms.ComboBox();
			this.contentsGRV = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddChapter = new System.Windows.Forms.Button();
			this.txtAssighnmentsNo = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.AddCoursesComboBox = new System.Windows.Forms.ComboBox();
			this.AddContentComboBox = new System.Windows.Forms.ComboBox();
			this.lblContentLink = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtContentTitle = new System.Windows.Forms.TextBox();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDeleteChapter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.contentsGRV)).BeginInit();
			this.SuspendLayout();
			// 
			// coursesComboBox
			// 
			this.coursesComboBox.FormattingEnabled = true;
			this.coursesComboBox.Location = new System.Drawing.Point(205, 55);
			this.coursesComboBox.Name = "coursesComboBox";
			this.coursesComboBox.Size = new System.Drawing.Size(314, 23);
			this.coursesComboBox.TabIndex = 0;
			this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Courses List";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Course Chapters List";
			// 
			// courseContentComboBox
			// 
			this.courseContentComboBox.FormattingEnabled = true;
			this.courseContentComboBox.Location = new System.Drawing.Point(205, 104);
			this.courseContentComboBox.Name = "courseContentComboBox";
			this.courseContentComboBox.Size = new System.Drawing.Size(314, 23);
			this.courseContentComboBox.TabIndex = 3;
			this.courseContentComboBox.SelectedIndexChanged += new System.EventHandler(this.courseContentComboBox_SelectedIndexChanged);
			// 
			// contentsGRV
			// 
			this.contentsGRV.AllowUserToOrderColumns = true;
			this.contentsGRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.contentsGRV.Location = new System.Drawing.Point(22, 184);
			this.contentsGRV.Name = "contentsGRV";
			this.contentsGRV.RowTemplate.Height = 25;
			this.contentsGRV.Size = new System.Drawing.Size(552, 148);
			this.contentsGRV.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Chapters Content";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(625, 622);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(128, 32);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add Content";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(21, 349);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(128, 34);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update Content";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(179, 349);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 34);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete Content";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(22, 184);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(0, 15);
			this.lblMessage.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(332, 30);
			this.label4.TabIndex = 10;
			this.label4.Text = "Course Content Details Section";
			// 
			// btnAddChapter
			// 
			this.btnAddChapter.Location = new System.Drawing.Point(625, 476);
			this.btnAddChapter.Name = "btnAddChapter";
			this.btnAddChapter.Size = new System.Drawing.Size(128, 35);
			this.btnAddChapter.TabIndex = 11;
			this.btnAddChapter.Text = "Add Chapter";
			this.btnAddChapter.UseVisualStyleBackColor = true;
			this.btnAddChapter.Click += new System.EventHandler(this.btnAddChapter_Click);
			// 
			// txtAssighnmentsNo
			// 
			this.txtAssighnmentsNo.Location = new System.Drawing.Point(540, 447);
			this.txtAssighnmentsNo.Name = "txtAssighnmentsNo";
			this.txtAssighnmentsNo.Size = new System.Drawing.Size(213, 23);
			this.txtAssighnmentsNo.TabIndex = 13;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(280, 447);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(213, 23);
			this.txtTitle.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(10, 401);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(269, 25);
			this.label5.TabIndex = 15;
			this.label5.Text = "Adding New Chapter Section";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 426);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "Course";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(280, 426);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Title";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(540, 426);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 15);
			this.label8.TabIndex = 18;
			this.label8.Text = "Assignments No";
			// 
			// AddCoursesComboBox
			// 
			this.AddCoursesComboBox.FormattingEnabled = true;
			this.AddCoursesComboBox.Location = new System.Drawing.Point(20, 447);
			this.AddCoursesComboBox.Name = "AddCoursesComboBox";
			this.AddCoursesComboBox.Size = new System.Drawing.Size(223, 23);
			this.AddCoursesComboBox.TabIndex = 19;
			// 
			// AddContentComboBox
			// 
			this.AddContentComboBox.FormattingEnabled = true;
			this.AddContentComboBox.Location = new System.Drawing.Point(15, 568);
			this.AddContentComboBox.Name = "AddContentComboBox";
			this.AddContentComboBox.Size = new System.Drawing.Size(223, 23);
			this.AddContentComboBox.TabIndex = 26;
			// 
			// lblContentLink
			// 
			this.lblContentLink.AutoSize = true;
			this.lblContentLink.Location = new System.Drawing.Point(15, 613);
			this.lblContentLink.Name = "lblContentLink";
			this.lblContentLink.Size = new System.Drawing.Size(55, 15);
			this.lblContentLink.TabIndex = 25;
			this.lblContentLink.Text = "FilePath: ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(275, 547);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 15);
			this.label10.TabIndex = 24;
			this.label10.Text = "Title";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(15, 547);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 15);
			this.label11.TabIndex = 23;
			this.label11.Text = "Chapter";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(10, 511);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(346, 25);
			this.label12.TabIndex = 22;
			this.label12.Text = "Adding New Chapter Content Section";
			// 
			// txtContentTitle
			// 
			this.txtContentTitle.Location = new System.Drawing.Point(275, 568);
			this.txtContentTitle.Name = "txtContentTitle";
			this.txtContentTitle.Size = new System.Drawing.Size(213, 23);
			this.txtContentTitle.TabIndex = 21;
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(520, 568);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(223, 23);
			this.typeComboBox.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(520, 547);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(31, 15);
			this.label13.TabIndex = 27;
			this.label13.Text = "Type";
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(15, 631);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(111, 23);
			this.btnUpload.TabIndex = 29;
			this.btnUpload.Text = "Upload A File";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(15, 715);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(139, 36);
			this.btnBack.TabIndex = 30;
			this.btnBack.Text = "Back To Dashbaord";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(205, 715);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(139, 36);
			this.btnExit.TabIndex = 31;
			this.btnExit.Text = "Quit ";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDeleteChapter
			// 
			this.btnDeleteChapter.Location = new System.Drawing.Point(331, 349);
			this.btnDeleteChapter.Name = "btnDeleteChapter";
			this.btnDeleteChapter.Size = new System.Drawing.Size(128, 34);
			this.btnDeleteChapter.TabIndex = 32;
			this.btnDeleteChapter.Text = "Delete Chapter";
			this.btnDeleteChapter.UseVisualStyleBackColor = true;
			this.btnDeleteChapter.Click += new System.EventHandler(this.btnDeleteChapter_Click);
			// 
			// TeacherManageCourseContents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 779);
			this.Controls.Add(this.btnDeleteChapter);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.AddContentComboBox);
			this.Controls.Add(this.lblContentLink);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtContentTitle);
			this.Controls.Add(this.AddCoursesComboBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtAssighnmentsNo);
			this.Controls.Add(this.btnAddChapter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.contentsGRV);
			this.Controls.Add(this.courseContentComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.coursesComboBox);
			this.Name = "TeacherManageCourseContents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TeacherManageCourseContents";
			this.Load += new System.EventHandler(this.TeacherManageCourseContents_Load);
			((System.ComponentModel.ISupportInitialize)(this.contentsGRV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox coursesComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox courseContentComboBox;
		private System.Windows.Forms.DataGridView contentsGRV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddChapter;
		private System.Windows.Forms.TextBox txtAssighnmentsNo;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox AddCoursesComboBox;
		private System.Windows.Forms.ComboBox AddContentComboBox;
		private System.Windows.Forms.Label lblContentLink;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtContentTitle;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDeleteChapter;
	}
}