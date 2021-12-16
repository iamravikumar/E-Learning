
namespace E_Learning
{
	partial class StudentFeedbackFrom
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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.coursesComboBox = new System.Windows.Forms.ComboBox();
			this.teachersComboBox = new System.Windows.Forms.ComboBox();
			this.txtFeedback = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.rateComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(28, 438);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(121, 35);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(178, 438);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(121, 35);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(468, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Course And Teacher Feedback Page";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(33, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Course";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(297, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Teacher";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(33, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "Feedback";
			// 
			// coursesComboBox
			// 
			this.coursesComboBox.FormattingEnabled = true;
			this.coursesComboBox.Location = new System.Drawing.Point(95, 80);
			this.coursesComboBox.Name = "coursesComboBox";
			this.coursesComboBox.Size = new System.Drawing.Size(171, 23);
			this.coursesComboBox.TabIndex = 6;
			this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
			// 
			// teachersComboBox
			// 
			this.teachersComboBox.FormattingEnabled = true;
			this.teachersComboBox.Location = new System.Drawing.Point(384, 78);
			this.teachersComboBox.Name = "teachersComboBox";
			this.teachersComboBox.Size = new System.Drawing.Size(171, 23);
			this.teachersComboBox.TabIndex = 7;
			// 
			// txtFeedback
			// 
			this.txtFeedback.Location = new System.Drawing.Point(121, 172);
			this.txtFeedback.Name = "txtFeedback";
			this.txtFeedback.Size = new System.Drawing.Size(436, 152);
			this.txtFeedback.TabIndex = 8;
			this.txtFeedback.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSend.Location = new System.Drawing.Point(434, 377);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(123, 36);
			this.btnSend.TabIndex = 9;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(33, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 21);
			this.label5.TabIndex = 10;
			this.label5.Text = "Title";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(95, 130);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(264, 23);
			this.txtTitle.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(33, 344);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(223, 21);
			this.label6.TabIndex = 12;
			this.label6.Text = "Rate Score, 5 is high 1 is low";
			// 
			// rateComboBox
			// 
			this.rateComboBox.FormattingEnabled = true;
			this.rateComboBox.Location = new System.Drawing.Point(262, 346);
			this.rateComboBox.Name = "rateComboBox";
			this.rateComboBox.Size = new System.Drawing.Size(121, 23);
			this.rateComboBox.TabIndex = 13;
			// 
			// StudentFeedbackFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 499);
			this.Controls.Add(this.rateComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtFeedback);
			this.Controls.Add(this.teachersComboBox);
			this.Controls.Add(this.coursesComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnBack);
			this.Name = "StudentFeedbackFrom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentFeedbackFrom";
			this.Load += new System.EventHandler(this.StudentFeedbackFrom_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox coursesComboBox;
		private System.Windows.Forms.ComboBox teachersComboBox;
		private System.Windows.Forms.RichTextBox txtFeedback;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox rateComboBox;
	}
}