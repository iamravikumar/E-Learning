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
	public partial class StudentDashboardForm : Form
	{
		private int id;
		private string password;

		public StudentDashboardForm()
		{
			InitializeComponent();
		}

		private void StudentDashboardForm_Load(object sender, EventArgs e)
		{

			//Get the name of the current user
			string fName = "";
			string lName = "";
			string email = Global.username;
			password = Global.password;

			StudentRepository studentRepo = new StudentRepository();
			List<Student> students = studentRepo.GetAllStudents();
			foreach (Student student in students)
			{
				if (student.email.Equals(email) && student.password.Equals(password))
				{
					fName = student.first_name;
					lName = student.last_name;
					id = student.id;
					Global.userId = id;
					break;
				}
			}

			this.lblCurrentUser.Text = fName + ", " + lName;

			//Hide change pwd section
			lblOldPwd.Visible = false;
			lblNewPwd.Visible = false;
			textBoxNewPwd.Visible = false;
			textBoxOldPwd.Visible = false;
			btnConfirmPwd.Visible = false;
		}

		private void btnChangePwd_Click(object sender, EventArgs e)
		{
			//Hide change pwd section
			lblOldPwd.Visible = true;
			lblNewPwd.Visible = true;
			textBoxNewPwd.Visible = true;
			textBoxOldPwd.Visible = true;
			btnConfirmPwd.Visible = true;
		}

		private void btnConfirmPwd_Click(object sender, EventArgs e)
		{
			StudentRepository studentRepo = new StudentRepository();
			Student student = studentRepo.GetAStudentById(id);
			if (textBoxOldPwd.Text.Equals(password))
			{
				student.password = textBoxNewPwd.Text;
				studentRepo.Update(student);
				MessageBox.Show("Password Updated Successfully");
			}
			else
			{
				MessageBox.Show("Invalid Old Password");
			}
		}

		private void btnViewCourses_Click(object sender, EventArgs e)
		{
			StudentViewCoursesForm frm = new StudentViewCoursesForm();
			frm.Show();
		}

		private void btnEmail_Click(object sender, EventArgs e)
		{
			StudentEmailForm frm = new StudentEmailForm();
			frm.Show();
		}

		private void btnFeedback_Click(object sender, EventArgs e)
		{
			StudentFeedbackFrom frm = new StudentFeedbackFrom();
			frm.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
