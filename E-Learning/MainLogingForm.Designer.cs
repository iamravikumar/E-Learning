
namespace E_Learning
{
	partial class MainLogingForm
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
			this.btnStdLogin = new System.Windows.Forms.Button();
			this.btnTchLogin = new System.Windows.Forms.Button();
			this.btnAdmLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStdLogin
			// 
			this.btnStdLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnStdLogin.Location = new System.Drawing.Point(491, 185);
			this.btnStdLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnStdLogin.Name = "btnStdLogin";
			this.btnStdLogin.Size = new System.Drawing.Size(113, 40);
			this.btnStdLogin.TabIndex = 0;
			this.btnStdLogin.Text = "Student Login";
			this.btnStdLogin.UseVisualStyleBackColor = true;
			this.btnStdLogin.Click += new System.EventHandler(this.btnStdLogin_Click);
			// 
			// btnTchLogin
			// 
			this.btnTchLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTchLogin.Location = new System.Drawing.Point(277, 187);
			this.btnTchLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTchLogin.Name = "btnTchLogin";
			this.btnTchLogin.Size = new System.Drawing.Size(113, 38);
			this.btnTchLogin.TabIndex = 1;
			this.btnTchLogin.Text = "Teacher Login";
			this.btnTchLogin.UseVisualStyleBackColor = true;
			this.btnTchLogin.Click += new System.EventHandler(this.btnTchLogin_Click);
			// 
			// btnAdmLogin
			// 
			this.btnAdmLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdmLogin.Location = new System.Drawing.Point(70, 185);
			this.btnAdmLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdmLogin.Name = "btnAdmLogin";
			this.btnAdmLogin.Size = new System.Drawing.Size(113, 40);
			this.btnAdmLogin.TabIndex = 2;
			this.btnAdmLogin.Text = "Admin Login";
			this.btnAdmLogin.UseVisualStyleBackColor = true;
			this.btnAdmLogin.Click += new System.EventHandler(this.btnAdmLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(147, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 57);
			this.label1.TabIndex = 3;
			this.label1.Text = "E-Learning Platform";
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnRegister.Location = new System.Drawing.Point(277, 300);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(113, 38);
			this.btnRegister.TabIndex = 4;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// MainLogingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 403);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdmLogin);
			this.Controls.Add(this.btnTchLogin);
			this.Controls.Add(this.btnStdLogin);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainLogingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainLogingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStdLogin;
		private System.Windows.Forms.Button btnTchLogin;
		private System.Windows.Forms.Button btnAdmLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegister;
	}
}