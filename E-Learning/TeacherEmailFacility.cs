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

	public partial class TeacherEmailFacility : Form
	{
		public Teacher teacher;
		public TeacherRepository teacherRepo;
		public StudentRepository studentRepo;
		public TeacherEmailRepository teacherEmailRepo;
		public TeacherStudentEmailRepository tsEmailRepo;
		public StudentEmailRepository studentEmailRepo;
		public static int teacherId;
		List<int> studentsIds;
		public TeacherEmailFacility()
		{
			InitializeComponent();
		}

		private void TeacherEmailFacility_Load(object sender, EventArgs e)
		{
			lblMessage.Text = null;
			teacherId = Global.userId;
			//teacherId = 17;
			teacherRepo = new TeacherRepository();
			teacher = teacherRepo.GetTeacherById(teacherId);
			studentRepo = new StudentRepository();
			teacherEmailRepo = new TeacherEmailRepository();
			tsEmailRepo = new TeacherStudentEmailRepository();
			studentEmailRepo = new StudentEmailRepository();

			// 1- Get All Courses Related To This Teacher
			CourseRepository courseRepo = new CourseRepository();
			List<Course> courses = courseRepo.GetCourseByTeacher(teacherId);
			// 2- Populate Students Assigned To This Teacher
			studentsIds = new List<int>();
			EnrollmentRepository enrolRepo = new EnrollmentRepository();
			List<Enrollment> enrolments = new List<Enrollment>();
			studentsIds.Clear();
			enrolments.Clear();

			foreach (var item in courses)
			{
				enrolments = enrolRepo.GetEnrolmentsByCourseId(item.id);
				foreach (var enrolment in enrolments)
				{
					studentsIds.Add((int)enrolment.student_id);
				}
			}
			// 3- Add Student Id to the student combo box
			List<Student> students = studentRepo.GetAllStudents();
			studentsComboBox.Items.Clear();
			foreach (var item in students)
			{
				if (studentsIds.Contains(item.id))
				{
					studentsComboBox.Items.Add(item.id + ", " + item.first_name + " " + item.last_name);
				}
			}
			
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			Teacher_Email email = new Teacher_Email();
			email.teacher_id = teacherId;
			Teacher_Student_Email tsEmail = new Teacher_Student_Email();
			Student_Email stuEmail = new Student_Email();
			tsEmail.teacher_email_id = email.id;
			//Get the email details
			email.text = txtContent.Text;
			email.title = txtTitle.Text;
			email.send_date = DateTime.Now;
			teacherEmailRepo.Add(email);

			if (allStudentCheckBox.Checked)
			{
				// Send Email To All Student In The Combo Box
				foreach (var item in studentsIds)
				{
					stuEmail.student_id = item;
					studentEmailRepo.Add(stuEmail);
					tsEmail.teacher_email_id = email.id;
					tsEmail.student_email_id = stuEmail.id;
					tsEmailRepo.Add(tsEmail);
				}
				lblMessage.Text = "Email Was Sent Successfully";
			}
			else
			{
				// Send Email To The Selected Studetn ID
				if (studentsComboBox.SelectedItem.ToString() != null)
				{
					int index = studentsComboBox.SelectedItem.ToString().IndexOf(",");
					int studentId = Convert.ToInt32(studentsComboBox.SelectedItem.ToString().Substring(0, index));
					stuEmail.student_id = studentId;
					studentEmailRepo.Add(stuEmail);
					tsEmail.teacher_email_id = email.id;
					tsEmail.student_email_id = stuEmail.id;
					tsEmailRepo.Add(tsEmail);
					lblMessage.Text = "Email Was Sent Successfully";
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			TeacherDashboardForm frm = new TeacherDashboardForm();
			frm.Show();
		}
		
	}
}
