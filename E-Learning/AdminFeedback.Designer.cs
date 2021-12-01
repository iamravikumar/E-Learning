
namespace E_Learning
{
	partial class AdminFeedback
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
			this.btnSendFeedback = new System.Windows.Forms.Button();
			this.txtFeedbackContent = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFeedbackTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxStudentsIds = new System.Windows.Forms.ComboBox();
			this.comboBoxCourseID = new System.Windows.Forms.ComboBox();
			this.txtTutorName = new System.Windows.Forms.TextBox();
			this.txtCourseName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSendFeedback
			// 
			this.btnSendFeedback.Location = new System.Drawing.Point(203, 500);
			this.btnSendFeedback.Name = "btnSendFeedback";
			this.btnSendFeedback.Size = new System.Drawing.Size(133, 36);
			this.btnSendFeedback.TabIndex = 0;
			this.btnSendFeedback.Text = "Send Feedback";
			this.btnSendFeedback.UseVisualStyleBackColor = true;
			this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
			// 
			// txtFeedbackContent
			// 
			this.txtFeedbackContent.Location = new System.Drawing.Point(138, 287);
			this.txtFeedbackContent.Name = "txtFeedbackContent";
			this.txtFeedbackContent.Size = new System.Drawing.Size(298, 184);
			this.txtFeedbackContent.TabIndex = 1;
			this.txtFeedbackContent.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 287);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Feedback Content";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Feedback Title";
			// 
			// txtFeedbackTitle
			// 
			this.txtFeedbackTitle.Location = new System.Drawing.Point(138, 242);
			this.txtFeedbackTitle.Name = "txtFeedbackTitle";
			this.txtFeedbackTitle.Size = new System.Drawing.Size(298, 23);
			this.txtFeedbackTitle.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Course ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Course Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tutor Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Students IDs";
			// 
			// comboBoxStudentsIds
			// 
			this.comboBoxStudentsIds.FormattingEnabled = true;
			this.comboBoxStudentsIds.Location = new System.Drawing.Point(138, 196);
			this.comboBoxStudentsIds.Name = "comboBoxStudentsIds";
			this.comboBoxStudentsIds.Size = new System.Drawing.Size(298, 23);
			this.comboBoxStudentsIds.TabIndex = 9;
			// 
			// comboBoxCourseID
			// 
			this.comboBoxCourseID.FormattingEnabled = true;
			this.comboBoxCourseID.Location = new System.Drawing.Point(138, 78);
			this.comboBoxCourseID.Name = "comboBoxCourseID";
			this.comboBoxCourseID.Size = new System.Drawing.Size(298, 23);
			this.comboBoxCourseID.TabIndex = 10;
			this.comboBoxCourseID.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseID_SelectedIndexChanged);
			// 
			// txtTutorName
			// 
			this.txtTutorName.Location = new System.Drawing.Point(138, 156);
			this.txtTutorName.Name = "txtTutorName";
			this.txtTutorName.Size = new System.Drawing.Size(298, 23);
			this.txtTutorName.TabIndex = 11;
			// 
			// txtCourseName
			// 
			this.txtCourseName.Location = new System.Drawing.Point(138, 118);
			this.txtCourseName.Name = "txtCourseName";
			this.txtCourseName.Size = new System.Drawing.Size(298, 23);
			this.txtCourseName.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(34, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(220, 30);
			this.label7.TabIndex = 13;
			this.label7.Text = "Give Feedback Page";
			// 
			// AdminFeedback
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 559);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCourseName);
			this.Controls.Add(this.txtTutorName);
			this.Controls.Add(this.comboBoxCourseID);
			this.Controls.Add(this.comboBoxStudentsIds);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFeedbackTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFeedbackContent);
			this.Controls.Add(this.btnSendFeedback);
			this.Name = "AdminFeedback";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminFeedback";
			this.Load += new System.EventHandler(this.AdminFeedback_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSendFeedback;
		private System.Windows.Forms.RichTextBox txtFeedbackContent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFeedbackTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxStudentsIds;
		private System.Windows.Forms.ComboBox comboBoxCourseID;
		private System.Windows.Forms.TextBox txtTutorName;
		private System.Windows.Forms.TextBox txtCourseName;
		private System.Windows.Forms.Label label7;
	}
}