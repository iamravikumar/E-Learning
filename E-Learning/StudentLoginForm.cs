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
	public partial class StudentLoginForm : Form
	{
		public StudentLoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = this.txtBoxEmail.Text;
			string password = this.txtBoxPassword.Text;

			Global.username = userName;
			Global.password = password;

			//look for admin account in the db
			StudentRepository studentRepo = new StudentRepository();
			List<Student> students = studentRepo.GetAllStudents();
			bool found = false;

			foreach (Student student in students)
			{
				if (student.email.Equals(userName) && student.password.Equals(password))
				{
					found = true;
					StudentDashboardForm frm = new StudentDashboardForm();
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
