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
	public partial class TeacherManageCourseContents : Form
	{
		//Create Course Objects
		private CourseRepository courseRepo;
		private TeacherRepository teacherRepo;
		private static int currentTeacherId;
		private CourseChapterContentRepository contentRepo;
		private CourseChapterRepository chapterRepo;
		private string filePath = "";
		public TeacherManageCourseContents()
		{
			InitializeComponent();
		}

		private void TeacherManageCourseContents_Load(object sender, EventArgs e)
		{
			//Get the id of the current teacher
			currentTeacherId = 17;
			courseRepo = new CourseRepository();
			teacherRepo = new TeacherRepository();
			contentRepo = new CourseChapterContentRepository();
			chapterRepo = new CourseChapterRepository();
			Refresh();
			PopulateTypes();
		}

		private void Refresh()
		{
			//Show all courses related to the current teacher
			Teacher teacher = teacherRepo.GetTeacherById(currentTeacherId);
			List<Course> courses = courseRepo.GetCourseByTeacher(currentTeacherId);
			this.coursesComboBox.Items.Clear();

			foreach (var item in courses)
			{
				this.coursesComboBox.Items.Add(item.id + ", "+item.course_title);
			}

			foreach (var item in courses)
			{
				this.AddCoursesComboBox.Items.Add(item.id + ", " + item.course_title);
			}

		}

		private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (coursesComboBox.Items.Count > 0)
			{
				int index = 0;
				if (coursesComboBox.SelectedItem.ToString() != null)
					index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
				int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
				ShowChapters(courseId);
			}
		}

		private void ShowChapters(int id)
		{
			List<Course_Chapter> chapters = chapterRepo.GetCourseChaptersByCourseId(id);
			this.courseContentComboBox.Items.Clear();
			
			if (chapters.Count > 0)
			{
				foreach (var item in chapters)
				{
					courseContentComboBox.Items.Add(item.id + ", " + item.chapter_title);
				}
			}
			if(courseContentComboBox.SelectedIndex > 0)
			{
				int index = courseContentComboBox.SelectedItem.ToString().IndexOf(",");
				int chapterId = Convert.ToInt32(courseContentComboBox.SelectedItem.ToString().Substring(0, index));
				ShowContents(chapterId);
			}
		}

		private void ShowContents(int chapterId)
		{
			List<Course_Chapter_Content> contents = contentRepo.GetChapterContentsByChapterId(chapterId);

			this.contentsGRV.DataSource = null;
			if(contents.Count > 0)
			{
				contentsGRV.DataSource = contents;
				//Hide unnecessary columns
				contentsGRV.Columns[0].Visible = false;
				contentsGRV.Columns[6].Visible = false;
				contentsGRV.Columns[7].Visible = false;
			}
			
		}

		private void courseContentComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (courseContentComboBox.Items.Count > 0)
			{
				int index = 0;
				if (courseContentComboBox.SelectedItem.ToString() != null)
					index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
				int chapterId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
				ShowContents(chapterId);
			}
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				filePath = dialog.FileName;
			}
			this.lblLinkTest.Text = filePath;
		}

		private void ShowAddContentComboData(int id)
		{
			List<Course_Chapter> chapters = chapterRepo.GetCourseChaptersByCourseId(id);
			this.AddContentComboBox.Items.Clear();

			if (chapters.Count > 0)
			{
				foreach (var item in chapters)
				{
					AddContentComboBox.Items.Add(item.id + ", " + item.chapter_title);
				}
			}
		}

		private void AddCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (AddCoursesComboBox.Items.Count > 0)
			{
				int index = 0;
				if (AddCoursesComboBox.SelectedItem.ToString() != null)
					index = AddCoursesComboBox.SelectedItem.ToString().IndexOf(",");
				int chapterId = Convert.ToInt32(AddCoursesComboBox.SelectedItem.ToString().Substring(0, index));
				ShowAddContentComboData(chapterId);
			}
		}

		private void PopulateTypes()
		{
			ContentTypeRepository typeRepo = new ContentTypeRepository();
			List<Content_Type> types = typeRepo.GetAllContentTypes();
			typeComboBox.Items.Clear();
			foreach (var item in types)
			{
				typeComboBox.Items.Add(item.id + ", " + item.content_type1);
			}
		}
	}
}
