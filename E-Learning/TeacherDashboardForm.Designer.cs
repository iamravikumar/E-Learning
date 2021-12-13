
namespace E_Learning
{
	partial class TeacherDashboardForm
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
			this.btnChangePwd = new System.Windows.Forms.Button();
			this.lblCurrentUser = new System.Windows.Forms.Label();
			this.btnConfirmChange = new System.Windows.Forms.Button();
			this.lblOldPwd = new System.Windows.Forms.Label();
			this.lblNewPwd = new System.Windows.Forms.Label();
			this.textBoxOldPwd = new System.Windows.Forms.TextBox();
			this.textBoxNewPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnManageCourse = new System.Windows.Forms.Button();
			this.btnStudentReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnChangePwd
			// 
			this.btnChangePwd.Location = new System.Drawing.Point(66, 114);
			this.btnChangePwd.Name = "btnChangePwd";
			this.btnChangePwd.Size = new System.Drawing.Size(155, 55);
			this.btnChangePwd.TabIndex = 0;
			this.btnChangePwd.Text = "Change Password";
			this.btnChangePwd.UseVisualStyleBackColor = true;
			this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCurrentUser.Location = new System.Drawing.Point(83, 46);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(52, 21);
			this.lblCurrentUser.TabIndex = 1;
			this.lblCurrentUser.Text = "label1";
			// 
			// btnConfirmChange
			// 
			this.btnConfirmChange.Location = new System.Drawing.Point(405, 171);
			this.btnConfirmChange.Name = "btnConfirmChange";
			this.btnConfirmChange.Size = new System.Drawing.Size(150, 40);
			this.btnConfirmChange.TabIndex = 2;
			this.btnConfirmChange.Text = "Confirm Change";
			this.btnConfirmChange.UseVisualStyleBackColor = true;
			this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
			// 
			// lblOldPwd
			// 
			this.lblOldPwd.AutoSize = true;
			this.lblOldPwd.Location = new System.Drawing.Point(348, 107);
			this.lblOldPwd.Name = "lblOldPwd";
			this.lblOldPwd.Size = new System.Drawing.Size(109, 15);
			this.lblOldPwd.TabIndex = 3;
			this.lblOldPwd.Text = "Enter Old Password";
			// 
			// lblNewPwd
			// 
			this.lblNewPwd.AutoSize = true;
			this.lblNewPwd.Location = new System.Drawing.Point(348, 136);
			this.lblNewPwd.Name = "lblNewPwd";
			this.lblNewPwd.Size = new System.Drawing.Size(114, 15);
			this.lblNewPwd.TabIndex = 4;
			this.lblNewPwd.Text = "Enter New Password";
			// 
			// textBoxOldPwd
			// 
			this.textBoxOldPwd.Location = new System.Drawing.Point(468, 104);
			this.textBoxOldPwd.Name = "textBoxOldPwd";
			this.textBoxOldPwd.Size = new System.Drawing.Size(151, 23);
			this.textBoxOldPwd.TabIndex = 5;
			// 
			// textBoxNewPwd
			// 
			this.textBoxNewPwd.Location = new System.Drawing.Point(468, 133);
			this.textBoxNewPwd.Name = "textBoxNewPwd";
			this.textBoxNewPwd.Size = new System.Drawing.Size(151, 23);
			this.textBoxNewPwd.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 349);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 15);
			this.label3.TabIndex = 7;
			// 
			// btnManageCourse
			// 
			this.btnManageCourse.Location = new System.Drawing.Point(66, 192);
			this.btnManageCourse.Name = "btnManageCourse";
			this.btnManageCourse.Size = new System.Drawing.Size(155, 53);
			this.btnManageCourse.TabIndex = 8;
			this.btnManageCourse.Text = "Manage Course Contents";
			this.btnManageCourse.UseVisualStyleBackColor = true;
			this.btnManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
			// 
			// btnStudentReport
			// 
			this.btnStudentReport.Location = new System.Drawing.Point(66, 274);
			this.btnStudentReport.Name = "btnStudentReport";
			this.btnStudentReport.Size = new System.Drawing.Size(155, 53);
			this.btnStudentReport.TabIndex = 9;
			this.btnStudentReport.Text = "Email Facility";
			this.btnStudentReport.UseVisualStyleBackColor = true;
			this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
			// 
			// TeacherDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 384);
			this.Controls.Add(this.btnStudentReport);
			this.Controls.Add(this.btnManageCourse);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxNewPwd);
			this.Controls.Add(this.textBoxOldPwd);
			this.Controls.Add(this.lblNewPwd);
			this.Controls.Add(this.lblOldPwd);
			this.Controls.Add(this.btnConfirmChange);
			this.Controls.Add(this.lblCurrentUser);
			this.Controls.Add(this.btnChangePwd);
			this.Name = "TeacherDashboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TeacherDashboardForm";
			this.Load += new System.EventHandler(this.TeacherDashboardForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnChangePwd;
		private System.Windows.Forms.Label lblCurrentUser;
		private System.Windows.Forms.Button btnConfirmChange;
		private System.Windows.Forms.Label lblOldPwd;
		private System.Windows.Forms.Label lblNewPwd;
		private System.Windows.Forms.TextBox textBoxOldPwd;
		private System.Windows.Forms.TextBox textBoxNewPwd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnManageCourse;
		private System.Windows.Forms.Button btnStudentReport;
	}
}