using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_Learning.DAL;
using E_Learning.Business;

namespace E_Learning
{
	public partial class AdminLoginForm : Form
	{
		public AdminLoginForm()
		{
			InitializeComponent();
		}

		private void AdminLoginForm_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = this.txtBoxEmail.Text;
			string password = this.txtBoxPassword.Text;

			Global.username = userName;
			Global.password = password;

			//look for admin account in the db
			AdminRepository adminRepository = new AdminRepository();
			List<Admin> admins = adminRepository.GetAllAdmins();
			bool found = false;

			foreach (Admin admin in admins)
			{
				if (admin.email.Equals(userName) && admin.password.Equals(password))
				{
					found = true;
					AdminDashboardForm frm = new AdminDashboardForm();
					frm.Show();
					break;
				}
			}

			if (found == false) MessageBox.Show("Invalid Email or Password");
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			MainLogingForm frm = new MainLogingForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
