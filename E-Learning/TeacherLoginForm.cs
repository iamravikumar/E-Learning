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
	public partial class TeacherLoginForm : Form
	{
		public TeacherLoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string email = this.txtBoxEmail.Text;
			string password = this.txtBoxPassword.Text;

			Global.username = email;
			Global.password = password;

			TeacherRepository teacherRepo = new TeacherRepository();
			List<Teacher> teachers = teacherRepo.GetAllTeachers();

			bool found = false;
			foreach (Teacher teacher in teachers)
			{
				if (teacher.email.Equals(email) && teacher.password.Equals(password))
				{
					found = true;
					TeacherDashboardForm frm = new TeacherDashboardForm();
					frm.Show();
					break;
				}
			}
			if (found == false)
			{
				MessageBox.Show("Invalid Email or Password");
			}
		}
	}
}
