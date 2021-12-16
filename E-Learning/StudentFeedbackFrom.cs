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
	public partial class StudentFeedbackFrom : Form
	{
		//private StudentRepository studentRepo;
		private CourseRepository courseRepo;
		private TeacherRepository teacherRepo;
		private FeedbackRepository feedbackRepo;
		private StudentFeedbackRepository studentFeedbackRepo;
		private EnrollmentRepository enrollmentRepo;
		private static int studentId;

		public StudentFeedbackFrom()
		{
			InitializeComponent();
		}

		private void StudentFeedbackFrom_Load(object sender, EventArgs e)
		{
			//studentRepo = new StudentRepository();
			courseRepo = new CourseRepository();
			teacherRepo = new TeacherRepository();
			enrollmentRepo = new EnrollmentRepository();
			studentFeedbackRepo = new StudentFeedbackRepository();
			feedbackRepo = new FeedbackRepository();
			//studentId = Global.userId;
			studentId = 1;
			PopulateCourses();
		}

		//Populate couses 
		private void PopulateCourses()
		{
			List<Enrollment> enrollments = enrollmentRepo.GetEnrolmentsByStudentId(studentId);
			coursesComboBox.Items.Clear();
			Course course;
			foreach (var item in enrollments)
			{
				course = courseRepo.GetCourseById((int)item.course_id);
				coursesComboBox.Items.Add(course.id + ", " + course.course_title);
			}

			rateComboBox.Items.Clear();
			for (int i = 1; i < 6; i++)
			{
				rateComboBox.Items.Add(i);
			}
		}

		//Populate all teachers that teach the selected couse
		private void PopulateTeachers()
		{
			if (coursesComboBox.Text != null)
			{
				int index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
				int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
				Course course = courseRepo.GetCourseById(courseId);
				teachersComboBox.Items.Clear();
				Teacher teacher;
				List<Course> courses = courseRepo.GetTeachersByCourseId(courseId);
				foreach (var item in courses)
				{
					teacher = teacherRepo.GetTeacherById((int)item.tutor_id);
					teachersComboBox.Items.Add(teacher.id + ", " + teacher.first_name + " " + teacher.last_name);
				}
			}else
			{
				MessageBox.Show("Select A Course From Courses Drop Donw List");
			}
		}
		
		private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			teachersComboBox.Text = null;
			PopulateTeachers();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (coursesComboBox.SelectedItem != null && teachersComboBox.SelectedItem != null)
			{
				int index;
				//Get the course id
				index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
				int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
				//Get the tutor id
				index = teachersComboBox.SelectedItem.ToString().IndexOf(",");
				int teacherId = Convert.ToInt32(teachersComboBox.SelectedItem.ToString().Substring(0, index));
				//Create feedback obj
				Feedback feedback = new Feedback();
				feedback.feedback_title = txtTitle.Text;
				feedback.feedback_text = txtFeedback.Text;
				feedback.submission_date = DateTime.Now;
				Enrollment enrollment = enrollmentRepo.GetEnrollmentByStudentIdAndCourseId(studentId, courseId);
				feedback.enrollment_id = enrollment.id;
				if (rateComboBox.SelectedItem != null)
					feedback.rateing_score = Convert.ToInt32(rateComboBox.SelectedItem.ToString());
				feedbackRepo.Add(feedback);
				//create student feedback
				Student_Feedback studentFeedback = new Student_Feedback();
				studentFeedback.student_id = studentId;
				studentFeedback.feedback_id = feedback.id;
				studentFeedbackRepo.Add(studentFeedback);
				MessageBox.Show("Feedback was sent successfully");
			}else
			{
				MessageBox.Show("You cannot submit a feedback without content");
			}
			
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			StudentDashboardForm frm = new StudentDashboardForm();
			frm.Show();
			this.Hide();
		}
	}
}
