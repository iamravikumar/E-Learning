
namespace E_Learning
{
	partial class AdminModifyCoursesForm
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
			this.coursesGDV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnNewCourse = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblBrief = new System.Windows.Forms.Label();
			this.lblTeacher = new System.Windows.Forms.Label();
			this.lblFee = new System.Windows.Forms.Label();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.txtCourseBrief = new System.Windows.Forms.RichTextBox();
			this.txtCourseTitle = new System.Windows.Forms.TextBox();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.comboBoxTeacherId = new System.Windows.Forms.ComboBox();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.coursesGDV)).BeginInit();
			this.SuspendLayout();
			// 
			// coursesGDV
			// 
			this.coursesGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.coursesGDV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.coursesGDV.Location = new System.Drawing.Point(12, 58);
			this.coursesGDV.Name = "coursesGDV";
			this.coursesGDV.RowTemplate.Height = 25;
			this.coursesGDV.Size = new System.Drawing.Size(585, 150);
			this.coursesGDV.TabIndex = 0;
			this.coursesGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesGDV_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Courses Details";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(40, 229);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(102, 48);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete Course";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(165, 229);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(102, 48);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update Course";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnNewCourse
			// 
			this.btnNewCourse.Location = new System.Drawing.Point(296, 229);
			this.btnNewCourse.Name = "btnNewCourse";
			this.btnNewCourse.Size = new System.Drawing.Size(102, 48);
			this.btnNewCourse.TabIndex = 4;
			this.btnNewCourse.Text = "New Course";
			this.btnNewCourse.UseVisualStyleBackColor = true;
			this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(39, 321);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(69, 15);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Course Title";
			// 
			// lblBrief
			// 
			this.lblBrief.AutoSize = true;
			this.lblBrief.Location = new System.Drawing.Point(39, 368);
			this.lblBrief.Name = "lblBrief";
			this.lblBrief.Size = new System.Drawing.Size(71, 15);
			this.lblBrief.TabIndex = 6;
			this.lblBrief.Text = "Course Brief";
			// 
			// lblTeacher
			// 
			this.lblTeacher.AutoSize = true;
			this.lblTeacher.Location = new System.Drawing.Point(39, 471);
			this.lblTeacher.Name = "lblTeacher";
			this.lblTeacher.Size = new System.Drawing.Size(61, 15);
			this.lblTeacher.TabIndex = 7;
			this.lblTeacher.Text = "Teacher ID";
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Location = new System.Drawing.Point(39, 512);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(65, 15);
			this.lblFee.TabIndex = 8;
			this.lblFee.Text = "Course Fee";
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Location = new System.Drawing.Point(39, 552);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(59, 15);
			this.lblLanguage.TabIndex = 9;
			this.lblLanguage.Text = "Language";
			// 
			// txtCourseBrief
			// 
			this.txtCourseBrief.Location = new System.Drawing.Point(132, 368);
			this.txtCourseBrief.Name = "txtCourseBrief";
			this.txtCourseBrief.Size = new System.Drawing.Size(173, 84);
			this.txtCourseBrief.TabIndex = 10;
			this.txtCourseBrief.Text = "";
			// 
			// txtCourseTitle
			// 
			this.txtCourseTitle.Location = new System.Drawing.Point(132, 321);
			this.txtCourseTitle.Name = "txtCourseTitle";
			this.txtCourseTitle.Size = new System.Drawing.Size(173, 23);
			this.txtCourseTitle.TabIndex = 11;
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(132, 509);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(173, 23);
			this.txtFee.TabIndex = 12;
			// 
			// comboBoxTeacherId
			// 
			this.comboBoxTeacherId.FormattingEnabled = true;
			this.comboBoxTeacherId.Location = new System.Drawing.Point(132, 471);
			this.comboBoxTeacherId.Name = "comboBoxTeacherId";
			this.comboBoxTeacherId.Size = new System.Drawing.Size(173, 23);
			this.comboBoxTeacherId.TabIndex = 13;
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.FormattingEnabled = true;
			this.comboBoxLanguage.Location = new System.Drawing.Point(132, 552);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.Size = new System.Drawing.Size(173, 23);
			this.comboBoxLanguage.TabIndex = 14;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(330, 533);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(106, 42);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "Add Course";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(40, 600);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(38, 15);
			this.lblMessage.TabIndex = 16;
			this.lblMessage.Text = "label2";
			// 
			// AdminModifyCoursesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 634);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.comboBoxTeacherId);
			this.Controls.Add(this.txtFee);
			this.Controls.Add(this.txtCourseTitle);
			this.Controls.Add(this.txtCourseBrief);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.lblFee);
			this.Controls.Add(this.lblTeacher);
			this.Controls.Add(this.lblBrief);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnNewCourse);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.coursesGDV);
			this.Name = "AdminModifyCoursesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminModifyCoursesForm";
			this.Load += new System.EventHandler(this.AdminModifyCoursesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.coursesGDV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView coursesGDV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnNewCourse;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblBrief;
		private System.Windows.Forms.Label lblTeacher;
		private System.Windows.Forms.Label lblFee;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.RichTextBox txtCourseBrief;
		private System.Windows.Forms.TextBox txtCourseTitle;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.ComboBox comboBoxTeacherId;
		private System.Windows.Forms.ComboBox comboBoxLanguage;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblMessage;
	}
}