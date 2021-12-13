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
		private StudentRepository studentRepo;
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
			studentRepo = new StudentRepository();
			courseRepo = new CourseRepository();
			teacherRepo = new TeacherRepository();
			enrollmentRepo = new EnrollmentRepository();
			studentFeedbackRepo = new StudentFeedbackRepository();
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
		}

		//Populate all teachers that teach the selected couse
		private void PopulateTeachers(int courseId)
		{
			Course course = courseRepo.GetCourseById(courseId);
			teachersComboBox.Items.Clear();
			Teacher teacher;
			List<Course> courses = courseRepo.GetTeachersByCourseId(courseId);
			foreach (var item in courses)
			{
				teacher = teacherRepo.GetTeacherById((int)item.tutor_id);
				teachersComboBox.Items.Add(teacher.id + ", "+ teacher.first_name + " " + teacher.last_name);
			}
		}
		
		private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
			int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
			PopulateTeachers(courseId);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
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
				feedbackRepo.Add(feedback);
				//create student feedback
				Student_Feedback studentFeedback = new Student_Feedback();
				studentFeedback.student_id = studentId;
				studentFeedback.feedback_id = feedback.id;
				studentFeedbackRepo.Add(studentFeedback);
			}else
			{
				MessageBox.Show("You cannot submit a feedback without content");
			}
			
		}
	}
}
