using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Learning
{
	public partial class MainLogingForm : Form
	{

		public MainLogingForm()
		{
			InitializeComponent();
		}

		private void btnAdmLogin_Click(object sender, EventArgs e)
		{
			Global.type = 1;
			AdminLoginForm frm = new AdminLoginForm();
			frm.Show();
			this.Hide();
		}

		private void btnTchLogin_Click(object sender, EventArgs e)
		{
			Global.type = 2;
			TeacherLoginForm frm = new TeacherLoginForm();
			frm.Show();
			this.Hide();
		}

		private void btnStdLogin_Click(object sender, EventArgs e)
		{
			Global.type = 3;
			StudentLoginForm frm = new StudentLoginForm();
			frm.Show();
			this.Hide();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			RegistrationForm frm = new RegistrationForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
