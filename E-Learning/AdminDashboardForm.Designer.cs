
namespace E_Learning
{
	partial class AdminDashboardForm
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
			this.btnModifyBranches = new System.Windows.Forms.Button();
			this.btnModifyCourses = new System.Windows.Forms.Button();
			this.btnModifyStaffInfo = new System.Windows.Forms.Button();
			this.btnUploadDownloadInfo = new System.Windows.Forms.Button();
			this.btnFeedback = new System.Windows.Forms.Button();
			this.lblCurrentUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnModifyBranches
			// 
			this.btnModifyBranches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnModifyBranches.Location = new System.Drawing.Point(103, 140);
			this.btnModifyBranches.Name = "btnModifyBranches";
			this.btnModifyBranches.Size = new System.Drawing.Size(167, 46);
			this.btnModifyBranches.TabIndex = 0;
			this.btnModifyBranches.Text = "Modify Branches";
			this.btnModifyBranches.UseVisualStyleBackColor = true;
			this.btnModifyBranches.Click += new System.EventHandler(this.btnModifyBranches_Click);
			// 
			// btnModifyCourses
			// 
			this.btnModifyCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnModifyCourses.Location = new System.Drawing.Point(313, 140);
			this.btnModifyCourses.Name = "btnModifyCourses";
			this.btnModifyCourses.Size = new System.Drawing.Size(167, 46);
			this.btnModifyCourses.TabIndex = 1;
			this.btnModifyCourses.Text = "Modify Courses";
			this.btnModifyCourses.UseVisualStyleBackColor = true;
			this.btnModifyCourses.Click += new System.EventHandler(this.btnModifyCourses_Click);
			// 
			// btnModifyStaffInfo
			// 
			this.btnModifyStaffInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnModifyStaffInfo.Location = new System.Drawing.Point(103, 225);
			this.btnModifyStaffInfo.Name = "btnModifyStaffInfo";
			this.btnModifyStaffInfo.Size = new System.Drawing.Size(167, 46);
			this.btnModifyStaffInfo.TabIndex = 2;
			this.btnModifyStaffInfo.Text = "Modify Staff Infromation";
			this.btnModifyStaffInfo.UseVisualStyleBackColor = true;
			this.btnModifyStaffInfo.Click += new System.EventHandler(this.btnModifyStaffInfo_Click);
			// 
			// btnUploadDownloadInfo
			// 
			this.btnUploadDownloadInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUploadDownloadInfo.Location = new System.Drawing.Point(313, 225);
			this.btnUploadDownloadInfo.Name = "btnUploadDownloadInfo";
			this.btnUploadDownloadInfo.Size = new System.Drawing.Size(167, 46);
			this.btnUploadDownloadInfo.TabIndex = 3;
			this.btnUploadDownloadInfo.Text = "Upload & Download Information";
			this.btnUploadDownloadInfo.UseVisualStyleBackColor = true;
			this.btnUploadDownloadInfo.Click += new System.EventHandler(this.btnUploadDownloadInfo_Click);
			// 
			// btnFeedback
			// 
			this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnFeedback.Location = new System.Drawing.Point(200, 299);
			this.btnFeedback.Name = "btnFeedback";
			this.btnFeedback.Size = new System.Drawing.Size(167, 46);
			this.btnFeedback.TabIndex = 4;
			this.btnFeedback.Text = "Feedback";
			this.btnFeedback.UseVisualStyleBackColor = true;
			this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCurrentUser.Location = new System.Drawing.Point(79, 61);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(52, 21);
			this.lblCurrentUser.TabIndex = 5;
			this.lblCurrentUser.Text = "label1";
			// 
			// AdminDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 408);
			this.Controls.Add(this.lblCurrentUser);
			this.Controls.Add(this.btnFeedback);
			this.Controls.Add(this.btnUploadDownloadInfo);
			this.Controls.Add(this.btnModifyStaffInfo);
			this.Controls.Add(this.btnModifyCourses);
			this.Controls.Add(this.btnModifyBranches);
			this.Name = "AdminDashboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminDashboardForm";
			this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnModifyBranches;
		private System.Windows.Forms.Button btnModifyCourses;
		private System.Windows.Forms.Button btnModifyStaffInfo;
		private System.Windows.Forms.Button btnUploadDownloadInfo;
		private System.Windows.Forms.Button btnFeedback;
		private System.Windows.Forms.Label lblCurrentUser;
	}
}