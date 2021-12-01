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
	public partial class AdminDashboardForm : Form
	{
		public AdminDashboardForm()
		{
			InitializeComponent();
		}

		private void AdminDashboardForm_Load(object sender, EventArgs e)
		{
			//Get the name of the current user
			string fName = "";
			string lName = "";
			string email = Global.username;
			string password = Global.password;

			AdminRepository adminRepo = new AdminRepository();
			List<Admin> admins = adminRepo.GetAllAdmins();
			foreach (Admin admin in admins )
			{
				if(admin.email.Equals(email) && admin.password.Equals(password))
				{
					fName = admin.first_name;
					lName = admin.last_name;
					Global.userId = admin.id;
					break;
				}
			}

			this.lblCurrentUser.Text = fName + ", " + lName;
		}

		private void btnModifyCourses_Click(object sender, EventArgs e)
		{
			AdminModifyCoursesForm frm = new AdminModifyCoursesForm();
			frm.Show();
		}

		private void btnModifyBranches_Click(object sender, EventArgs e)
		{
			AdminModifyBranchesForm frm = new AdminModifyBranchesForm();
			frm.Show();
		}

		private void btnModifyStaffInfo_Click(object sender, EventArgs e)
		{
			AdminModifyStaffInfoForm frm = new AdminModifyStaffInfoForm();
			frm.Show();
		}

		private void btnUploadDownloadInfo_Click(object sender, EventArgs e)
		{
			AdminUploadDownloadInfoForm frm = new AdminUploadDownloadInfoForm();
			frm.Show();
		}

		private void btnFeedback_Click(object sender, EventArgs e)
		{
			AdminFeedback frm = new AdminFeedback();
			frm.Show();
		}
	}
}
