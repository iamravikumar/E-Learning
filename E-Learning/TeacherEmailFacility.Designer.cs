
namespace E_Learning
{
	partial class TeacherEmailFacility
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.allStudentCheckBox = new System.Windows.Forms.CheckBox();
			this.studentsComboBox = new System.Windows.Forms.ComboBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Teacher Email Section";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(26, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "To:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(26, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Title:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(26, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Content";
			// 
			// allStudentCheckBox
			// 
			this.allStudentCheckBox.AutoSize = true;
			this.allStudentCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.allStudentCheckBox.Location = new System.Drawing.Point(387, 72);
			this.allStudentCheckBox.Name = "allStudentCheckBox";
			this.allStudentCheckBox.Size = new System.Drawing.Size(121, 25);
			this.allStudentCheckBox.TabIndex = 5;
			this.allStudentCheckBox.Text = "All Students";
			this.allStudentCheckBox.UseVisualStyleBackColor = true;
			// 
			// studentsComboBox
			// 
			this.studentsComboBox.FormattingEnabled = true;
			this.studentsComboBox.Location = new System.Drawing.Point(124, 72);
			this.studentsComboBox.Name = "studentsComboBox";
			this.studentsComboBox.Size = new System.Drawing.Size(238, 23);
			this.studentsComboBox.TabIndex = 6;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(124, 137);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(384, 23);
			this.txtTitle.TabIndex = 7;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(124, 193);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(384, 164);
			this.txtContent.TabIndex = 8;
			this.txtContent.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSend.Location = new System.Drawing.Point(387, 382);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(121, 38);
			this.btnSend.TabIndex = 9;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(32, 435);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(119, 38);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(171, 435);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 38);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMessage.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lblMessage.Location = new System.Drawing.Point(26, 382);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(76, 21);
			this.lblMessage.TabIndex = 12;
			this.lblMessage.Text = "Message";
			// 
			// TeacherEmailFacility
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 501);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.studentsComboBox);
			this.Controls.Add(this.allStudentCheckBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TeacherEmailFacility";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TeacherEmailFacility";
			this.Load += new System.EventHandler(this.TeacherEmailFacility_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox allStudentCheckBox;
		private System.Windows.Forms.ComboBox studentsComboBox;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.RichTextBox txtContent;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblMessage;
	}
}