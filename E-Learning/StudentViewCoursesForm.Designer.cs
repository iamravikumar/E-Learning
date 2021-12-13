
namespace E_Learning
{
	partial class StudentViewCoursesForm
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
			this.contentGRV = new System.Windows.Forms.DataGridView();
			this.coursesComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chaptersComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.contentGRV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(332, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registered Courses Page";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(27, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Couses";
			// 
			// contentGRV
			// 
			this.contentGRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.contentGRV.Location = new System.Drawing.Point(127, 200);
			this.contentGRV.Name = "contentGRV";
			this.contentGRV.RowTemplate.Height = 25;
			this.contentGRV.Size = new System.Drawing.Size(532, 141);
			this.contentGRV.TabIndex = 2;
			// 
			// coursesComboBox
			// 
			this.coursesComboBox.FormattingEnabled = true;
			this.coursesComboBox.Location = new System.Drawing.Point(127, 89);
			this.coursesComboBox.Name = "coursesComboBox";
			this.coursesComboBox.Size = new System.Drawing.Size(245, 23);
			this.coursesComboBox.TabIndex = 3;
			this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(27, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Chapters";
			// 
			// chaptersComboBox
			// 
			this.chaptersComboBox.FormattingEnabled = true;
			this.chaptersComboBox.Location = new System.Drawing.Point(127, 144);
			this.chaptersComboBox.Name = "chaptersComboBox";
			this.chaptersComboBox.Size = new System.Drawing.Size(245, 23);
			this.chaptersComboBox.TabIndex = 5;
			this.chaptersComboBox.SelectedIndexChanged += new System.EventHandler(this.chaptersComboBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(27, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Content";
			// 
			// btnDownload
			// 
			this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDownload.Location = new System.Drawing.Point(549, 362);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(110, 31);
			this.btnDownload.TabIndex = 7;
			this.btnDownload.Text = "Download File";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(32, 397);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(110, 31);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(173, 397);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 31);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// StudentViewCoursesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 471);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chaptersComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.coursesComboBox);
			this.Controls.Add(this.contentGRV);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "StudentViewCoursesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentViewCoursesForm";
			this.Load += new System.EventHandler(this.StudentViewCoursesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.contentGRV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView contentGRV;
		private System.Windows.Forms.ComboBox coursesComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox chaptersComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnClose;
	}
}