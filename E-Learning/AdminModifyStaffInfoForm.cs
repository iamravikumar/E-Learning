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
	public partial class AdminModifyStaffInfoForm : Form
	{
		private Teacher teacher;
		private TeacherRepository teacherRepo;

		public AdminModifyStaffInfoForm()
		{
			InitializeComponent();
		}

		private void AdminModifyStaffInfoForm_Load(object sender, EventArgs e)
		{
			RefreshTable();
			lblMessage.Text = "";
		}

		private void RefreshTable()
		{
			teacherRepo = new TeacherRepository();
			List<Teacher> teachers = teacherRepo.GetAllTeachers();
			staffGDV.DataSource = null;
			staffGDV.DataSource = teachers;

			//Hide un-neccessery table columns
			staffGDV.Columns[0].Visible = false;
			staffGDV.Columns[9].Visible = false;
			staffGDV.Columns[10].Visible = false;
			staffGDV.Columns[11].Visible = false;

			HideAddSection();

		}

		private void btnNewStaff_Click(object sender, EventArgs e)
		{
			comboBoxRollId.Items.Clear();
			comboBoxDepId.Items.Clear();
			RollRepository rollRepo = new RollRepository();
			List<Roll> rolls = rollRepo.GetAllRolls();
			foreach (Roll roll in rolls)
			{
				comboBoxRollId.Items.Add(roll.id+", "+ roll.name);
			}
			DepartmentRepository depRepo = new DepartmentRepository();
			List<Department> departments = depRepo.GetAllDepartments();
			foreach (Department department in departments)
			{
				comboBoxDepId.Items.Add(department.id + ", " + department.name);
			}
			ShowAddSection();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int index = staffGDV.CurrentRow.Index;
			int id = Convert.ToInt32(staffGDV.Rows[index].Cells[0].Value.ToString());
			lblMessage.Visible = true;
			lblMessage.Text = id.ToString();

			//Un-comment to enable the deletion functionality
			teacherRepo = new TeacherRepository();
			teacherRepo.Delete(id);
			RefreshTable();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int index = staffGDV.CurrentRow.Index;
			int id = Convert.ToInt32(staffGDV.Rows[index].Cells[0].Value.ToString());
			teacherRepo = new TeacherRepository();
			teacher = teacherRepo.GetTeacherById(id);
			teacher.first_name = staffGDV.Rows[index].Cells[1].Value.ToString();
			teacher.last_name = staffGDV.Rows[index].Cells[2].Value.ToString();
			teacher.email = staffGDV.Rows[index].Cells[3].Value.ToString();
			teacher.password = staffGDV.Rows[index].Cells[4].Value.ToString();
			teacher.qualification = staffGDV.Rows[index].Cells[5].Value.ToString();
			teacher.brief = staffGDV.Rows[index].Cells[6].Value.ToString();
			teacher.department_id = Convert.ToInt32(staffGDV.Rows[index].Cells[7].Value.ToString());
			teacher.roll_id = Convert.ToInt32(staffGDV.Rows[index].Cells[8].Value.ToString());
			teacherRepo.Update(teacher);
			lblMessage.Visible = true;
			lblMessage.Text = "Updated Successfully";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int rollId = comboBoxRollId.SelectedIndex;
				rollId++;
				if (rollId == 2)
				{
					teacherRepo = new TeacherRepository();
					teacher = new Teacher();
					teacher.first_name = textBoxFName.Text;
					teacher.last_name = textBoxLName.Text;
					teacher.email = textBoxEmail.Text;
					teacher.password = textBoxPwd.Text;
					teacher.qualification = textBoxQualification.Text;
					teacher.brief = textBoxBrief.Text;
					int deptId = comboBoxDepId.SelectedIndex;
					deptId++;
					teacher.department_id = deptId;
					teacher.roll_id = rollId;
					teacherRepo.Add(teacher);
				}
				else if (rollId == 1)
				{
					AdminRepository adminRepo = new AdminRepository();
					Admin admin = new Admin();
					admin.first_name = textBoxFName.Text;
					admin.last_name = textBoxLName.Text;
					admin.email = textBoxEmail.Text;
					admin.password = textBoxPwd.Text;
					adminRepo.Add(admin);
				}
				RefreshTable();
				lblMessage.Visible = true;
				lblMessage.Text = "Staff was added successfully";
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ShowAddSection()
		{
			//Hide add section
			lblBrief.Visible = true;
			textBoxBrief.Visible = true;
			lblDepId.Visible = true;
			comboBoxDepId.Visible = true;
			lblEmail.Visible = true;
			textBoxEmail.Visible = true;
			lblFName.Visible = true;
			textBoxFName.Visible = true;
			lblLName.Visible = true;
			textBoxLName.Visible = true;
			lblPwd.Visible = true;
			textBoxPwd.Visible = true;
			lblQualification.Visible = true;
			textBoxQualification.Visible = true;
			lblRollId.Visible = true;
			comboBoxRollId.Visible = true;
			btnAdd.Visible = true;
		}

		private void HideAddSection()
		{
			//Hide add section
			lblBrief.Visible = false;
			textBoxBrief.Visible = false;
			lblDepId.Visible = false;
			comboBoxDepId.Visible = false;
			lblEmail.Visible = false;
			textBoxEmail.Visible = false;
			lblFName.Visible = false;
			textBoxFName.Visible = false;
			lblLName.Visible = false;
			textBoxLName.Visible = false;
			lblPwd.Visible = false;
			textBoxPwd.Visible = false;
			lblQualification.Visible = false;
			textBoxQualification.Visible = false;
			lblRollId.Visible = false;
			comboBoxRollId.Visible = false;
			btnAdd.Visible = false;
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
