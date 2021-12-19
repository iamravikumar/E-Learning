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
	public partial class AdminUploadDownloadInfoForm : Form
	{
		private static int adminId;
		Admin_Email email;
		AdminEmailRepository adminEmailRepo;

		public AdminUploadDownloadInfoForm()
		{
			InitializeComponent();
		}

		private void AdminUploadDownloadInfoForm_Load(object sender, EventArgs e)
		{
			adminId = Global.userId;
			adminEmailRepo = new AdminEmailRepository();
			email = new Admin_Email();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminDashboardForm frm = new AdminDashboardForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			//Get the email details
			email.admin_id = adminId;
			email.text = txtContent.Text;
			email.title = txtTitle.Text;
			email.send_date = DateTime.Now;
			adminEmailRepo.Add(email);

			Teacher_Student_Email tsEmail = new Teacher_Student_Email();

			Student_Email stuEmail = new Student_Email();
			StudentRepository studentRepo = new StudentRepository();
			StudentEmailRepository studentEmailRepo = new StudentEmailRepository();

			Teacher_Email teacherEmail = new Teacher_Email();
			TeacherRepository teacherRepo = new TeacherRepository();
			TeacherEmailRepository teacherEmailRepo = new TeacherEmailRepository();

			TeacherStudentEmailRepository tsEmailRepo = new TeacherStudentEmailRepository();

			List<int> studentsIds = studentRepo.GetAllStudentsIds();
			List<int> teachersIds = teacherRepo.GetAllTeachersIds();

			//Check if the selected the receivers

			if (studentsCheckBox.Checked)
			{
				// Send Email To All Student In The Combo Box
				foreach (var item in studentsIds)
				{
					stuEmail.student_id = item;
					stuEmail.send_date = DateTime.Now;
					stuEmail.email_from = adminId.ToString();
					studentEmailRepo.Add(stuEmail);

					tsEmail.admin_email_id = email.id;
					tsEmail.student_email_id = stuEmail.id;
					tsEmailRepo.Add(tsEmail);
				}
				MessageBox.Show("Email Was Sent Successfully");
			} else if (teachersCheckBox.Checked)
			{
				// Send Email To All Student In The Combo Box
				foreach (var item in teachersIds)
				{
					teacherEmail.teacher_id = item;
					teacherEmail.send_date = DateTime.Now;
					teacherEmail.email_from = adminId.ToString();
					teacherEmailRepo.Add(teacherEmail);

					tsEmail.admin_email_id = email.id;
					tsEmail.teacher_email_id = teacherEmail.id;
					tsEmailRepo.Add(tsEmail);
				}
				MessageBox.Show("Email Was Sent Successfully");
			}
				
			if (!teachersCheckBox.Checked && !studentsCheckBox.Checked)
			{
				MessageBox.Show("Please Select To Whom Send This Email");
			}
		}

		private void btnInbox_Click(object sender, EventArgs e)
		{
			AdminFeedbackInboxReport frm = new AdminFeedbackInboxReport();
			frm.Show();
			this.Hide();
		}
	}
}
