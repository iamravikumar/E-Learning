
namespace E_Learning
{
	partial class StudentDashboardForm
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
			this.btnConfirmPwd = new System.Windows.Forms.Button();
			this.lblOldPwd = new System.Windows.Forms.Label();
			this.lblNewPwd = new System.Windows.Forms.Label();
			this.textBoxOldPwd = new System.Windows.Forms.TextBox();
			this.textBoxNewPwd = new System.Windows.Forms.TextBox();
			this.lblCurrentUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnChangePwd
			// 
			this.btnChangePwd.Location = new System.Drawing.Point(63, 72);
			this.btnChangePwd.Name = "btnChangePwd";
			this.btnChangePwd.Size = new System.Drawing.Size(127, 40);
			this.btnChangePwd.TabIndex = 0;
			this.btnChangePwd.Text = "Chagne Password";
			this.btnChangePwd.UseVisualStyleBackColor = true;
			this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
			// 
			// btnConfirmPwd
			// 
			this.btnConfirmPwd.Location = new System.Drawing.Point(604, 161);
			this.btnConfirmPwd.Name = "btnConfirmPwd";
			this.btnConfirmPwd.Size = new System.Drawing.Size(75, 23);
			this.btnConfirmPwd.TabIndex = 1;
			this.btnConfirmPwd.Text = "button2";
			this.btnConfirmPwd.UseVisualStyleBackColor = true;
			this.btnConfirmPwd.Click += new System.EventHandler(this.btnConfirmPwd_Click);
			// 
			// lblOldPwd
			// 
			this.lblOldPwd.AutoSize = true;
			this.lblOldPwd.Location = new System.Drawing.Point(463, 72);
			this.lblOldPwd.Name = "lblOldPwd";
			this.lblOldPwd.Size = new System.Drawing.Size(109, 15);
			this.lblOldPwd.TabIndex = 2;
			this.lblOldPwd.Text = "Enter Old Password";
			// 
			// lblNewPwd
			// 
			this.lblNewPwd.AutoSize = true;
			this.lblNewPwd.Location = new System.Drawing.Point(463, 113);
			this.lblNewPwd.Name = "lblNewPwd";
			this.lblNewPwd.Size = new System.Drawing.Size(114, 15);
			this.lblNewPwd.TabIndex = 3;
			this.lblNewPwd.Text = "Enter New Password";
			// 
			// textBoxOldPwd
			// 
			this.textBoxOldPwd.Location = new System.Drawing.Point(587, 72);
			this.textBoxOldPwd.Name = "textBoxOldPwd";
			this.textBoxOldPwd.Size = new System.Drawing.Size(159, 23);
			this.textBoxOldPwd.TabIndex = 4;
			// 
			// textBoxNewPwd
			// 
			this.textBoxNewPwd.Location = new System.Drawing.Point(587, 113);
			this.textBoxNewPwd.Name = "textBoxNewPwd";
			this.textBoxNewPwd.Size = new System.Drawing.Size(159, 23);
			this.textBoxNewPwd.TabIndex = 5;
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Location = new System.Drawing.Point(72, 24);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(38, 15);
			this.lblCurrentUser.TabIndex = 6;
			this.lblCurrentUser.Text = "label1";
			// 
			// StudentDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblCurrentUser);
			this.Controls.Add(this.textBoxNewPwd);
			this.Controls.Add(this.textBoxOldPwd);
			this.Controls.Add(this.lblNewPwd);
			this.Controls.Add(this.lblOldPwd);
			this.Controls.Add(this.btnConfirmPwd);
			this.Controls.Add(this.btnChangePwd);
			this.Name = "StudentDashboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentDashboardForm";
			this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnChangePwd;
		private System.Windows.Forms.Button btnConfirmPwd;
		private System.Windows.Forms.Label lblOldPwd;
		private System.Windows.Forms.Label lblNewPwd;
		private System.Windows.Forms.TextBox textBoxOldPwd;
		private System.Windows.Forms.TextBox textBoxNewPwd;
		private System.Windows.Forms.Label lblCurrentUser;
	}
}