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
	public partial class AdminModifyCoursesForm : Form
	{
		public Course course;
		public CourseRepository courseRepo;

		public AdminModifyCoursesForm()
		{
			InitializeComponent();
		}

		private void AdminModifyCoursesForm_Load(object sender, EventArgs e)
		{
			this.coursesGDV.EditMode = DataGridViewEditMode.EditOnEnter;
			this.coursesGDV.ReadOnly = false;
			RefreshTable();
		}

		private void RefreshTable()
		{
			//Generate list of all courses
			courseRepo = new CourseRepository();
			List<Course> courses = courseRepo.GetAllCourses();
			//Clear the data grid view before adding the list items
			this.coursesGDV.DataSource = null;
			//add courses to the data grid view
			this.coursesGDV.DataSource = courses;

			//Hide un-neccessary table
			this.coursesGDV.Columns[0].Visible = false;
			this.coursesGDV.Columns[6].Visible = false;
			this.coursesGDV.Columns[7].Visible = false;

			if(coursesGDV.Rows.Count > 0)
			{
				//selete the first row by defualt
				coursesGDV.Rows[0].Selected = true;
				ShowCourseDetails(0);
			}

			//Hide add section
			this.lblBrief.Visible = false;
			this.lblFee.Visible = false;
			this.lblLanguage.Visible = false;
			this.lblMessage.Visible = false;
			this.lblTeacher.Visible = false;
			this.lblTitle.Visible = false;
			this.lblMessage.Visible = false;

			this.txtCourseBrief.Visible = false;
			this.txtCourseTitle.Visible = false;
			this.txtFee.Visible = false;
			this.comboBoxLanguage.Visible = false;
			this.comboBoxTeacherId.Visible = false;
			this.btnAdd.Visible = false;
		}

		private void ShowCourseDetails(int rowIndex)
		{
			coursesGDV.CurrentCell = coursesGDV.Rows[rowIndex].Cells[1];
		}

		private void btnNewCourse_Click(object sender, EventArgs e)
		{
			//clear teacher id combo box 
			this.comboBoxTeacherId.Items.Clear();
			//add Teacher id combo box
			TeacherRepository teacherRepo = new TeacherRepository();
			List<Teacher> teachers = teacherRepo.GetAllTeachers();

			foreach (Teacher teacher in teachers)
			{
				//comboBoxTeacherId.Items.Add(teacher.id + ", " + teacher.first_name+ " "+ teacher.last_name);
				comboBoxTeacherId.Items.Add(teacher.id);
			}

			//clear language combo box 
			this.comboBoxLanguage.Items.Clear();
			//Language combo box 
			LanguageRepository languageRepo = new LanguageRepository();
			List<Language> languages = languageRepo.GetAllLanguages();
			foreach (Language language in languages)
			{
				comboBoxLanguage.Items.Add(language.id + ", " + language.language_name);
			}

			//Show add section
			this.lblBrief.Visible = true;
			this.lblFee.Visible = true;
			this.lblLanguage.Visible = true;
			this.lblMessage.Visible = true;
			this.lblTeacher.Visible = true;
			this.lblTitle.Visible = true;

			this.txtCourseBrief.Visible = true;
			this.txtCourseTitle.Visible = true;
			this.txtFee.Visible = true;
			this.comboBoxLanguage.Visible = true;
			this.comboBoxTeacherId.Visible = true;
			this.btnAdd.Visible = true;
		}

		private void coursesGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//Get the current selected index
			int index = coursesGDV.CurrentRow.Index;
			ShowCourseDetails(index);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//Take the id of the course
			int index = coursesGDV.CurrentRow.Index;
			int id = Convert.ToInt32(coursesGDV.Rows[index].Cells[0].Value.ToString());

			//Uncomment to enable the deletion functionality
			//CourseRepository courseRepo = new CourseRepository();
			//courseRepo.Delete(id);
			//RefreshTable();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int index = coursesGDV.CurrentRow.Index;

			//course id
			int courseId = Convert.ToInt32(coursesGDV.Rows[index].Cells[0].Value.ToString());
			//course name
			string name = coursesGDV.Rows[index].Cells[1].Value.ToString();
			//course brief
			string brief = coursesGDV.Rows[index].Cells[2].Value.ToString();
			//tutor id
			int tutorId = Convert.ToInt32(coursesGDV.Rows[index].Cells[3].Value.ToString());
			//course fee
			decimal fee = Convert.ToDecimal(coursesGDV.Rows[index].Cells[4].Value.ToString());
			//course language
			int langId = Convert.ToInt32(coursesGDV.Rows[index].Cells[5].Value.ToString());

			courseRepo = new CourseRepository();
			course = courseRepo.GetCourseById(courseId);
			//set the value of this course
			course.course_title = name;
			course.course_brief = brief;
			course.tutor_id = tutorId;
			course.course_fee = fee;
			course.language_id = langId;
			courseRepo.Update(course);

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			//Get the user entry from the fields
			string name = this.txtCourseTitle.Text;
			string brief = this.txtCourseBrief.Text;

			string tutorId = comboBoxTeacherId.SelectedItem.ToString();

			decimal fee = Convert.ToDecimal(this.txtFee.Text);
			int languageId = this.comboBoxLanguage.SelectedIndex;
			languageId++;

			//create branch obj and set the value of it
			courseRepo = new CourseRepository();
			course = new Course();
			course.course_title = name;
			course.course_brief = brief;
			course.tutor_id = Convert.ToInt32(tutorId);
			course.course_fee = fee;
			course.language_id = languageId;
			courseRepo.Add(course);
			RefreshTable();
			lblMessage.Visible = true;
			lblMessage.Text = "Couse was added successfully";
		}
	}
}
