
namespace E_Learning
{
	partial class StudentEmailForm
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
			this.toComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// toComboBox
			// 
			this.toComboBox.FormattingEnabled = true;
			this.toComboBox.Location = new System.Drawing.Point(123, 69);
			this.toComboBox.Name = "toComboBox";
			this.toComboBox.Size = new System.Drawing.Size(353, 23);
			this.toComboBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 41);
			this.label1.TabIndex = 1;
			this.label1.Text = "Student Email Page";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(59, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "To";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(123, 128);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(353, 23);
			this.txtTitle.TabIndex = 6;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(123, 177);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(353, 136);
			this.txtContent.TabIndex = 7;
			this.txtContent.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSend.Location = new System.Drawing.Point(377, 328);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(99, 30);
			this.btnSend.TabIndex = 8;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(59, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Title";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(59, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Text";
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(59, 375);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(99, 30);
			this.btnBack.TabIndex = 13;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(189, 375);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(99, 30);
			this.btnExit.TabIndex = 14;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// StudentEmailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 433);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toComboBox);
			this.Name = "StudentEmailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentEmailForm";
			this.Load += new System.EventHandler(this.StudentEmailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox toComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.RichTextBox txtContent;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
	}
}