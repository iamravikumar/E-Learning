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
	public partial class StudentEmailForm : Form
	{
		private StudentEmailRepository studentEmailRepo;
		private TeacherStudentEmailRepository tsEmailRepo;
		private TeacherEmailRepository teacherEmailRepo;
		private static int studentId;

		public StudentEmailForm()
		{
			InitializeComponent();
		}

		private void StudentEmailForm_Load(object sender, EventArgs e)
		{
			studentId = Global.userId;
			studentEmailRepo = new StudentEmailRepository();
			tsEmailRepo = new TeacherStudentEmailRepository();
			teacherEmailRepo = new TeacherEmailRepository();
			PopulateTeachersIds();			
		}

		//populate teacher names
		private void PopulateTeachersIds()
		{
			TeacherRepository teacherRepo = new TeacherRepository();
			List<Teacher> teachers = teacherRepo.GetAllTeachers();
			toComboBox.Items.Clear();
			foreach (var item in teachers)
			{
				toComboBox.Items.Add(item.id + ", " + item.first_name + " " + item.last_name);
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				if (toComboBox.Text != null)
				{
					int index = toComboBox.SelectedItem.ToString().IndexOf(",");
					int teacherId = Convert.ToInt32(toComboBox.SelectedItem.ToString().Substring(0, index));
					Student_Email studentEmail = new Student_Email();
					studentEmail.email_to = toComboBox.SelectedItem.ToString();
					studentEmail.title = txtTitle.Text;
					studentEmail.text = txtContent.Text;
					studentEmail.send_date = DateTime.Now;
					// Add it to the database
					studentEmailRepo.Add(studentEmail);
					//create teacher student email record.
					Teacher_Email teacherEmail = new Teacher_Email();
					teacherEmail.teacher_id = teacherId;
					teacherEmailRepo.Add(teacherEmail);
					Teacher_Student_Email tsEmail = new Teacher_Student_Email();
					tsEmail.student_email_id = studentId;
					tsEmail.teacher_email_id = teacherEmail.id;
					tsEmailRepo.Add(tsEmail);
					MessageBox.Show("Email Was Sent Successfully", "Success Message");
				}else
				{
					MessageBox.Show("Select teacher name");
				}
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			StudentDashboardForm frm = new StudentDashboardForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
