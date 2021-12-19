using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_Learning.DAL;
using E_Learning.Business;
using System.Diagnostics;

namespace E_Learning
{
	public partial class StudentViewCoursesForm : Form
	{
		private CourseRepository courseRepo;
		private CourseChapterContentRepository contentRepo;
		private CourseChapterRepository chapterRepo;
		private EnrollmentRepository enrollmentRepo;
		private static int studentId;

		public StudentViewCoursesForm()
		{
			InitializeComponent();
		}

		private void StudentViewCoursesForm_Load(object sender, EventArgs e)
		{
			courseRepo = new CourseRepository();
			contentRepo = new CourseChapterContentRepository();
			chapterRepo = new CourseChapterRepository();
			enrollmentRepo = new EnrollmentRepository();
			studentId = Global.userId;
			PopulateUserCourses();
		}

		// Method to populate all enrolled courses
		private void PopulateUserCourses()
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
		// Method to populate list of chapters of a certain course.
		private void PopulateCourseChapters(int courseId)
		{
			chaptersComboBox.Items.Clear();
			List<Course_Chapter> chapters = chapterRepo.GetCourseChaptersByCourseId((int)courseId);
			foreach (var item in chapters)
			{
				chaptersComboBox.Items.Add(item.id + ", " + item.chapter_title);
			}
		}
		// Method to populate all chapter content of a certain chapter
		private void PopulateChapteContent(int chapterId)
		{
			contentGRV.DataSource = null;
			List<Course_Chapter_Content> contents = contentRepo.GetChapterContentsByChapterId(chapterId);
			contentGRV.DataSource = contents;
			// Hide Un-necessary Columns
			contentGRV.Columns[0].Visible = false;
			contentGRV.Columns[6].Visible = false;
			contentGRV.Columns[7].Visible = false;
		}

		private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
			int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
			PopulateCourseChapters(courseId);
		}

		private void chaptersComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = chaptersComboBox.SelectedItem.ToString().IndexOf(",");
			int chapterId = Convert.ToInt32(chaptersComboBox.SelectedItem.ToString().Substring(0, index));
			PopulateChapteContent(chapterId);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			
			StudentDashboardForm frm = new StudentDashboardForm();
			frm.Show();
			this.Hide();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			try
			{				
				//Get the file path from the data grid view
				int index = contentGRV.CurrentRow.Index;
				string url = contentGRV.Rows[index].Cells[4].Value.ToString();
				Process p = new Process();
				ProcessStartInfo ps = new ProcessStartInfo(url);
				p.StartInfo = ps;
				p.Start();
				/*OpenFileDialog openFile = new OpenFileDialog();
				openFile.FileName = url;
				openFile.OpenFile();*/
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
