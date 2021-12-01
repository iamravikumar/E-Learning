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
	public partial class TeacherDashboardForm : Form
	{
		private int id;
		private string password;

		public TeacherDashboardForm()
		{
			InitializeComponent();
		}

		private void TeacherDashboardForm_Load(object sender, EventArgs e)
		{
			//Get the name of the current user
			string fName = "";
			string lName = "";
			string email = Global.username;
			password = Global.password;

			TeacherRepository teacherRepo = new TeacherRepository();
			List<Teacher> teachers = teacherRepo.GetAllTeachers();
			foreach (Teacher teacher in teachers)
			{
				if (teacher.email.Equals(email) && teacher.password.Equals(password))
				{
					fName = teacher.first_name;
					lName = teacher.last_name;
					id = teacher.id;
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
			btnConfirmChange.Visible = false;
		}

		private void btnChangePwd_Click(object sender, EventArgs e)
		{
			//Hide change pwd section
			lblOldPwd.Visible = true;
			lblNewPwd.Visible = true;
			textBoxNewPwd.Visible = true;
			textBoxOldPwd.Visible = true;
			btnConfirmChange.Visible = true;			
		}

		private void btnConfirmChange_Click(object sender, EventArgs e)
		{
			TeacherRepository teacherRepo = new TeacherRepository();
			Teacher teacher = teacherRepo.GetTeacherById(id);
			if (textBoxOldPwd.Text.Equals(password))
			{
				teacher.password = textBoxNewPwd.Text;
				teacherRepo.Update(teacher);
				MessageBox.Show("Password Updated Successfully");
			}
			else
			{
				MessageBox.Show("Invalid Old Password");
			}
		}

		private void btnManageCourse_Click(object sender, EventArgs e)
		{
			TeacherManageCourseContents frm = new TeacherManageCourseContents();
			frm.Show();
		}
	}
}
