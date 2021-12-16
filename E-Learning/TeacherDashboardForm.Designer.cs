
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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnChangePwd
			// 
			this.btnChangePwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnChangePwd.Location = new System.Drawing.Point(41, 112);
			this.btnChangePwd.Name = "btnChangePwd";
			this.btnChangePwd.Size = new System.Drawing.Size(155, 39);
			this.btnChangePwd.TabIndex = 0;
			this.btnChangePwd.Text = "Change Password";
			this.btnChangePwd.UseVisualStyleBackColor = true;
			this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCurrentUser.Location = new System.Drawing.Point(12, 18);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(96, 37);
			this.lblCurrentUser.TabIndex = 1;
			this.lblCurrentUser.Text = "label1";
			// 
			// btnConfirmChange
			// 
			this.btnConfirmChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnConfirmChange.Location = new System.Drawing.Point(487, 225);
			this.btnConfirmChange.Name = "btnConfirmChange";
			this.btnConfirmChange.Size = new System.Drawing.Size(114, 35);
			this.btnConfirmChange.TabIndex = 2;
			this.btnConfirmChange.Text = "Confirm Change";
			this.btnConfirmChange.UseVisualStyleBackColor = true;
			this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
			// 
			// lblOldPwd
			// 
			this.lblOldPwd.AutoSize = true;
			this.lblOldPwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblOldPwd.Location = new System.Drawing.Point(349, 100);
			this.lblOldPwd.Name = "lblOldPwd";
			this.lblOldPwd.Size = new System.Drawing.Size(139, 19);
			this.lblOldPwd.TabIndex = 3;
			this.lblOldPwd.Text = "Enter Old Password";
			// 
			// lblNewPwd
			// 
			this.lblNewPwd.AutoSize = true;
			this.lblNewPwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblNewPwd.Location = new System.Drawing.Point(349, 159);
			this.lblNewPwd.Name = "lblNewPwd";
			this.lblNewPwd.Size = new System.Drawing.Size(145, 19);
			this.lblNewPwd.TabIndex = 4;
			this.lblNewPwd.Text = "Enter New Password";
			// 
			// textBoxOldPwd
			// 
			this.textBoxOldPwd.Location = new System.Drawing.Point(349, 122);
			this.textBoxOldPwd.Name = "textBoxOldPwd";
			this.textBoxOldPwd.Size = new System.Drawing.Size(252, 23);
			this.textBoxOldPwd.TabIndex = 5;
			// 
			// textBoxNewPwd
			// 
			this.textBoxNewPwd.Location = new System.Drawing.Point(349, 181);
			this.textBoxNewPwd.Name = "textBoxNewPwd";
			this.textBoxNewPwd.Size = new System.Drawing.Size(252, 23);
			this.textBoxNewPwd.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 331);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 15);
			this.label3.TabIndex = 7;
			// 
			// btnManageCourse
			// 
			this.btnManageCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnManageCourse.Location = new System.Drawing.Point(41, 225);
			this.btnManageCourse.Name = "btnManageCourse";
			this.btnManageCourse.Size = new System.Drawing.Size(209, 38);
			this.btnManageCourse.TabIndex = 8;
			this.btnManageCourse.Text = "Manage Course Contents";
			this.btnManageCourse.UseVisualStyleBackColor = true;
			this.btnManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
			// 
			// btnStudentReport
			// 
			this.btnStudentReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnStudentReport.Location = new System.Drawing.Point(41, 173);
			this.btnStudentReport.Name = "btnStudentReport";
			this.btnStudentReport.Size = new System.Drawing.Size(155, 35);
			this.btnStudentReport.TabIndex = 9;
			this.btnStudentReport.Text = "Email Facility";
			this.btnStudentReport.UseVisualStyleBackColor = true;
			this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(22, 308);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 38);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(121, 308);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 38);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// TeacherDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 365);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
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
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
	}
}