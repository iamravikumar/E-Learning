
namespace E_Learning
{
	partial class StudentLoginForm
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
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.txtBoxPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(18, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(414, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Your Email And Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(64, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(64, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(167, 95);
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.Size = new System.Drawing.Size(241, 23);
			this.txtBoxEmail.TabIndex = 3;
			// 
			// txtBoxPassword
			// 
			this.txtBoxPassword.Location = new System.Drawing.Point(167, 142);
			this.txtBoxPassword.Name = "txtBoxPassword";
			this.txtBoxPassword.Size = new System.Drawing.Size(241, 23);
			this.txtBoxPassword.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnLogin.Location = new System.Drawing.Point(312, 180);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 32);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(22, 246);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 36);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(129, 246);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(91, 36);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// StudentLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 307);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtBoxPassword);
			this.Controls.Add(this.txtBoxEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "StudentLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentLoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBoxEmail;
		private System.Windows.Forms.TextBox txtBoxPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
	}
}