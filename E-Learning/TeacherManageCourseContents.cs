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
		Teacher teacher;

		public TeacherManageCourseContents()
		{
			InitializeComponent();
		}

		private void TeacherManageCourseContents_Load(object sender, EventArgs e)
		{
			//Get the id of the current teacher
			currentTeacherId = Global.userId;
			courseRepo = new CourseRepository();
			teacherRepo = new TeacherRepository();
			contentRepo = new CourseChapterContentRepository();
			chapterRepo = new CourseChapterRepository();
			RefreshPage();
			PopulateTypes();
		}

		private void RefreshPage()
		{
			//Show all courses related to the current teacher
			teacher = teacherRepo.GetTeacherById(currentTeacherId);
			List<Course> courses = courseRepo.GetCourseByTeacher(currentTeacherId);
			this.coursesComboBox.Items.Clear();
			this.AddCoursesComboBox.Items.Clear();
			this.contentsGRV.DataSource = null;
			this.courseContentComboBox.Items.Clear();
			foreach (var item in courses)
			{
				this.coursesComboBox.Items.Add(item.id + ", "+item.course_title);
				this.AddCoursesComboBox.Items.Add(item.id + ", " + item.course_title);
			}
			this.lblContentLink.Text = null;
		}

		private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.courseContentComboBox.Items.Clear();
			this.contentsGRV.DataSource = null;
			courseContentComboBox.SelectedValue = null;
			this.AddContentComboBox.Items.Clear();
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
			this.AddContentComboBox.Items.Clear();
			this.contentsGRV.DataSource = null;
			if (chapters.Count > 0)
			{
				foreach (var item in chapters)
				{
					courseContentComboBox.Items.Add(item.id + ", " + item.chapter_title);
					AddContentComboBox.Items.Add(item.id + ", " + item.chapter_title);
				}
			}
		}

		private void ShowContents(int chapterId)
		{
			List<Course_Chapter_Content> contents = contentRepo
													.GetChapterContentsByChapterId(chapterId);
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
			int index = 0;
			if (courseContentComboBox.SelectedItem.ToString() != null)
			{
				index = courseContentComboBox.SelectedItem.ToString().IndexOf(",");
				int chapterId = Convert.ToInt32(courseContentComboBox.SelectedItem.ToString().Substring(0, index));
				ShowContents(chapterId);
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

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				filePath = dialog.FileName;
			}
			this.lblContentLink.Text = filePath;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (contentsGRV.DataSource != null)
				{
					// 1- Get the selected content id
					int index = contentsGRV.CurrentRow.Index;
					//content id
					int contentId = Convert.ToInt32(contentsGRV.Rows[index].Cells[0].Value.ToString());
					Course_Chapter_Content content = contentRepo.GetCouserChapterContentById(contentId);
					// 2- Set the content properties
					content.content_name = contentsGRV.Rows[index].Cells[3].Value.ToString();
					content.content_link = contentsGRV.Rows[index].Cells[4].Value.ToString();
					if (contentsGRV.Rows[index].Cells[5].Value.ToString() != null)
						content.time_required_in_hour = Convert.ToDecimal(contentsGRV.Rows[index].Cells[5].Value.ToString());
					// 3- Update the content in the db
					contentRepo.Update(content);
					RefreshPage();
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString() + "\nNo data to be updated");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (contentsGRV.DataSource != null)
				{
					// 1- Get the selected content id
					int index = contentsGRV.CurrentRow.Index;
					//content id
					int contentId = Convert.ToInt32(contentsGRV.Rows[index].Cells[0].Value.ToString());
					// 2- Delete the content 
					contentRepo.Delete(contentId);
					// 3- Refresh the data view
					int courseIndex = courseContentComboBox.SelectedItem.ToString().IndexOf(",");
					int chapterId = Convert.ToInt32(courseContentComboBox.SelectedItem.ToString().Substring(0, courseIndex));
					ShowContents(chapterId);
				}
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString() + "\nNo data to be deleted");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Add a chapter to a course
		private void btnAddChapter_Click(object sender, EventArgs e)
		{
			try
			{
				// 1- Get the course Id
				int index = 0;
				if (coursesComboBox.SelectedItem.ToString() != null)
					index = coursesComboBox.SelectedItem.ToString().IndexOf(",");
				int courseId = Convert.ToInt32(coursesComboBox.SelectedItem.ToString().Substring(0, index));
				// 2- Create new chapter obj
				Course_Chapter chapter = new Course_Chapter();
				// 3- Get the values from the text fields
				chapter.course_id = courseId;
				chapter.chapter_title = txtTitle.Text;
				chapter.num_of_assignment = Convert.ToInt32(txtAssighnmentsNo.Text);
				// 4- Add the chapter to the db
				chapterRepo.Add(chapter);
				RefreshPage();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString() + "\nEnsure to fill all fields");
			}
		}

		// Add a content to a chapter 
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Course_Chapter_Content content = new Course_Chapter_Content();
				// Chapter
				int index = 0;
				if (AddContentComboBox.SelectedItem.ToString() != null)
					index = AddContentComboBox.SelectedItem.ToString().IndexOf(",");
				int contentId = Convert.ToInt32(AddContentComboBox.SelectedItem.ToString().Substring(0, index));
				content.course_chapter_id = contentId;
				// Title
				content.content_name = txtContentTitle.Text;
				// Path
				content.content_link = lblContentLink.Text;
				// Type
				int typeIndex = 0;
				if (typeComboBox.SelectedItem.ToString() != null)
					typeIndex = typeComboBox.SelectedItem.ToString().IndexOf(",");
				int typeId = Convert.ToInt32(typeComboBox.SelectedItem.ToString().Substring(0, typeIndex));
				content.content_type_id = typeId;
				// Add content to db
				contentRepo.Add(content);
				RefreshPage();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString() + "\nEnsure to fill all fields");
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			TeacherDashboardForm frm = new TeacherDashboardForm();
			frm.Show();
			this.Hide();
		}

		private void btnDeleteChapter_Click(object sender, EventArgs e)
		{
			try
			{
				if (courseContentComboBox.SelectedItem.ToString() != null)
				{
					int index = courseContentComboBox.SelectedItem.ToString().IndexOf(",");
					int chapterId = Convert.ToInt32(courseContentComboBox.SelectedItem.ToString().Substring(0, index));
					chapterRepo.Delete(chapterId);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString() + "\nNo data to be deleted");
			}
		}
	}
}
