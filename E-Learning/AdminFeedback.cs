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
	public partial class AdminFeedback : Form
	{
		private CourseRepository courseRepo;
		private TeacherRepository teacherRepo;
		private StudentRepository studentRepo;
		private EnrollmentRepository enrollmentRepo;

		private List<Course> courses;
		private List<Teacher> teachers;
		private List<Student> students;
		private List<Enrollment> enrollments;

		private int selectedCourseId;
		private int enrollmentId;

		public AdminFeedback()
		{
			InitializeComponent();
			courseRepo = new CourseRepository();
			teacherRepo = new TeacherRepository();
			studentRepo = new StudentRepository();
			enrollmentRepo = new EnrollmentRepository();

			courses = courseRepo.GetAllCourses();
			teachers = teacherRepo.GetAllTeachers();
			students = studentRepo.GetAllStudents();
			enrollments = enrollmentRepo.GetAllEnrollments();
		}

		private void AdminFeedback_Load(object sender, EventArgs e)
		{
			RefreshPage();
		}

		private void btnSendFeedback_Click(object sender, EventArgs e)
		{
			//Create the needed objs for creating feedback
			// 1- Create feedback repository obj
			FeedbackRepository feedbackRepo = new FeedbackRepository();
			// 2- Create feedback obj and set its values to the current values
			Feedback feedback = new Feedback();
			//Check if the input fields are not null
			if(txtFeedbackTitle.Text != null && txtFeedbackContent.Text != null)
			{
				feedback.feedback_title = txtFeedbackTitle.Text;
				feedback.feedback_text = txtFeedbackContent.Text;
				feedback.enrollment_id = enrollmentId;
				feedback.submission_date = DateTime.Today;
				// 3- Add this feedback to the db
				feedbackRepo.Add(feedback);
				// 4- Create an Admin_Feedback reporsitory obj
				AdminFeedbackRepository adminFeedRepo = new AdminFeedbackRepository();
				// 5- Create admin feedback obj and set it value
				Admin_Feedback adminFeedback = new Admin_Feedback();
				adminFeedback.feedback_id = feedback.id;
				int adminId = Global.userId;
				if (adminId <= 0)
					adminFeedback.admin_id = null;
				else 
					adminFeedback.admin_id = adminId;

				// 6- Add this admin feedback to the db
				adminFeedRepo.Add(adminFeedback);
				MessageBox.Show("Feedback was added successfully");
			}
			else
			{
				MessageBox.Show("Feedback Title and Content Must Be Filled Before Adding Feedback");
			}
			
			
		}

		private void RefreshPage()
		{
			this.comboBoxCourseID.Items.Clear();
			this.comboBoxStudentsIds.Items.Clear();

			int id;
			string name;

			foreach (Course course in courses)
			{
				id = course.id;
				name = course.course_title;
				comboBoxCourseID.Items.Add(id + ", " + name);
			}
		}

		private void comboBoxCourseID_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowDetails();
		}

		private void ShowDetails()
		{
			//Get the course id from combo box 
			string courseId = comboBoxCourseID.SelectedItem.ToString();
			int index = courseId.IndexOf(", ");
			int id = Convert.ToInt32(courseId.Substring(0, index));
			selectedCourseId = id;

			string courseName = courseId.Substring(index + 1);
			txtCourseName.Text = courseName;

			Course course = courseRepo.GetCourseById(id);
			int tutorId = Convert.ToInt32(course.tutor_id);
			Teacher teacher = teacherRepo.GetTeacherById(tutorId);
			txtTutorName.Text = teacher.first_name + ", " + teacher.last_name;

			comboBoxStudentsIds.Items.Clear();

			//generate list of students who enrolled in this course
			foreach (Enrollment enrollment in enrollments)
			{
				if (enrollment.course_id == selectedCourseId)
				{
					//add student combo box
					comboBoxStudentsIds.Items.Add(enrollment.student_id);
					enrollmentId = enrollment.id;
				}
			}
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
	}
}
